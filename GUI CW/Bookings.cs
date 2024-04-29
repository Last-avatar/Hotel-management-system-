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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            populate();
            GetRooms();
            GetCustomers();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cheth\OneDrive\Documents\HotelDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingsDGV.DataSource = ds.Tables[0];
            con.Close();


        }
        private void GetRooms()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RoomTbl where Rstatus = 'Available' ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            RoomCb.ValueMember = "RNum";
            RoomCb.DataSource = dt;
            con.Close();
        }
        int Price = 1;
        private void fetchCost()
        {
            con.Open();
            string Query = "Select TypeCost from RoomTbl join TypeTbl on RType = TypeNum  where RNum = " + RoomCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Price = Convert.ToInt32(dr["TypeCost"].ToString());
            }
            con.Close();
        }
        private void GetCustomers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum", typeof(int));
            dt.Load(rdr);
            CustomerCb.ValueMember = "CustNum";
            CustomerCb.DataSource = dt;
            con.Close();
        }


        
        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (CustomerCb.SelectedIndex == -1 || RoomCb.SelectedIndex == -1 || AmountTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BookingTbl(Room,Customer,BookDate,Duration,Cost) values (@R,@C,@BD, @Dura,@Cost)", con);
                    cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@C",CustomerCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BD",BDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Dura",DurationTb.Text);
                    cmd.Parameters.AddWithValue("@Cost", AmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Booked!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                    SetBooked();
                    GetRooms();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void RoomCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCost();
        }

        private void DurationTb_TextChanged(object sender, EventArgs e)
        {
            if (AmountTb.Text == "")
            {
                AmountTb.Text = " Rs 0";
            }
            else
            {
                try
                {
                    int Total = Price * Convert.ToInt32(DurationTb.Text);
                    AmountTb.Text = "" + Total;
                }
                catch (Exception ex)
                {
                    
                }
                
            }
            
        }

        private void CustomerCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void CancelBooking()
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Booking!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from BookingTbl where BookNum = @Bkey", con);
                    cmd.Parameters.AddWithValue("@Bkey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Cancelling!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelBooking();
            SetAvailable();
            GetRooms();
        }
        private void SetBooked()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update RoomTbl set RStatus=@RS where RNum = @Rkey", con);
                cmd.Parameters.AddWithValue("@RS", "Booked");
               
                cmd.Parameters.AddWithValue("@Rkey", RoomCb.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Update!!!");
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
        private void SetAvailable()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update RoomTbl set RStatus=@RS where RNum = @Rkey", con);
                cmd.Parameters.AddWithValue("@RS", "Available");

                cmd.Parameters.AddWithValue("@Rkey", RoomCb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Update!!!");
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
            private void BookingsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            RoomCb.Text = BookingsDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerCb.Text = BookingsDGV.SelectedRows[0].Cells[2].Value.ToString();
            BDate.Text = BookingsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DurationTb.Text = BookingsDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = BookingsDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (AmountTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookingsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
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
