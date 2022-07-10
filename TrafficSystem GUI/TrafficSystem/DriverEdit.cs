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
    public partial class DriverEdit : Form
    {
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand c;
        SqlCommandBuilder bldr;
        SqlDataAdapter adptr;
        DataSet ds;
        SqlDataReader dr;
        public DriverEdit()
        {
            InitializeComponent();
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            Officer_Mode OM=new Officer_Mode();
            OM.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void DriverEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(db);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * From Driver";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "Select Id From Address";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Add_box.Items.Add(dr[0].ToString());
            }
            dr.Close();
            c = new SqlCommand();
            c.Connection = conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "Select LisNum From Lisence Where Lisence.AId > 0";
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Lis_box.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void DriverEdit_FormClosed(object sender, FormClosedEventArgs e)
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
            cmd.CommandText = "Select * From Driver";
            bldr = new SqlCommandBuilder();
            adptr = new SqlDataAdapter();
            bldr.DataAdapter = adptr;
            adptr.SelectCommand = cmd;
            ds = new DataSet();
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Female_check_CheckStateChanged(object sender, EventArgs e)
        {
            if (Female_check.Checked==true)
            {
                Male_check.Checked = false;
            }
        }

        private void Male_check_CheckStateChanged(object sender, EventArgs e)
        {
            if (Male_check.Checked == true)
            {
                Female_check.Checked = false;
            }
        }

        private void S_check_CheckStateChanged(object sender, EventArgs e)
        {
            if (S_check.Checked==true)
            {
                M_check.Checked = false;
            }
        }

        private void M_check_CheckStateChanged(object sender, EventArgs e)
        {
            if (M_check.Checked == true)
            {
                S_check.Checked = false;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Lis_box.Text == "")
            {
                MessageBox.Show("Please Enter a License to delete....");
            }
            else if (Lis_box.FindString(Lis_box.Text) == -1)
            {
                MessageBox.Show("This license number isn't exist....");
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
                    cmd.Parameters.AddWithValue("@ID", Lis_box.Text);
                    cmd.CommandText = "Delete From Driver Where LisNum=@ID;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully.....");
                }
                catch
                {
                    MessageBox.Show("This driver is referenced by another data.......");
                }
            }
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            if (Lis_box.Text == "")
            {
                MessageBox.Show("Please Enter a License to add....");
            }
            else if (Lis_box.FindString(Lis_box.Text) == -1)
            {
                MessageBox.Show("This license number isn't exist....");
            }
            else if (S_check.Checked == false && M_check.Checked == false)
            {
                MessageBox.Show("Please choose the marital state....");
            }
            else if (Tel_txt.Text == "")
            {
                MessageBox.Show("Please enter the driver number....");
            }
            else if (Add_box.Text == "")
            {
                MessageBox.Show("Please Enter an address....");
            }
            else if (Add_box.FindString(Add_box.Text) == -1)
            {
                MessageBox.Show("This address ID isn't exist....");
            }
            else if (Male_check.Checked == false && Female_check.Checked == false)
            {
                MessageBox.Show("Please choose the gender....");
            }
            else if (Name_txt.Text == "")
            {
                MessageBox.Show("Please enter the driver name....");
            }
            else if (Pass_txt.Text=="")
            {
                MessageBox.Show("Please Enter a password....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LisID", Lis_box.Text);
                cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                cmd.Parameters.AddWithValue("@TelNum", Tel_txt.Text);
                cmd.Parameters.AddWithValue("@Age", Age_num.Value);
                cmd.Parameters.AddWithValue("@AID", Add_box.Text);
                if (Male_check.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@Gender", 'M');
                }
                else if(Female_check.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@Gender", 'F');
                }
                if(M_check.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@Mar_state", 'M');
                }
                else if(S_check.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@Mar_state", 'S');
                }
                cmd.Parameters.AddWithValue("@Pass", Pass_txt.Text);
                cmd.CommandText = "Insert into Driver values(@LisID,@Name,@TelNum,@Age,@AID,@Gender,@Mar_state,@Pass);";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully....");
                }
                catch
                {
                    MessageBox.Show("This License number is already added before....");
                }
            }
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            if (Lis_box.Text == "")
            {
                MessageBox.Show("Please Enter a License to Edit....");
            }
            else if (Lis_box.FindString(Lis_box.Text) == -1)
            {
                MessageBox.Show("This license number isn't exist....");
            }
            else if (S_check.Checked == false && M_check.Checked == false)
            {
                MessageBox.Show("Please choose the marital state....");
            }
            else if (Tel_txt.Text == "")
            {
                MessageBox.Show("Please enter the driver number....");
            }
            else if (Add_box.Text == "")
            {
                MessageBox.Show("Please Enter an address....");
            }
            else if (Add_box.FindString(Add_box.Text) == -1)
            {
                MessageBox.Show("This address ID isn't exist....");
            }
            else if (Male_check.Checked == false && Female_check.Checked == false)
            {
                MessageBox.Show("Please choose the gender....");
            }
            else if (Name_txt.Text == "")
            {
                MessageBox.Show("Please enter the driver name....");
            }
            else if (Pass_txt.Text == "")
            {
                MessageBox.Show("Please Enter a password....");
            }
            else
            {
                conn = new SqlConnection(db);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LisID", Lis_box.Text);
                cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                cmd.Parameters.AddWithValue("@TelNum", Tel_txt.Text);
                cmd.Parameters.AddWithValue("@Age", Age_num.Value);
                cmd.Parameters.AddWithValue("@AID", Add_box.Text);
                if (Male_check.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Gender", 'M');
                }
                else if (Female_check.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Gender", 'F');
                }
                if (M_check.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Mar_state", 'M');
                }
                else if (S_check.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Mar_state", 'S');
                }
                cmd.Parameters.AddWithValue("@Pass", Pass_txt.Text);
                cmd.CommandText = "Update Driver set DName=@Name,Tel=@TelNum,Age=@Age,AId=@AID,Gender=@Gender,Mar_state=@Mar_state,Pass=@Pass where LisNum=@LisID;";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully....");
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert: you must enter the values in all fields (no field can be empty) and click on Insert button.\n\nEdit: as Insert but click on Edit button instead.\n\nDelete: you must enter the number of the license you want to delete and click on Delete button.\n\n------------------------------");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
