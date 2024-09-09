using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using AirLine;
using AirLine.classes;

namespace AirLine
{
    public partial class MainMenuForm : Form
    {
        private Timer timer;
        public MainMenuForm()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");


            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => clockLabel.Text = "Московское время (GMT+3):\n" + TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time")).ToString("HH:mm:ss");
            timer.Enabled = true;
        }

        private void buttonTicketSale_Click(object sender, EventArgs e)
        {
            TicketSaleForm ticketSaleForm = new TicketSaleForm();
            ticketSaleForm.Show();
        }


        private void buttonFlightManagement_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");
            FlightManagementForm flightManagementForm = new FlightManagementForm(connection);
            flightManagementForm.Show();
        }

        private void buttonPassengerManagement_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");
            PassengerManagementForm passengerManagementForm = new PassengerManagementForm(connection, TicketSaleForm.SelectedFlight);
            passengerManagementForm.Show();
        }

        private void buttonTicketPrint_Click(object sender, EventArgs e)
        {
            //TicketPrintForm ticketPrintForm = new TicketPrintForm();
            //ticketPrintForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.airTicketSystemDataSet.Flights);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Sales". При необходимости она может быть перемещена или удалена.

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}