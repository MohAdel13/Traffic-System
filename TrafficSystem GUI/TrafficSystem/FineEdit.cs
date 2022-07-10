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
    public partial class FineEdit : Form
    {
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand c;
        SqlCommandBuilder bldr;
        SqlDataAdapter adptr;
        DataSet ds;
        SqlDataReader dr;
        public FineEdit()
        {
            InitializeComponent();
        }

        private void FineEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Fine";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandText = "Select LisNum From Lisence Where AId=0;";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Plat_box.Items.Add(dr[0]);
            }
            dr.Close();
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandText = "Select Id From Address;";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Add_box.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Fine";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FineEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            Officer_Mode OM=new Officer_Mode();
            OM.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "")
            {
                MessageBox.Show("Please Enter a fine ID to delete....");
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
                    cmd.Parameters.AddWithValue("@ID", ID_txt.Text);
                    cmd.CommandText = "Delete From Fine Where Id=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully.....");
                }
                catch
                {
                    MessageBox.Show("The Fine ID must be a number....");
                }
            }
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            conn = new SqlConnection(db);
            conn.Open();
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandText = "Select Max(Id) From Fine";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                count = int.Parse(dr[0].ToString()) + 1;
            }
            dr.Close();
            if (Add_box.Text == "")
            {
                MessageBox.Show("Please enter the address of the fine....");
            }
            else if (Add_box.FindString(Add_box.Text) == -1)
            {
                MessageBox.Show("This address ID isn't exist....");
            }
            else if (Plat_box.Text == "")
            {
                MessageBox.Show("Please enter the Car plate number....");
            }
            else if (Plat_box.FindString(Plat_box.Text) == -1)
            {
                MessageBox.Show("This Plate number isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                string ID = "";
                c = new SqlCommand();
                c.Connection= conn;
                c.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                c.CommandText = "select Owener from car where PlatNum=@PlatNum;";
                dr = c.ExecuteReader();
                while (dr.Read())
                {
                    ID = dr[0].ToString();
                }
                dr.Close();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", count);
                cmd.Parameters.AddWithValue("@LisNum", ID);
                cmd.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Address", Add_box.Text);
                cmd.Parameters.AddWithValue("@Cost", Cost_num.Value);
                cmd.CommandText = "Insert into Fine values(@ID,@LisNum,@PlatNum,@Date,@Address,@Cost);";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully....");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            bool status = false;
            if (ID_txt.Text=="")
            {
                MessageBox.Show("Please enter an ID to edit");
            }
            else if (Add_box.Text == "")
            {
                MessageBox.Show("Please enter the address of the fine....");
            }
            else if (Add_box.FindString(Add_box.Text) == -1)
            {
                MessageBox.Show("This address ID isn't exist....");
            }
            else if (Plat_box.Text == "")
            {
                MessageBox.Show("Please enter the Car plate number....");
            }
            else if (Plat_box.FindString(Plat_box.Text) == -1)
            {
                MessageBox.Show("This Plate number isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                string ID = "";
                c = new SqlCommand();
                c.Connection = conn;
                c.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                c.CommandText = "select Owener from car where PlatNum=@PlatNum;";
                dr = c.ExecuteReader();
                while (dr.Read())
                {
                    ID = dr[0].ToString();
                }
                dr.Close();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(ID_txt.Text));
                    status = true;
                }
                catch
                {
                    MessageBox.Show("The Fine ID must be a number....");
                }
                if (status)
                {
                    cmd.Parameters.AddWithValue("@LisNum", ID);
                    cmd.Parameters.AddWithValue("@PlatNum", Plat_box.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Address", Add_box.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost_num.Value);
                    cmd.CommandText = "Update Fine set DriverLis=@LisNum,CarPlatNum=@PlatNum,D=@Date,AId=@Address,Cost=@Cost Where Id=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully....");
                }
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert: you must enter all the fine info except the ID (all fields mustn't be empty except the ID field) and click on Insert button.\n\nEdit: you must enter all the information of the fine (all fields musn't be empty <you must enter the ID of the Fine you want to edit>) and click on Edit button.\n\nDelete: you must enter the ID of the fine you want to delete and click on Delete button.\n\n----------------------------");
        }
    }
}
