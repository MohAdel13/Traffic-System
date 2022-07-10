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
    public partial class LisenceEdit : Form
    {
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand c;
        SqlCommandBuilder bldr;
        SqlDataAdapter adptr;
        DataSet ds;
        SqlDataReader dr;
        public LisenceEdit()
        {
            InitializeComponent();
        }

        private void LisenceEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Lisence";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            c = new SqlCommand();
            c.Connection=conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "Select Id From Address";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Add_box.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void LisenceEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Lisence";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            Officer_Mode OM = new Officer_Mode();
            OM.Show();
            this.Hide();
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            if (Lis_txt.Text=="")
            {
                MessageBox.Show("Please Enter a License to add....");
            }
            else if(Add_box.FindString(Add_box.Text)==-1)
            {
                MessageBox.Show("This Address ID isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LisID", Lis_txt.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                if (Add_box.Text == "")
                {
                    cmd.CommandText = "Insert into Lisence values(@LisID,@Date,0);";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AID", int.Parse(Add_box.Text));
                    cmd.CommandText = "Insert into Lisence values(@LisID,@Date,@AID);";
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully.....");
                }
                catch
                {
                    MessageBox.Show("This License number is already added before....");
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Lis_txt.Text == "")
            {
                MessageBox.Show("Please Enter a License to edit....");
            }
            else if (Add_box.FindString(Add_box.Text) == -1)
            {
                MessageBox.Show("This Address ID isn't exist....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LisID", Lis_txt.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                if (Add_box.Text == "")
                {
                    cmd.CommandText = "Update Lisence set D=@Date,AID=0 Where LisNum=@LisID;";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AID", int.Parse(Add_box.Text));
                    cmd.CommandText = "Update Lisence set D=@Date,AID=@AID Where LisNum=@LisID;";
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.....");               
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Lis_txt.Text == "")
            {
                MessageBox.Show("Please Enter a License to delete....");
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
                    cmd.Parameters.AddWithValue("@ID", Lis_txt.Text);
                    cmd.CommandText = "Delete From Lisence Where LisNum=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully.....");
                }
                catch
                {
                    MessageBox.Show("This license is referenced by another data .......");
                }
            }
        }


        private void Helpbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert: You must enter the License number, Expire date and the ID of the Address (Address id field can be empty) and press Insert button.\n\nEdit: you need to enter the License number you want to edit, the new expire date and the new address ID(Address ID field can be empty) and click on Edit button.\n\nDelete:you need to enter the number of the license you want to delete and click on Delete button.\n\n--------------------------------------");
        }
    }
}
