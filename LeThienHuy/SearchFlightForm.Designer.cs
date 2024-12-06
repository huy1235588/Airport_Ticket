namespace LeThienHuy
{
    partial class SearchFlightForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radReturn = new System.Windows.Forms.RadioButton();
            this.radOneWay = new System.Windows.Forms.RadioButton();
            this.cmbCabinType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOutboundDetails = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.chkOutbound = new System.Windows.Forms.CheckBox();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.lblReturnDetails = new System.Windows.Forms.Label();
            this.dgvReturnDetails = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.fromOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinPriceOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStopsOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.lblReturn);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radReturn);
            this.groupBox1.Controls.Add(this.radOneWay);
            this.groupBox1.Controls.Add(this.cmbCabinType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(657, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(430, 54);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(95, 20);
            this.dtpReturn.TabIndex = 11;
            this.dtpReturn.Value = new System.DateTime(2023, 10, 4, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(385, 54);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(39, 13);
            this.lblReturn.TabIndex = 10;
            this.lblReturn.Text = "Return";
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOutbound.Location = new System.Drawing.Point(271, 54);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(95, 20);
            this.dtpOutbound.TabIndex = 9;
            this.dtpOutbound.Value = new System.DateTime(2023, 10, 4, 0, 0, 0, 0);
            this.dtpOutbound.ValueChanged += new System.EventHandler(this.dtpOutbound_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outbound";
            // 
            // radReturn
            // 
            this.radReturn.AutoSize = true;
            this.radReturn.Location = new System.Drawing.Point(83, 54);
            this.radReturn.Name = "radReturn";
            this.radReturn.Size = new System.Drawing.Size(57, 17);
            this.radReturn.TabIndex = 7;
            this.radReturn.TabStop = true;
            this.radReturn.Text = "Return";
            this.radReturn.UseVisualStyleBackColor = true;
            this.radReturn.CheckedChanged += new System.EventHandler(this.radReturn_CheckedChanged);
            // 
            // radOneWay
            // 
            this.radOneWay.AutoSize = true;
            this.radOneWay.Location = new System.Drawing.Point(10, 54);
            this.radOneWay.Name = "radOneWay";
            this.radOneWay.Size = new System.Drawing.Size(67, 17);
            this.radOneWay.TabIndex = 6;
            this.radOneWay.TabStop = true;
            this.radOneWay.Text = "One way";
            this.radOneWay.UseVisualStyleBackColor = true;
            // 
            // cmbCabinType
            // 
            this.cmbCabinType.FormattingEnabled = true;
            this.cmbCabinType.Location = new System.Drawing.Point(467, 17);
            this.cmbCabinType.Name = "cmbCabinType";
            this.cmbCabinType.Size = new System.Drawing.Size(121, 21);
            this.cmbCabinType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cabin type";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(229, 17);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(121, 21);
            this.cmbTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(43, 17);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(121, 21);
            this.cmbFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // dgvOutboundDetails
            // 
            this.dgvOutboundDetails.AllowUserToAddRows = false;
            this.dgvOutboundDetails.AllowUserToDeleteRows = false;
            this.dgvOutboundDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutboundDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromOutbound,
            this.toOutbound,
            this.dateOutbound,
            this.timeOutbound,
            this.flightNumberOutbound,
            this.cabinPriceOutbound,
            this.numberOfStopsOutbound,
            this.idOutbound,
            this.Column1});
            this.dgvOutboundDetails.Location = new System.Drawing.Point(12, 130);
            this.dgvOutboundDetails.Name = "dgvOutboundDetails";
            this.dgvOutboundDetails.ReadOnly = true;
            this.dgvOutboundDetails.RowHeadersVisible = false;
            this.dgvOutboundDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutboundDetails.Size = new System.Drawing.Size(859, 150);
            this.dgvOutboundDetails.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Outbound flight details";
            // 
            // chkOutbound
            // 
            this.chkOutbound.AutoSize = true;
            this.chkOutbound.Location = new System.Drawing.Point(670, 110);
            this.chkOutbound.Name = "chkOutbound";
            this.chkOutbound.Size = new System.Drawing.Size(190, 17);
            this.chkOutbound.TabIndex = 3;
            this.chkOutbound.Text = "Displays three day before and after";
            this.chkOutbound.UseVisualStyleBackColor = true;
            this.chkOutbound.CheckedChanged += new System.EventHandler(this.chkOutbound_CheckedChanged);
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.Location = new System.Drawing.Point(670, 289);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(145, 17);
            this.chkReturn.TabIndex = 6;
            this.chkReturn.Text = "Displays three day before";
            this.chkReturn.UseVisualStyleBackColor = true;
            this.chkReturn.CheckedChanged += new System.EventHandler(this.chkReturn_CheckedChanged);
            // 
            // lblReturnDetails
            // 
            this.lblReturnDetails.AutoSize = true;
            this.lblReturnDetails.Location = new System.Drawing.Point(11, 293);
            this.lblReturnDetails.Name = "lblReturnDetails";
            this.lblReturnDetails.Size = new System.Drawing.Size(97, 13);
            this.lblReturnDetails.TabIndex = 5;
            this.lblReturnDetails.Text = "Return flight details";
            // 
            // dgvReturnDetails
            // 
            this.dgvReturnDetails.AllowUserToAddRows = false;
            this.dgvReturnDetails.AllowUserToDeleteRows = false;
            this.dgvReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.idReturn,
            this.Column2});
            this.dgvReturnDetails.Location = new System.Drawing.Point(12, 312);
            this.dgvReturnDetails.Name = "dgvReturnDetails";
            this.dgvReturnDetails.ReadOnly = true;
            this.dgvReturnDetails.RowHeadersVisible = false;
            this.dgvReturnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnDetails.Size = new System.Drawing.Size(859, 150);
            this.dgvReturnDetails.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookFlight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPassenger);
            this.groupBox2.Location = new System.Drawing.Point(327, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(195, 26);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(79, 31);
            this.btnBookFlight.TabIndex = 10;
            this.btnBookFlight.Text = "Book flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Passengers";
            // 
            // txtPassenger
            // 
            this.txtPassenger.Location = new System.Drawing.Point(10, 30);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(100, 20);
            this.txtPassenger.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fromOutbound
            // 
            this.fromOutbound.HeaderText = "From";
            this.fromOutbound.Name = "fromOutbound";
            this.fromOutbound.ReadOnly = true;
            this.fromOutbound.Width = 50;
            // 
            // toOutbound
            // 
            this.toOutbound.HeaderText = "To";
            this.toOutbound.Name = "toOutbound";
            this.toOutbound.ReadOnly = true;
            this.toOutbound.Width = 50;
            // 
            // dateOutbound
            // 
            this.dateOutbound.HeaderText = "Date";
            this.dateOutbound.Name = "dateOutbound";
            this.dateOutbound.ReadOnly = true;
            // 
            // timeOutbound
            // 
            this.timeOutbound.HeaderText = "time";
            this.timeOutbound.Name = "timeOutbound";
            this.timeOutbound.ReadOnly = true;
            // 
            // flightNumberOutbound
            // 
            this.flightNumberOutbound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightNumberOutbound.HeaderText = "Flight Number(s)";
            this.flightNumberOutbound.Name = "flightNumberOutbound";
            this.flightNumberOutbound.ReadOnly = true;
            // 
            // cabinPriceOutbound
            // 
            this.cabinPriceOutbound.HeaderText = "Cabin price";
            this.cabinPriceOutbound.Name = "cabinPriceOutbound";
            this.cabinPriceOutbound.ReadOnly = true;
            // 
            // numberOfStopsOutbound
            // 
            this.numberOfStopsOutbound.HeaderText = "Number of stops";
            this.numberOfStopsOutbound.Name = "numberOfStopsOutbound";
            this.numberOfStopsOutbound.ReadOnly = true;
            // 
            // idOutbound
            // 
            this.idOutbound.HeaderText = "id";
            this.idOutbound.Name = "idOutbound";
            this.idOutbound.ReadOnly = true;
            this.idOutbound.Visible = false;
            this.idOutbound.Width = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CabinType";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Flight Number(s)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cabin price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Number of stops";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // idReturn
            // 
            this.idReturn.HeaderText = "id";
            this.idReturn.Name = "idReturn";
            this.idReturn.ReadOnly = true;
            this.idReturn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CabinType";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // SearchFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvReturnDetails);
            this.Controls.Add(this.chkReturn);
            this.Controls.Add(this.lblReturnDetails);
            this.Controls.Add(this.chkOutbound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvOutboundDetails);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.SearchFlightForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCabinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radReturn;
        private System.Windows.Forms.RadioButton radOneWay;
        private System.Windows.Forms.DataGridView dgvOutboundDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkOutbound;
        private System.Windows.Forms.CheckBox chkReturn;
        private System.Windows.Forms.Label lblReturnDetails;
        private System.Windows.Forms.DataGridView dgvReturnDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn toOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinPriceOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfStopsOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}