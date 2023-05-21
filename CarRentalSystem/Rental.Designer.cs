using System;
using System.Windows.Forms;

namespace CarRentalSystem
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.label4 = new System.Windows.Forms.Label();
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.FeeTb = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ReturnDatedd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.RentDatedd = new System.Windows.Forms.DateTimePicker();
            this.cdvd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mycar = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(552, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 149;
            this.label4.Text = "Cars on Rent";
            // 
            // RentDGV
            // 
            this.RentDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RentDGV.Location = new System.Drawing.Point(402, 165);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.Size = new System.Drawing.Size(452, 368);
            this.RentDGV.TabIndex = 148;
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            this.RentDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentDGV_CellMouseClick);
            // 
            // CustCb
            // 
            this.CustCb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.CustCb.ForeColor = System.Drawing.Color.DarkRed;
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CustCb.Location = new System.Drawing.Point(190, 258);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(159, 30);
            this.CustCb.TabIndex = 157;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // FeesTb
            // 
            this.FeesTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTb.ForeColor = System.Drawing.Color.DarkRed;
            this.FeesTb.Location = new System.Drawing.Point(190, 445);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(159, 28);
            this.FeesTb.TabIndex = 156;
            // 
            // FeeTb
            // 
            this.FeeTb.AutoSize = true;
            this.FeeTb.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeTb.ForeColor = System.Drawing.Color.DarkRed;
            this.FeeTb.Location = new System.Drawing.Point(16, 445);
            this.FeeTb.Name = "FeeTb";
            this.FeeTb.Size = new System.Drawing.Size(72, 35);
            this.FeeTb.TabIndex = 155;
            this.FeeTb.Text = "Fees";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(142, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 154;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReturnDatedd
            // 
            this.ReturnDatedd.CustomFormat = "yyyy-MM-dd";
            this.ReturnDatedd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDatedd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDatedd.Location = new System.Drawing.Point(190, 397);
            this.ReturnDatedd.Name = "ReturnDatedd";
            this.ReturnDatedd.Size = new System.Drawing.Size(159, 28);
            this.ReturnDatedd.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(16, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 35);
            this.label7.TabIndex = 152;
            this.label7.Text = "Return Date";
            // 
            // RentDatedd
            // 
            this.RentDatedd.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.RentDatedd.CustomFormat = "yyyy-MM-dd";
            this.RentDatedd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDatedd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RentDatedd.Location = new System.Drawing.Point(190, 355);
            this.RentDatedd.Name = "RentDatedd";
            this.RentDatedd.Size = new System.Drawing.Size(159, 28);
            this.RentDatedd.TabIndex = 151;
            // 
            // cdvd
            // 
            this.cdvd.AutoSize = true;
            this.cdvd.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdvd.ForeColor = System.Drawing.Color.DarkRed;
            this.cdvd.Location = new System.Drawing.Point(16, 355);
            this.cdvd.Name = "cdvd";
            this.cdvd.Size = new System.Drawing.Size(175, 35);
            this.cdvd.TabIndex = 147;
            this.cdvd.Text = "Rental Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(847, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 35);
            this.Close.TabIndex = 19;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rental";
            // 
            // Mycar
            // 
            this.Mycar.AutoSize = true;
            this.Mycar.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mycar.ForeColor = System.Drawing.Color.White;
            this.Mycar.Location = new System.Drawing.Point(248, 9);
            this.Mycar.Name = "Mycar";
            this.Mycar.Size = new System.Drawing.Size(365, 42);
            this.Mycar.TabIndex = 3;
            this.Mycar.Text = "CAR RENTAL SYSTEM";
            // 
            // CustNameTb
            // 
            this.CustNameTb.AcceptsReturn = true;
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.ForeColor = System.Drawing.Color.DarkRed;
            this.CustNameTb.Location = new System.Drawing.Point(190, 308);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(159, 28);
            this.CustNameTb.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(16, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 145;
            this.label2.Text = "Name";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(234, 501);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 28);
            this.button5.TabIndex = 144;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(140, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 143;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Addbtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(49, 501);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(87, 28);
            this.Addbtn.TabIndex = 142;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 141;
            this.label3.Text = "CarReg";
            // 
            // IdTb
            // 
            this.IdTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.ForeColor = System.Drawing.Color.DarkRed;
            this.IdTb.Location = new System.Drawing.Point(190, 165);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(159, 28);
            this.IdTb.TabIndex = 140;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DarkRed;
            this.Label6.Location = new System.Drawing.Point(16, 258);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 35);
            this.Label6.TabIndex = 139;
            this.Label6.Text = "CustId";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DarkRed;
            this.Label5.Location = new System.Drawing.Point(16, 165);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 35);
            this.Label5.TabIndex = 138;
            this.Label5.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Mycar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 100);
            this.panel1.TabIndex = 137;
            // 
            // CarRegCb
            // 
            this.CarRegCb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.CarRegCb.ForeColor = System.Drawing.Color.DarkRed;
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CarRegCb.Location = new System.Drawing.Point(190, 213);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(159, 30);
            this.CarRegCb.TabIndex = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(883, 23);
            this.panel4.TabIndex = 158;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(153, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 26);
            this.label8.TabIndex = 159;
            this.label8.Text = "Clear";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 634);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.FeeTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReturnDatedd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RentDatedd);
            this.Controls.Add(this.cdvd);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CarRegCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.ComboBox CustCb;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.Label FeeTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker ReturnDatedd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker RentDatedd;
        private System.Windows.Forms.Label cdvd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mycar;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CarRegCb;
        private EventHandler custCb_SelectionChangeCommitted;

        
        public EventHandler RentDate_ValueChanged { get; private set; }
        public PaintEventHandler panel1_Paint { get; private set; }
        public EventHandler CarRegCb_SelectedIndexChanged { get; private set; }
        public EventHandler CustCb_SelectedIndexChanged { get; private set; }

        public EventHandler GetCustCb_SelectionChangeCommitted()
        {
            return custCb_SelectionChangeCommitted;
        }

        private void SetCustCb_SelectionChangeCommitted(EventHandler value)
        {
            custCb_SelectionChangeCommitted = value;
        }

        private Panel panel4;
        private Label label8;
    }
}