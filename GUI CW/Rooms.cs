using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_CW
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            populate();
            GetCategories();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cheth\OneDrive\Documents\HotelDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from RoomTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RoomsDGV.DataSource = ds.Tables[0];
            con.Close();


        }
        private void EditRooms()
        {
            if (RnameTb.Text == "" || RTypeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update RoomTbl set RName =@RN,RType=@RT,RStatus=@RS where RNum = @Rkey", con);
                    cmd.Parameters.AddWithValue("@RN", RnameTb.Text);
                    cmd.Parameters.AddWithValue("@RT", RTypeCb.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@RS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Rkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added!!!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close() ;
                }
            }
        }
        private void DeleteRooms()
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Room!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from RoomTbl where Rnum = @Rkey", con);
                    cmd.Parameters.AddWithValue("@Rkey",key);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted!!!");
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
        private void InsertRooms()
        {
            if(RnameTb.Text == "" || RTypeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RoomTbl(RName,RType,RStatus) values (@RN,@RT,@RS)", con);
                    cmd.Parameters.AddWithValue("@RN", RnameTb.Text);
                    cmd.Parameters.AddWithValue("@RT", RTypeCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RS", "Available");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated!!!");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRooms();
        }
        private void GetCategories()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TYpeTbl",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum" , typeof(int));
            dt.Load(rdr);
            RTypeCb.ValueMember = "TypeNum";
            RTypeCb.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InsertRooms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRooms();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int key = 0; 
        //private void RoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            //RnameTb.Text = RoomsDGV.SelectedRows[0].Cells[1].Value.ToString();
           //RTypeCb.Text = RoomsDGV.SelectedRows[0].Cells[2].Value.ToString();
           //StatusCb.Text = RoomsDGV.SelectedRows[0].Cells[3].Value.ToString();
           //if(RnameTb.Text == "")
           //{
           //    key = 0;
           //}
           //else
           //{
           //    key = Convert.ToInt32(RoomsDGV.SelectedRows[0].Cells[0].Value.ToString());
           //}
       // }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Types obj = new Types();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RoomsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int RowIndex = e.RowIndex;
           RnameTb.Text = RoomsDGV.SelectedRows[0].Cells[1].Value.ToString();
           RTypeCb.Text = RoomsDGV.SelectedRows[0].Cells[2].Value.ToString();
           StatusCb.Text = RoomsDGV.SelectedRows[0].Cells[3].Value.ToString();
           if(RnameTb.Text == "")
           {
               key = 0;
           }
           else
           {
               key = Convert.ToInt32(RoomsDGV.SelectedRows[0].Cells[0].Value.ToString());
           }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Bookings obj = new Bookings();
            obj.Show();
            this.Hide();
        }
    }
}
