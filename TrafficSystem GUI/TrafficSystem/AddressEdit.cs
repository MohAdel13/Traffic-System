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
    public partial class AddressEdit : Form
    {
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand c;
        SqlCommandBuilder bldr;
        SqlDataAdapter adptr;
        DataSet ds;
        SqlDataReader dr;
        bool First=true;
        public AddressEdit()
        {
            InitializeComponent();
        }
        private void AddressEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Address";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void AddressEdit_FormClosed(object sender, FormClosedEventArgs e)
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
            cmd.CommandText = "Select * From Address";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            conn = new SqlConnection(db);
            conn.Open();
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandText = "Select Max(Id) From Address";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                count = int.Parse(dr[0].ToString()) + 1;
            }
            dr.Close();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.Parameters.AddWithValue("@Gover", Gov_txt.Text);
            cmd.Parameters.AddWithValue("@City", Cit_txt.Text);
            cmd.Parameters.AddWithValue("@Str", St_txt.Text);
            cmd.CommandText = "Insert into Address values(@ID,@Gover,@City,@Str);";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully.....");
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "")
            {
                MessageBox.Show("Please Enter address ID to edit....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", int.Parse(ID_txt.Text));
                cmd.Parameters.AddWithValue("@Gover", Gov_txt.Text);
                cmd.Parameters.AddWithValue("@City", Cit_txt.Text);
                cmd.Parameters.AddWithValue("@Str", St_txt.Text);
                cmd.CommandText = "Update Address set Governorate=@Gover,City=@City,Street=@Str Where Id=@ID;";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.....");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "")
            {
                MessageBox.Show("Please Enter address ID to delete....");
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
                    cmd.Parameters.AddWithValue("@ID", int.Parse(ID_txt.Text));
                    cmd.CommandText = "Delete From Address Where Id=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully.....");
                }
                catch
                {
                    MessageBox.Show("This address is referenced by another data .......");
                }
            }
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

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert: Enter the Governorate,the City and the Street on there fields (these fields can be empty) and click on Insert button.\n\nEdit: Enter the new values as insert (but you must here enter the ID you want to Edit) and click on Edit button.\n\nDelete: enter the ID of the address you want to delete and click on Delete button.\n\n------------------------------------------");
        }
    }
}
