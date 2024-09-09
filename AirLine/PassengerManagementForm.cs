using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirLine
{
    public partial class PassengerManagementForm : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _adapter;
        private DataTable _table;
        private string _selectedFlight;
        public static string SelectedPassenger { get; set; }


        public PassengerManagementForm(SqlConnection connection, string selectedFlight)
        {
            InitializeComponent();
            _connection = connection;
            _selectedFlight = selectedFlight;
            LoadData();
        }

        private void LoadData()
        {
            _command = new SqlCommand($"SELECT * FROM Sales1 WHERE FlightId = {Convert.ToInt32(_selectedFlight)}", _connection);
            _adapter = new SqlDataAdapter(_command);
            _table = new DataTable();
            _adapter.AcceptChangesDuringFill = true;
            _adapter.Fill(_table);
            dgPassengers.DataSource = _table;
            if (_table.Rows.Count > 0)
            {
                txtID.Text = _table.Rows[0]["Id"].ToString();
                txtFirstName.Text = _table.Rows[0]["FirstName"].ToString();
                txtSurname.Text = _table.Rows[0]["LastName"].ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(_table.Rows[0]["BirthDate"]);
                dtpDate.Value = Convert.ToDateTime(_table.Rows[0]["Date"]);
                txtPassportNumber.Text = _table.Rows[0]["PassportNumber"].ToString();
            }
            else
            {
                MessageBox.Show("В базе данных нету пассажиров. Добавьте новых для продолжения работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = " ";
                txtFirstName.Text = " ";
                txtSurname.Text = " ";
                dtpDateOfBirth.Value = new DateTime(2023, 8, 26);
                dtpDate.Value = new DateTime(2023, 8, 26);
                txtPassportNumber.Text = " ";
            }
        }

        private void SaveData()
        {
            var creatingChoice = MessageBox.Show($"Вы уверены, что хотите обновить данные пассажира {txtFirstName.Text} {txtSurname.Text}?", "Подтверждение изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (creatingChoice == DialogResult.Yes)
                {
                    var selectedPassenger = dgPassengers.CurrentRow.Cells[0].Value.ToString();

                    _connection.Open();

                    // Отключить автоматическое сброс идентификаторов
                    _command = new SqlCommand("SET IDENTITY_INSERT Sales1 OFF", _connection);
                    _command.ExecuteNonQuery();

                    // Обновить данные пассажира
                    _command = new SqlCommand($"UPDATE Sales1 SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate, PassportNumber = @PassportNumber, FlightId = @FlightId, Date = @Date, Status = @Status WHERE Id = {Convert.ToInt32(selectedPassenger)}", _connection);
                    _command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    _command.Parameters.AddWithValue("@LastName", txtSurname.Text);
                    _command.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(dtpDateOfBirth.Text));
                    _command.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpDate.Text));
                    _command.Parameters.AddWithValue("@PassportNumber", txtPassportNumber.Text);
                    _command.Parameters.AddWithValue("@FlightId", Convert.ToInt32(_selectedFlight));
                    _command.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    _command.ExecuteNonQuery();

                    // Включить автоматическое сброс идентификаторов
                    _command = new SqlCommand("SET IDENTITY_INSERT Sales1 ON", _connection);
                    _command.ExecuteNonQuery();

                    LoadData();
                    MessageBox.Show("Пассажир был успешно изменен.");
                }
        }

        private void AddData()
        {
            try
            {
                var creatingChoice = MessageBox.Show($"Вы уверены, что хотите зарегистировать пассажира {txtFirstName.Text} {txtSurname.Text}?", "Подтверждение регистрации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (creatingChoice == DialogResult.Yes)
                {
                    _command = new SqlCommand("SET IDENTITY_INSERT Sales1 ON " + "INSERT INTO Sales1 (Id, FirstName, LastName, Date, FlightId, BirthDate, PassportNumber, Status) VALUES (@Id, @FirstName, @LastName, @Date, @FlightId, @BirthDate, @PassportNumber, @Status)" + "SET IDENTITY_INSERT Sales1 OFF", _connection);
                    _command.Parameters.AddWithValue("@Id", txtID.Text);
                    _command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    _command.Parameters.AddWithValue("@LastName", txtSurname.Text);
                    _command.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(dtpDateOfBirth.Text));
                    _command.Parameters.AddWithValue("@PassportNumber", txtPassportNumber.Text);
                    _command.Parameters.AddWithValue("@FlightId", Convert.ToInt32(_selectedFlight));
                    _command.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpDate.Text));
                    _command.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    _adapter = new SqlDataAdapter(_command);
                    _adapter.AcceptChangesDuringFill = true;
                    _table = new DataTable();
                    _adapter.Fill(_table);
                    dgPassengers.DataSource = _table;
                    LoadData();
                    MessageBox.Show("Пассажир был успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void DeleteData()
        {
            
                var creatingChoice = MessageBox.Show($"Вы уверены, что хотите удалить пассажира {txtFirstName.Text} {txtSurname.Text}?", "Подтверждение регистрации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (creatingChoice == DialogResult.Yes)
                {
                var selectedPassenger = dgPassengers.CurrentRow.Cells[0].Value.ToString();
                _command = new SqlCommand($"DELETE FROM Sales1 WHERE Id = {Convert.ToInt32(selectedPassenger)}", _connection);
                _adapter = new SqlDataAdapter(_command);
                _adapter.AcceptChangesDuringFill = true;
                _table = new DataTable();
                _adapter.Fill(_table);
                dgPassengers.DataSource = _table;
                LoadData();
                MessageBox.Show("Пассажир был успешно удален.");
                }
            
            
        }
        private void PDF()
        {
            var creatingChoice = MessageBox.Show($"Вы уверены, что хотите распечатать билет пассажира {txtFirstName.Text} {txtSurname.Text}?", "Подтверждение печати", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (creatingChoice == DialogResult.Yes)
            {
                var selectedPassenger = dgPassengers.CurrentRow.Cells[0].Value.ToString();
                SelectedPassenger = selectedPassenger;
                SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirTicketSystem;Integrated Security=True");
                TicketForm ticketForm = new TicketForm(connection, selectedPassenger);
                ticketForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Код обработки события
        }
        private void PassengerManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Sales1". При необходимости она может быть перемещена или удалена.
            this.sales1TableAdapter.Fill(this.airTicketSystemDataSet.Sales1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Sales1". При необходимости она может быть перемещена или удалена.
            this.sales1TableAdapter.Fill(this.airTicketSystemDataSet.Sales1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Sales1". При необходимости она может быть перемещена или удалена.
            // Код инициализации формы
            label1.Text = $"Номер рейса: {Convert.ToInt32(_selectedFlight)}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PDF();
        }
    }
}