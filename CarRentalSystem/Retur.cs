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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pradyumn\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open()
            string query = "select * from RentalTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateRets()
        {
            Con.Open();
            string query = "select * from ReturnTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        {
            
                int rentId;
                rentId = Convert.ToInt32(RentDGV.SelectedRows[0].Cells[0].Value.ToString());
                Con.Open();
                string query = " delete  from RentalTb1 where RentId=" + rentId + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Rental Deleted Successfully ");
                Con.Close();
                populate();
                //   UpdateonRentDelete();
            }
          
        private void Return_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("CarIdtTb",typeof(string)),new DataColumn ("CustNameTb",typeof(string))
            });
            populate();
            populateRets();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RentDGV.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                CarIdTb.Text = row.Cells["carReg"].Value.ToString();
                CustNameTb.Text = row.Cells["CustName"].Value.ToString();
                ReturnDate.Text = row.Cells["ReturnDate"].Value.ToString();

            }

                CarIdTb.Text = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
                CustNameTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
                ReturnDate.Text = RentDGV.SelectedRows[0].Cells[4].Value.ToString();
                DateTime d1 = ReturnDate.Value.Date;
                DateTime d2 = DateTime.Now;
                TimeSpan t = d2 - d1;
                int NrOfDays = Convert.ToInt32(t.TotalDays);
                if (NrOfDays <= 0)
                {
                    DelayTb.Text = "No Delay";
                    FineTb.Text = "No Fine";

                }
                else
                {
                    DelayTb.Text = "" + NrOfDays;
                    FineTb.Text = "" + (NrOfDays * 250);
                }
               

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            if (IdTb.Text == "" || CustNameTb.Text == "" || FineTb.Text == "" || DelayTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                   
                    Con.Open();
                    string query = "insert into ReturnTb1  values (" + Convert.ToInt32(IdTb.Text) + ",'"+CarIdTb.Text+"','" + CustNameTb.Text + "','" + ReturnDate.Value.Date + "','" + DelayTb.Text + "', '" + FineTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car fully Renturned");
                    Con.Close();
             //       UpdateonRent();
                    populateRets();
                    Deleteonreturn();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void FineTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelayTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
