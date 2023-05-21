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
        private object TofeeTb;

        private void populate()
        {
            Con.Open();
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
            private void ReturnDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
       
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }
                private void Deleteonreturn()
        {
            int rentId;
            rentId = Convert.ToInt32(RentDGV.SelectedRows[0].Cells[0].Value.ToString());
            Con.Open();
            string query = " delete  from RentalTb1 where RentId=" +rentId+ ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populate();
        }
        private void Return_Load(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("CarIdTb",typeof(string)),
                    new DataColumn ("CustNameTb",typeof(string))
            });
                this.RentDGV.DataSource = dt;
                this.RentDGV.AllowUserToAddRows = false;
                populate();
                populateRets();
            }
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
                    string query = "insert into ReturnTb1  values (" + Convert.ToInt32(IdTb.Text) + ",'" + CarIdTb.Text + "','" + CustNameTb.Text + "','" + ReturnDate.Value.Date + "','" + DelayTb.Text + "', " + FineTb.Text + "," + Totalfees.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car fully Renturned");
                    Con.Close();
                    populateRets();
                    Deleteonreturn();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }    
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RentDGV.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                CarIdTb.Text = row.Cells[1].Value.ToString();
                CustNameTb.Text = row.Cells[2].Value.ToString();
                ReturnDate.Text = row.Cells[4].Value.ToString();
                String RentDate = row.Cells[3].Value.ToString();
                DateTime d1 = ReturnDate.Value;
                DateTime d2 = Convert.ToDateTime(RentDate); 
                TimeSpan t = d1 - d2;
               
                int NrOfDays = Convert.ToInt32(t.TotalDays);
                if (NrOfDays <= 0)
                {
                    DelayTb.Text = "No Delay";
                    FineTb.Text = "0";

                }
                else
                {
                    DelayTb.Text = "" + NrOfDays;
                    FineTb.Text = "" + (NrOfDays * 250);
                    TofeeTb = "" + FeeTb + FineTb;
                }
                IdTb.Text = FetchId();
                Totalfees.Text = Convert.ToString(Convert.ToInt32(row.Cells[5].Value.ToString()) + Convert.ToInt32(FineTb.Text.ToString()));
                
            }
        }
        string FetchId()
        {
            Con.Open();
            string query = "select ReturnId from ReturnTb1 ORDER BY ReturnId DESC ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();
            string count = "";
            while (rdr.Read())
            {
              
                int counter = Convert.ToInt32(rdr["ReturnId"].ToString());
                count = Convert.ToString(counter + 1);
                break;
            }
                Con.Close();
            return count;
        }
    }
}
