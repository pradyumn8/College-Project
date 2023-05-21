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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pradyumn\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        public string RentId { get; private set; }

        private void fillcombo()
        {
            Con.Open();
            string query = "select RegNum from CarTb1 where Available='" + "Yes" + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNum";
            CarRegCb.DataSource = dt;
            Con.Close();
        }
        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustId from CustomerTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(rdr);
            CustCb.ValueMember = "CustId";
            CustCb.DataSource = dt;
            Con.Close();
        }
        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from customerTb1 where CustId=" + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["Custname"].ToString();
            }
            Con.Close();

        }
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
        private void UpdateonRent()
        {
            Con.Open();

            string query = "update CarTb1 set Available ='" + "No" + "'where RegNum='" + CarRegCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }
        private void UpdateonRentDelete()
        {
            Con.Open();
            string query = "update CarTb1 set Available ='" + "Yes" + "'where RegNum='" + CarRegCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id",typeof(int)),
                new DataColumn("CarReg", typeof(String)),
                new DataColumn("CustId", typeof(String)),
                new DataColumn("Name", typeof(String)),
                new DataColumn("Rental Date", typeof(String)),
                new DataColumn("Return Date", typeof(String)),
                 });
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else if(!DateComparison(RentDatedd.Text.ToString(), ReturnDatedd.Text.ToString()))
            {
                MessageBox.Show("Return date can't be before of rent date");
            }
            else
            {
                
                try
                {

                    Con.Open();
                    string query = "insert into RentalTb1 (RentId,carReg,CustName,RentDate,ReturnDate,RentFee) values (" + Convert.ToInt32(IdTb.Text) + ",'" + CarRegCb.SelectedValue.ToString() + "','" + CustNameTb.Text + "','" + RentDatedd.Value.Date + "','" + ReturnDatedd.Value.Date + "','" + FeesTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        bool DateComparison(string RentDate,string ReturnDate)

        {
            
            // Convert a null string.  
            DateTime RentDatedd = Convert.ToDateTime(RentDate);
            DateTime ReturnDatedd = Convert.ToDateTime(ReturnDate);
            int result = DateTime.Compare(RentDatedd, ReturnDatedd);


            if (result > 0)
            {
                return false;
            }
            return true;
        }
        
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " delete  from RentalTb1 where RentId=" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully ");
                    Con.Close();
                    populate();
                    UpdateonRentDelete();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            CarRegCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            FeesTb.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else if (!DateComparison(RentDatedd.Text.ToString(), ReturnDatedd.Text.ToString()))
            {
                MessageBox.Show("Return date can't be before of rent date");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update RentalTb1 set carReg='" + CarRegCb.SelectedValue.ToString() + "',CustName= '" + CustNameTb.Text + "',RentDate='" + RentDatedd.Value.Date + "', ReturnDate='" + ReturnDatedd.Value.Date + "', RentFee= " + FeesTb.Text + " where  RentId=" + Convert.ToInt32(IdTb.Text) + ";";

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

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void RentDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            CarRegCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            RentDatedd.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            ReturnDatedd.Text = RentDGV.SelectedRows[0].Cells[4].Value.ToString();
            FeesTb.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            IdTb.Text = "";
            CarRegCb.Text = "";
            CustNameTb.Text = "";
            FeesTb.Text = "";
        }
    }
}