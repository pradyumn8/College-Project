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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pradyumn\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        { 
            Con.Open();
            string query = "select * from CarTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsGTV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CarsGTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNumTb.Text = CarsGTV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsGTV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsGTV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.SelectedItem = CarsGTV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarsGTV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTb1 values('" + RegNumTb.Text + "','" + BrandTb.Text + "','" + ModelTb.Text + "','" + AvailableCb.SelectedItem.ToString() + "'," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTb1 set Brand='" + BrandTb.Text + "',Model='" + ModelTb.Text + "',Available ='" + AvailableCb.SelectedItem.ToString() + "',Price=" + PriceTb.Text + "where RegNum='" + RegNumTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " delete  from CarTb1 where RegNum='" + Convert.ToString(RegNumTb.Text) + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully ");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
        
        private void Car_Load(object sender, EventArgs e)
        {
            populate();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id",typeof(int)),
                new DataColumn("RegNo", typeof(String)),
                new DataColumn("Brand", typeof(String)),
                new DataColumn("Model", typeof(String)),
                new DataColumn("Price", typeof(String))
             });

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (Search.SelectedItem.ToString() == "Available")
            {
                flag = "Yes";
            }
            else
            {
                flag = "No";
            }
            Con.Open();
            string query = "select * from CarTb1 where Available='"+flag+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsGTV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CarsGTV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RegNumTb.Text = CarsGTV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsGTV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsGTV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.SelectedItem = CarsGTV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarsGTV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            RegNumTb.Text = "";
            BrandTb.Text = "";
            ModelTb.Text = "";
            PriceTb.Text = "";
            AvailableCb.Text = "";
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {

            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " delete  from CarTb1 where RegNum='" + Convert.ToString(RegNumTb.Text) + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully ");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
          }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
