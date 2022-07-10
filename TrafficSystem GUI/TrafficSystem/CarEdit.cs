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

namespace TrafficSystem
{
    public partial class CarEdit : Form
    {
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand c;
        SqlCommandBuilder bldr;
        SqlDataAdapter adptr;
        DataSet ds;
        SqlDataReader dr;
        public CarEdit()
        {
            InitializeComponent();
        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Car";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            c = new SqlCommand();
            c.Connection=conn;
            c.CommandText = "Select LisNum From Lisence Where AId=0;";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Plat_box.Items.Add(dr[0]);
            }
            dr.Close();
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandText = "Select LisNum From Driver;";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Lis_box.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Car";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            Officer_Mode OM = new Officer_Mode();
            OM.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void CarEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            if (Plat_box.Text == "")
            {
                MessageBox.Show("Please Enter a Plate number to add....");
            }
            else if (Plat_box.FindString(Plat_box.Text) == -1)
            {
                MessageBox.Show("This Plate number isn't exist....");
            }
            else if (Type_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car type....");
            }
            else if (Color_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car color....");
            }
            else if (Model_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car model....");
            }
            else if (Lis_box.Text == "")
            {
                MessageBox.Show("Please Enter The owener Lisence number....");
            }
            else if (Lis_box.FindString(Lis_box.Text) == -1)
            {
                MessageBox.Show("This Lisence number isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                cmd.Parameters.AddWithValue("@Type", Type_txt.Text);
                cmd.Parameters.AddWithValue("@Color", Color_txt.Text);
                cmd.Parameters.AddWithValue("@Model", Model_txt.Text);
                cmd.Parameters.AddWithValue("@OwnID", Lis_box.Text);
                cmd.Parameters.AddWithValue("@BuyDate", dateTimePicker1.Value);
                cmd.CommandText = "Insert into Car values(@PlatNum,@Type,@Color,@Model,@OwnID,@BuyDate);";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully....");
                }
                catch
                {
                    MessageBox.Show("This plate number is already added before....");
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Plat_box.Text == "")
            {
                MessageBox.Show("Please Enter a Plate number to delete....");
            }
            else if (Plat_box.FindString(Plat_box.Text) == -1)
            {
                MessageBox.Show("This Plate number isn't exist....");
            }
            else
            {
                try
                {
                    conn = new SqlConnection(db);
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", Plat_box.Text);
                    cmd.CommandText = "Delete From Car Where PlatNum=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully.....");
                }
                catch
                {
                    MessageBox.Show("This car is referenced by another data.......");
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Plat_box.Text == "")
            {
                MessageBox.Show("Please Enter a Plate number to Edit....");
            }
            else if (Plat_box.FindString(Plat_box.Text) == -1)
            {
                MessageBox.Show("This Plate number isn't exist....");
            }
            else if (Type_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car type....");
            }
            else if (Color_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car color....");
            }
            else if (Model_txt.Text == "")
            {
                MessageBox.Show("Please enter the Car model....");
            }
            else if (Lis_box.Text == "")
            {
                MessageBox.Show("Please Enter The owener Lisence number....");
            }
            else if (Lis_box.FindString(Lis_box.Text) == -1)
            {
                MessageBox.Show("This Lisence number isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                cmd.Parameters.AddWithValue("@Type", Type_txt.Text);
                cmd.Parameters.AddWithValue("@Color", Color_txt.Text);
                cmd.Parameters.AddWithValue("@Model", Model_txt.Text);
                cmd.Parameters.AddWithValue("@OwnID", Lis_box.Text);
                cmd.Parameters.AddWithValue("@BuyDate", dateTimePicker1.Value);
                cmd.CommandText = "Update Car set Type=@Type,Color=@Color,Model=@Model,Owener=@OwnID,BuyDate=@BuyDate Where PlatNum=@PlatNum;";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully....");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert: you must enter all the car information (no field can be empty) and click on Insert button.\n\nEdit: as insert but you must click in Edit button instead.\n\nDelete: you must enter the plate number of the car you want to delete and click on Delete button.\n\n---------------------------------------------------\n\n");
        }
    }
}
