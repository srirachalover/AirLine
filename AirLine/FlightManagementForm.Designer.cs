namespace AirLine
{
    partial class FlightManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnUpdate;
            System.Windows.Forms.Button btnInsert;
            System.Windows.Forms.Button btnDelete;
            System.Windows.Forms.Button btnClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightManagementForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airTicketSystemDataSet = new AirLine.AirTicketSystemDataSet();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDepartureCity = new System.Windows.Forms.TextBox();
            this.txtArrivalCity = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.flightsTableAdapter = new AirLine.AirTicketSystemDataSetTableAdapters.FlightsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDepartureCity = new System.Windows.Forms.Label();
            this.lbArrivalCity = new System.Windows.Forms.Label();
            this.lbDepartureDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTicketSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Roboto", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(343, 411);
            btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(108, 30);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Изменить";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsert
            // 
            btnInsert.BackColor = System.Drawing.Color.OliveDrab;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInsert.Font = new System.Drawing.Font("Roboto", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnInsert.ForeColor = System.Drawing.Color.White;
            btnInsert.Location = new System.Drawing.Point(140, 411);
            btnInsert.Margin = new System.Windows.Forms.Padding(5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(108, 30);
            btnInsert.TabIndex = 20;
            btnInsert.Text = "Добавить";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Roboto", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(540, 411);
            btnDelete.Margin = new System.Windows.Forms.Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(108, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Red;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Roboto", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(14, 171);
            btnClose.Margin = new System.Windows.Forms.Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(77, 25);
            btnClose.TabIndex = 22;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departureCityDataGridViewTextBoxColumn,
            this.arrivalCityDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Порядковый номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureCityDataGridViewTextBoxColumn
            // 
            this.departureCityDataGridViewTextBoxColumn.DataPropertyName = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.HeaderText = "Город отбытия";
            this.departureCityDataGridViewTextBoxColumn.Name = "departureCityDataGridViewTextBoxColumn";
            // 
            // arrivalCityDataGridViewTextBoxColumn
            // 
            this.arrivalCityDataGridViewTextBoxColumn.DataPropertyName = "ArrivalCity";
            this.arrivalCityDataGridViewTextBoxColumn.HeaderText = "Город прибытия";
            this.arrivalCityDataGridViewTextBoxColumn.Name = "arrivalCityDataGridViewTextBoxColumn";
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "Дата отбытия";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "Дата прибытия";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена за 1 билет";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airTicketSystemDataSet;
            // 
            // airTicketSystemDataSet
            // 
            this.airTicketSystemDataSet.DataSetName = "AirTicketSystemDataSet";
            this.airTicketSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 121);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtDepartureCity
            // 
            this.txtDepartureCity.Location = new System.Drawing.Point(343, 118);
            this.txtDepartureCity.Name = "txtDepartureCity";
            this.txtDepartureCity.Size = new System.Drawing.Size(131, 20);
            this.txtDepartureCity.TabIndex = 5;
            // 
            // txtArrivalCity
            // 
            this.txtArrivalCity.Location = new System.Drawing.Point(556, 121);
            this.txtArrivalCity.Name = "txtArrivalCity";
            this.txtArrivalCity.Size = new System.Drawing.Size(122, 20);
            this.txtArrivalCity.TabIndex = 6;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(117, 199);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(168, 20);
            this.txtDepartureDate.TabIndex = 7;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(326, 199);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(168, 20);
            this.txtArrivalDate.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(556, 199);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(122, 100);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(151, 15);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "Порядковый номер (ID)";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartureCity
            // 
            this.lbDepartureCity.AutoSize = true;
            this.lbDepartureCity.BackColor = System.Drawing.Color.Transparent;
            this.lbDepartureCity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDepartureCity.ForeColor = System.Drawing.Color.White;
            this.lbDepartureCity.Location = new System.Drawing.Point(361, 103);
            this.lbDepartureCity.Name = "lbDepartureCity";
            this.lbDepartureCity.Size = new System.Drawing.Size(96, 15);
            this.lbDepartureCity.TabIndex = 12;
            this.lbDepartureCity.Text = "Город отбытия";
            this.lbDepartureCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArrivalCity
            // 
            this.lbArrivalCity.AutoSize = true;
            this.lbArrivalCity.BackColor = System.Drawing.Color.Transparent;
            this.lbArrivalCity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbArrivalCity.ForeColor = System.Drawing.Color.White;
            this.lbArrivalCity.Location = new System.Drawing.Point(564, 103);
            this.lbArrivalCity.Name = "lbArrivalCity";
            this.lbArrivalCity.Size = new System.Drawing.Size(96, 15);
            this.lbArrivalCity.TabIndex = 13;
            this.lbArrivalCity.Text = "Город прилёта";
            this.lbArrivalCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartureDate
            // 
            this.lbDepartureDate.AutoSize = true;
            this.lbDepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDepartureDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDepartureDate.ForeColor = System.Drawing.Color.White;
            this.lbDepartureDate.Location = new System.Drawing.Point(120, 166);
            this.lbDepartureDate.Name = "lbDepartureDate";
            this.lbDepartureDate.Size = new System.Drawing.Size(158, 30);
            this.lbDepartureDate.TabIndex = 14;
            this.lbDepartureDate.Text = "Дата и время отбытия\r\n(DD.MM.YYYY HH:MM:SS)";
            this.lbDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(329, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата и время прибытия\r\n(DD.MM.YYYY HH:MM:SS)\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(537, 163);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(159, 30);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Цена одного билета, руб.\r\n(до копеек)";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AirLine.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AirLine.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(500, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::AirLine.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(303, 401);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::AirLine.Properties.Resources.add;
            this.pictureBox4.Location = new System.Drawing.Point(103, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // FlightManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirLine.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 472);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(btnClose);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnInsert);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDepartureDate);
            this.Controls.Add(this.lbArrivalCity);
            this.Controls.Add(this.lbDepartureCity);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivalCity);
            this.Controls.Add(this.txtDepartureCity);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание рейсов";
            this.Load += new System.EventHandler(this.FlightManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTicketSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDepartureCity;
        private System.Windows.Forms.TextBox txtArrivalCity;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtPrice;
        private AirTicketSystemDataSet airTicketSystemDataSet;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirTicketSystemDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDepartureCity;
        private System.Windows.Forms.Label lbArrivalCity;
        private System.Windows.Forms.Label lbDepartureDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}