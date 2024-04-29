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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cheth\OneDrive\Documents\HotelDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];
            con.Close();


        }
        private void EditUsers()
        {

            if (UnameTb.Text == "" || GenderCb.SelectedIndex == -1 || PasswordTb.Text == "" || UphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update UserTbl set UName = @UN,UPhone =@UP ,UGender =@UG ,UPassword =@UPa where UNum = @UKey", con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UP", UphoneTb.Text);
                    cmd.Parameters.AddWithValue("@UG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated!!!");
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
            InsertUsers();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUsers();
        }
    
    private void DeleteUsers()
        {
         if (key == 0)
         {
             MessageBox.Show("Select a User!!!");
         }
         else
         {
         
             try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("delete from UserTbl where UNum = @Ukey", con);
                 cmd.Parameters.AddWithValue("@Ukey", key);
         
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("User Deleted!!!");
                 con.Close();
                 populate();
             }
             catch (Exception Ex)
             {
                 MessageBox.Show(Ex.Message);
             }
         }


        }
        private void InsertUsers()
        {
            if (UnameTb.Text == "" || GenderCb.SelectedIndex == -1 || PasswordTb.Text == "" || UphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(UName,UPhone,UGender,UPassword) values (@UN,@UP,@UG,@UPa)", con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UP", UphoneTb.Text);
                    cmd.Parameters.AddWithValue("@UG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated!!!");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }
        int key = 0;
        private void UsersDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UnameTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            UphoneTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = UsersDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditUsers();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
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
    }
}
