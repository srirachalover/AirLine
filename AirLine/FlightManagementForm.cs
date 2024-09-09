using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirLine
{
    public partial class FlightManagementForm : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _adapter;
        private DataTable _table;



        public FlightManagementForm( SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadData();
        }
        private void FlightManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airTicketSystemDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airTicketSystemDataSet.Flights". При необходимости она может быть перемещена или удалена.
        }

        private void LoadData()
        {
            _command = new SqlCommand("SELECT * FROM Flights", _connection);
            _adapter = new SqlDataAdapter(_command);
            _table = new DataTable();
            _adapter.AcceptChangesDuringFill = true;
            _adapter.Fill(_table);
            dataGridView1.DataSource = _table;
            if (_table.Rows.Count > 0) { 
            txtID.Text = _table.Rows[0]["Id"].ToString();
            txtDepartureCity.Text = _table.Rows[0]["DepartureCity"].ToString();
            txtArrivalCity.Text = _table.Rows[0]["ArrivalCity"].ToString();
            txtDepartureDate.Text = _table.Rows[0]["DepartureDate"].ToString();
            txtArrivalDate.Text = _table.Rows[0]["ArrivalDate"].ToString();
            txtPrice.Text = _table.Rows[0]["Price"].ToString();
            }
            else
            {
                MessageBox.Show("В базе данных нету рейсов. Добавьте новые для продолжения работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = " ";
                txtDepartureCity.Text = " ";
                txtArrivalCity.Text = " ";
                txtDepartureDate.Text = " ";
                txtArrivalDate.Text = " ";
                txtPrice.Text = " ";
            }
        }

        private void SaveData()
        {
            try
            {
                var creatingChoice = MessageBox.Show($"Вы уверены, что хотите изменить рейс {txtDepartureCity.Text} – {txtArrivalCity.Text}?", "Подтверждение изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (creatingChoice == DialogResult.Yes)
                {

                    var selectedWay = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    _command = new SqlCommand($"SET IDENTITY_INSERT Flights ON " +
                        $"UPDATE Flights SET DepartureCity = @DepartureCity, ArrivalCity = @ArrivalCity, DepartureDate = @DepartureDate, ArrivalDate = @ArrivalDate, Price = @Price WHERE Id = {Convert.ToInt32(selectedWay)}" +
                        "SET IDENTITY_INSERT Flights OFF", _connection); ;
                    _command.Parameters.AddWithValue("@DepartureCity", txtDepartureCity.Text);
                    _command.Parameters.AddWithValue("@ArrivalCity", txtArrivalCity.Text);
                    _command.Parameters.AddWithValue("@DepartureDate", Convert.ToDateTime(txtDepartureDate.Text));
                    _command.Parameters.AddWithValue("@ArrivalDate", Convert.ToDateTime(txtArrivalDate.Text));
                    _command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    _adapter = new SqlDataAdapter(_command);
                    _table = new DataTable();
                    _adapter.Fill(_table);
                    dataGridView1.DataSource = _table;
                    LoadData();
                    MessageBox.Show("Рейс был успешно изменен.");
                }
                }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void AddData()
        {
            try
            {
                var creatingChoice = MessageBox.Show($"Вы уверены, что хотите создать рейс {txtDepartureCity.Text} – {txtArrivalCity.Text}?", "Подтверждение регистрации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (creatingChoice == DialogResult.Yes) { 
                _command = new SqlCommand("SET IDENTITY_INSERT Flights ON " +
                    "INSERT INTO Flights (Id, DepartureCity, ArrivalCity, DepartureDate, ArrivalDate, Price) VALUES (@Id, @DepartureCity, @ArrivalCity, @DepartureDate, @ArrivalDate, @Price)" +
                    "SET IDENTITY_INSERT Flights OFF", _connection);

                _command.Parameters.AddWithValue("@Id", txtID.Text);
                _command.Parameters.AddWithValue("@DepartureCity", txtDepartureCity.Text);
                _command.Parameters.AddWithValue("@ArrivalCity", txtArrivalCity.Text);
                _command.Parameters.AddWithValue("@DepartureDate", Convert.ToDateTime(txtDepartureDate.Text));
                _command.Parameters.AddWithValue("@ArrivalDate", Convert.ToDateTime(txtArrivalDate.Text));
                _command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                _adapter = new SqlDataAdapter(_command);
                _adapter.AcceptChangesDuringFill = true;
                _table = new DataTable();
                _adapter.Fill(_table);
                dataGridView1.DataSource = _table;
                LoadData();
                MessageBox.Show("Рейс был успешно создан.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void DeleteData()
        {
            try
            {
                var creatingChoice = MessageBox.Show($"Вы уверены, что хотите удалить рейс {txtDepartureCity.Text} – {txtArrivalCity.Text}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (creatingChoice == DialogResult.Yes)
                {

                    var selectedWay = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    _command = new SqlCommand($"DELETE FROM Flights WHERE Id = {Convert.ToInt32(selectedWay)}", _connection);
                    _adapter = new SqlDataAdapter(_command);
                    _adapter.AcceptChangesDuringFill = true;
                    _table = new DataTable();
                    _adapter.Fill(_table);
                    dataGridView1.DataSource = _table;
                    LoadData();
                    MessageBox.Show("Рейс был успешно удален.");
                }

                }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}