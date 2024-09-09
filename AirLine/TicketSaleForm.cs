using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirLine
{
    public partial class TicketSaleForm : Form
    {
        private readonly DatabaseConnection _databaseConnection;
        public static string SelectedFlight { get; set; }

        public TicketSaleForm()
        {
            InitializeComponent();
            _databaseConnection = new DatabaseConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");
        }

        private void TicketSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airTicketSystemDataSet.Flights);
            LoadFlights();
        }

        private void LoadFlights()
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM Flights", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataGridViewFlights.DataSource = null;
                        dataGridViewFlights.Rows.Clear();

                        while (reader.Read())
                        {
                            dataGridViewFlights.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                    }
                }
            }
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                // Получите выбранный рейс из DataGridView.
                if (dataGridViewFlights.CurrentRow != null)
                {
                    // Получите выбранный рейс из DataGridView.
                    var selectedFlight = dataGridViewFlights.CurrentRow.Cells[0].Value.ToString();
                    SelectedFlight = selectedFlight;

                    // Покажите окно диалога с вопросом о подтверждении покупки.
                    var result = MessageBox.Show("Вы уверены, что хотите зарегистрировать билет на рейс " + selectedFlight + "?", "Подтверждение регистрации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Если пользователь нажал кнопку "Да", выполните операцию покупки билета.
                    if (result == DialogResult.Yes)
                    {
                        // Выполните операцию покупки билета, используя данные из базы данных.
                        // Например, обновите статус рейса и добавьте запись в таблицу продаж.
                    SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");
                    PassengerManagementForm passengerManagementForm = new PassengerManagementForm(connection, selectedFlight);
                    passengerManagementForm.Show();
                            
                        

                        LoadFlights();
                    }
                }
                else
                {
                    // Если не выбрана ни одна строка в DataGridView, покажите сообщение об ошибке.
                    MessageBox.Show("Выберите рейс для покупки билета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}