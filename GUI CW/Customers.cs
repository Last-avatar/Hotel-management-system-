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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_CW
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            populate();
        }
        int key = 0;


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cheth\OneDrive\Documents\HotelDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            con.Close();


        }
        private void EditCustomers()
        {
            if (CnameTB.Text == "" || GenderCb.SelectedIndex == -1 || phoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName=@CN,CustPhone=@CP,CustGender=@CG where CustNum=@Ckey", con);
                    cmd.Parameters.AddWithValue("@CN", CnameTB.Text);
                    cmd.Parameters.AddWithValue("@CP", phoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeleteCustomer()
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Customer!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where Custnum = @Ckey", con);
                    cmd.Parameters.AddWithValue("@Ckey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }


        }
        private void InsertCustomer()
        {
            if (CnameTB.Text == "" || GenderCb.SelectedIndex == -1 || phoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustName,CustPhone,CustGender) values (@CN,@CP,@CG)", con);
                    cmd.Parameters.AddWithValue("@CN",CnameTB.Text);
                    cmd.Parameters.AddWithValue("@CP",phoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertCustomer();
        }
        private void CustomersDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CnameTB.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            phoneTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (CnameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCustomers();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Rooms obj = new Rooms();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Types obj = new Types();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Bookings obj = new Bookings();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
