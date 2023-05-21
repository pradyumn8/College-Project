using System;

namespace CarRentalSystem
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mycar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.FineTb = new System.Windows.Forms.TextBox();
            this.FeeTb = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ewedfw = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ReturnDGV = new System.Windows.Forms.DataGridView();
            this.DelayTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CarIdTb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Totalfees = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustNameTb
            // 
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.ForeColor = System.Drawing.Color.DarkRed;
            this.CustNameTb.Location = new System.Drawing.Point(191, 258);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(159, 28);
            this.CustNameTb.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(17, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 166;
            this.label2.Text = "Name";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Addbtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(201, 520);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(95, 28);
            this.Addbtn.TabIndex = 163;
            this.Addbtn.Text = "RETURN";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 162;
            this.label3.Text = "CarReg";
            // 
            // IdTb
            // 
            this.IdTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.ForeColor = System.Drawing.Color.DarkRed;
            this.IdTb.Location = new System.Drawing.Point(191, 148);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(159, 28);
            this.IdTb.TabIndex = 161;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DarkRed;
            this.Label5.Location = new System.Drawing.Point(17, 148);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 35);
            this.Label5.TabIndex = 159;
            this.Label5.Text = "Id";
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
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Return";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(553, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 170;
            this.label4.Text = "Cars on Rent";
            // 
            // RentDGV
            // 
            this.RentDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RentDGV.Location = new System.Drawing.Point(403, 163);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.Size = new System.Drawing.Size(452, 176);
            this.RentDGV.TabIndex = 169;
            this.RentDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentDGV_CellMouseClick);
            // 
            // FineTb
            // 
            this.FineTb.Enabled = false;
            this.FineTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineTb.ForeColor = System.Drawing.Color.DarkRed;
            this.FineTb.Location = new System.Drawing.Point(191, 395);
            this.FineTb.Name = "FineTb";
            this.FineTb.Size = new System.Drawing.Size(159, 28);
            this.FineTb.TabIndex = 177;
            // 
            // FeeTb
            // 
            this.FeeTb.AutoSize = true;
            this.FeeTb.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeTb.ForeColor = System.Drawing.Color.DarkRed;
            this.FeeTb.Location = new System.Drawing.Point(17, 395);
            this.FeeTb.Name = "FeeTb";
            this.FeeTb.Size = new System.Drawing.Size(71, 35);
            this.FeeTb.TabIndex = 176;
            this.FeeTb.Text = "Fine";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(56, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 175;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ewedfw
            // 
            this.ewedfw.AutoSize = true;
            this.ewedfw.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ewedfw.ForeColor = System.Drawing.Color.DarkRed;
            this.ewedfw.Location = new System.Drawing.Point(17, 305);
            this.ewedfw.Name = "ewedfw";
            this.ewedfw.Size = new System.Drawing.Size(179, 35);
            this.ewedfw.TabIndex = 168;
            this.ewedfw.Text = "Return Date";
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
            this.panel1.Size = new System.Drawing.Size(882, 100);
            this.panel1.TabIndex = 158;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(553, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 35);
            this.label8.TabIndex = 180;
            this.label8.Text = "Cars Returned";
            // 
            // ReturnDGV
            // 
            this.ReturnDGV.BackgroundColor = System.Drawing.Color.White;
            this.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ReturnDGV.Location = new System.Drawing.Point(403, 399);
            this.ReturnDGV.Name = "ReturnDGV";
            this.ReturnDGV.Size = new System.Drawing.Size(452, 176);
            this.ReturnDGV.TabIndex = 179;
            this.ReturnDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnDGV_CellContentClick);
            // 
            // DelayTb
            // 
            this.DelayTb.Enabled = false;
            this.DelayTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayTb.ForeColor = System.Drawing.Color.DarkRed;
            this.DelayTb.Location = new System.Drawing.Point(191, 351);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(159, 28);
            this.DelayTb.TabIndex = 182;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(17, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 35);
            this.label7.TabIndex = 181;
            this.label7.Text = "Delay";
            // 
            // CarIdTb
            // 
            this.CarIdTb.Enabled = false;
            this.CarIdTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdTb.ForeColor = System.Drawing.Color.DarkRed;
            this.CarIdTb.Location = new System.Drawing.Point(191, 206);
            this.CarIdTb.Name = "CarIdTb";
            this.CarIdTb.Size = new System.Drawing.Size(159, 28);
            this.CarIdTb.TabIndex = 183;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 23);
            this.panel4.TabIndex = 184;
            // 
            // Totalfees
            // 
            this.Totalfees.Enabled = false;
            this.Totalfees.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalfees.ForeColor = System.Drawing.Color.DarkRed;
            this.Totalfees.Location = new System.Drawing.Point(191, 442);
            this.Totalfees.Name = "Totalfees";
            this.Totalfees.Size = new System.Drawing.Size(159, 28);
            this.Totalfees.TabIndex = 186;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(17, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 35);
            this.label6.TabIndex = 185;
            this.label6.Text = "Total Fees";
            // 
            // ReturnDate
            // 
            this.ReturnDate.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.ReturnDate.CustomFormat = "yyyy-MM-dd";
            this.ReturnDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDate.Location = new System.Drawing.Point(191, 305);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(159, 28);
            this.ReturnDate.TabIndex = 172;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 634);
            this.Controls.Add(this.Totalfees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CarIdTb);
            this.Controls.Add(this.DelayTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReturnDGV);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.FineTb);
            this.Controls.Add(this.FeeTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.ewedfw);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mycar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.TextBox FineTb;
        private System.Windows.Forms.Label FeeTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ewedfw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ReturnDGV;
        private System.Windows.Forms.TextBox DelayTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CarIdTb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Totalfees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ReturnDate;
    }
}