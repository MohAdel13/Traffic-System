using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string lis = "", pass = ""; int ID=0;
            //check the entered lisence
            if (Lis_txtbox.Text!="")
            {
                //check the entered password
                if (Pass_txtbox.Text!="")
                {
                    lis = Lis_txtbox.Text;
                    pass = Pass_txtbox.Text;
                    //Search for the entered lisence in the database
                    if (radDriver.Checked)
                    {
                            try
                            {
                                ID = Database.driver_map[lis];

                                //Search for the entered password in the database
                                try
                                {
                                    if (Database.drivers[ID].getPassword() == pass)
                                    {
                                        Driver_Mode DRM = new Driver_Mode();
                                        DRM.ID = ID;
                                        DRM.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Wrong Password....");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("There's a problem in the server right now please contact us 19024");
                                }
                        }
                            catch
                            {
                                MessageBox.Show("Wrong Lisence ID....");
                            }
                           
                    }
                    else if(radOfficer.Checked)
                    {
                        try
                        {
                            ID = Database.officer_map[lis];

                            //Search for the entered password in the database
                            try
                            {
                                if (Database.officers[ID].getPassword() == pass)
                                {
                                    Officer_Mode ORM = new Officer_Mode();
                                    ORM.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong Password....");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("There's a problem in the server right now please contact us 19024");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Wrong ID....");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose the mode type to connect as....");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter your password....");
                }
            }
            else
            {
                MessageBox.Show("Please Enter your liscence ID....");
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}