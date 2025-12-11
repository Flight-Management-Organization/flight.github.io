namespace Flight_Management_System_2
{
    partial class FlightSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dptDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Flights";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(211, 100);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(41, 16);
            this.lblOrigin.TabIndex = 1;
            this.lblOrigin.Text = "From:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.AccessibleDescription = "";
            this.txtOrigin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtOrigin.Location = new System.Drawing.Point(258, 97);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(163, 22);
            this.txtOrigin.TabIndex = 2;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(611, 100);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(27, 16);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "To:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(644, 97);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(177, 22);
            this.txtDestination.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Departure Date:";
            // 
            // dptDepartureDate
            // 
            this.dptDepartureDate.Location = new System.Drawing.Point(321, 142);
            this.dptDepartureDate.MinDate = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            this.dptDepartureDate.Name = "dptDepartureDate";
            this.dptDepartureDate.Size = new System.Drawing.Size(250, 22);
            this.dptDepartureDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Passengers:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(765, 142);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(506, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search Flights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Available Flights:";
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToResizeColumns = false;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dgvFlights.Location = new System.Drawing.Point(116, 300);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(931, 150);
            this.dgvFlights.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Select Flight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FlightId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Flight Number";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Departure Time";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Arrival Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Duration";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Available Seats";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // FlightSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 608);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dptDepartureDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.label1);
            this.Name = "FlightSearchForm";
            this.Text = "FlightSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dptDepartureDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}