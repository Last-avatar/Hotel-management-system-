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
    public partial class Types: Form
    {
        public Types()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cheth\OneDrive\Documents\HotelDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from TYpeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TypesDGV.DataSource = ds.Tables[0];
            con.Close();
            

        }
        private void InsertCategories()
        {
            if (TypeNameTb.Text == "" || CostTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TYpeTbl(TypeName,TypeCost) values (@TN,@TC)", con);
                    cmd.Parameters.AddWithValue("@TN", TypeNameTb.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Insertrd!!!");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void Types_Load(object sender, EventArgs e)
        {

        }
        private void EditCategories()
        {
            if (TypeNameTb.Text == "" || CostTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update TYpeTbl set TypeName =@TN,TypeCost=@TC where TypeNum = @TKey", con);
                    cmd.Parameters.AddWithValue("@TN", TypeNameTb.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@TKey",Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated!!!");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void DeleteCategories()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Category!!!");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TYpeTbl where TypeNum = @Tkey", con);
                    cmd.Parameters.AddWithValue("@Tkey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted!!!");
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
            InsertCategories();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Rooms obj = new Rooms();
            obj.Show();
            this.Hide();
        }
        int Key = 0;
        private void TypesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCategories();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCategories();
        }

        private void TypesDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TypeNameTb.Text = TypesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostTb.Text = TypesDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (TypeNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TypesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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
