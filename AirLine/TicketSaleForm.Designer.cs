namespace AirLine
{
    partial class TicketSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSaleForm));
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airTicketSystemDataSet = new AirLine.AirTicketSystemDataSet();
            this.flightsTableAdapter = new AirLine.AirTicketSystemDataSetTableAdapters.FlightsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTicketSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBuyTicket.FlatAppearance.BorderSize = 0;
            this.buttonBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyTicket.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.ForeColor = System.Drawing.Color.White;
            this.buttonBuyTicket.Location = new System.Drawing.Point(249, 71);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(151, 44);
            this.buttonBuyTicket.TabIndex = 0;
            this.buttonBuyTicket.Text = "Выбрать рейс";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.AllowUserToAddRows = false;
            this.dataGridViewFlights.AllowUserToDeleteRows = false;
            this.dataGridViewFlights.AutoGenerateColumns = false;
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departureCityDataGridViewTextBoxColumn,
            this.arrivalCityDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewFlights.DataSource = this.flightsBindingSource;
            this.dataGridViewFlights.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.ReadOnly = true;
            this.dataGridViewFlights.Size = new System.Drawing.Size(643, 297);
            this.dataGridViewFlights.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureCityDataGridViewTextBoxColumn
            // 
            this.departureCityDataGridViewTextBoxColumn.DataPropertyName = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.HeaderText = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.Name = "departureCityDataGridViewTextBoxColumn";
            this.departureCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalCityDataGridViewTextBoxColumn
            // 
            this.arrivalCityDataGridViewTextBoxColumn.DataPropertyName = "ArrivalCity";
            this.arrivalCityDataGridViewTextBoxColumn.HeaderText = "ArrivalCity";
            this.arrivalCityDataGridViewTextBoxColumn.Name = "arrivalCityDataGridViewTextBoxColumn";
            this.arrivalCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите необходимый рейс для работы с пассажирами данного рейса.";
            // 
            // TicketSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirLine.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFlights);
            this.Controls.Add(this.buttonBuyTicket);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор рейса";
            this.Load += new System.EventHandler(this.TicketSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTicketSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
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
    }
}