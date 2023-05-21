using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pradyumn\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DashBoard_Load(object sender, EventArgs e)
        {
            string quercar = "Select count(*) from CarTb1";
            SqlDataAdapter sda = new SqlDataAdapter(quercar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CarLbl.Text = dt.Rows[0][0].ToString();
            string quercust = "Select count(*) from CustomerTb1";
            SqlDataAdapter sda1 = new SqlDataAdapter(quercust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CustLbl.Text = dt1.Rows[0][0].ToString();
            string querusers = "Select count(*) from UserTb1";
            SqlDataAdapter sda2 = new SqlDataAdapter(querusers, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UsersLbl.Text = dt2.Rows[0][0].ToString();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
