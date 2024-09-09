using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.Data.Common;
using System.IO;
using System.Runtime.ExceptionServices;

namespace AirLine
{
    public partial class TicketForm : Form
    {
        private string _selectedFlight;

        public TicketForm(SqlConnection connection, string selectedPassenger)
        {
            InitializeComponent();
            _selectedFlight = selectedPassenger;
        }

        private void CreateTicketButton_Click(object sender, EventArgs e)
        {
            // Подключаемся к базе данных
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Выполняем SQL-запрос
                string query = "SELECT s.FirstName, s.LastName, s.PassportNumber, f.DepartureCity, f.ArrivalCity, f.DepartureDate, f.ArrivalDate FROM Sales1 s JOIN Flights f ON s.FlightId = f.Id WHERE s.Id = @id"; SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(_selectedFlight)); // ID, который был выбран в предыдущем окне

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();

                    // Сохранение файла на рабочем столе
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, $"Ticket Of {firstName} {lastName}.pdf");

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {

                        // Создаем новый PDF-документ
                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                        document.Open();

                        // Создаем шрифты для документа
                        BaseFont bf = BaseFont.CreateFont("Roboto-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font1 = new iTextSharp.text.Font(bf, 28);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

                        // Создаем заголовок для билета
                        Paragraph title = new Paragraph($"FlightTicket of {firstName} {lastName}", font1);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);

                        // Добавляем графические элементы
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Logo.png");
                        logo.ScaleToFit(100, 100);
                        logo.Alignment = Element.ALIGN_CENTER;
                        document.Add(logo);

                        Paragraph line = new Paragraph(new Chunk(new string('_', (int)PageSize.A4.Width), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Gray.R, System.Drawing.Color.Gray.G, System.Drawing.Color.Gray.B))));
                        line.Alignment = Element.ALIGN_CENTER;
                        document.Add(line);

                        Paragraph name = new Paragraph("Имя: " + reader["FirstName"], font);
                        Paragraph surname = new Paragraph("Фамилия: " + reader["LastName"], font);
                        Paragraph passport = new Paragraph("Номер паспорта: " + reader["PassportNumber"], font);
                        Paragraph departureCity = new Paragraph("Город отправления: " + reader["DepartureCity"], font);
                        Paragraph arrivalCity = new Paragraph("Город прибытия: " + reader["ArrivalCity"], font);
                        Paragraph departureDate = new Paragraph("Дата отправления: " + reader["DepartureDate"], font);
                        Paragraph arrivalDate = new Paragraph("Дата прибытия: " + reader["ArrivalDate"], font);

                        Paragraph data = new Paragraph();
                        data.Add(name);
                        data.Add(surname);
                        data.Add(passport);
                        data.Add(departureCity);
                        data.Add(arrivalCity);
                        data.Add(departureDate);
                        data.Add(arrivalDate);

                        document.Add(data);

                        document.Close();

                        MessageBox.Show("Билет был сохранён на рабочий стол");

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Информация не найдена");
                }
            }
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}