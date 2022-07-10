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
    public partial class Driver_Mode : Form
    {
        public int ID=0;
        public Driver_Mode()
        {
            InitializeComponent();
        }

        private void Driver_Mode_Load(object sender, EventArgs e)
        {
            Driver D = Database.drivers[ID];
            Info1_txt.Text = Environment.NewLine + "Name:    " + D.getName() + Environment.NewLine +
                "Telephone-number:    " + D.getNumber() + Environment.NewLine +
                "Age:    " + D.getAge().ToString() + Environment.NewLine +
            "Address:    " + D.getAddress().getGovernorate() + " - " +
            D.getAddress().getCity() + " - " +
            D.getAddress().getStreet() + Environment.NewLine +
            "Gender:    " + D.getGender() + Environment.NewLine +
            "Marital-State:    " + D.getMar_stat() + Environment.NewLine +
            "---------------------------------------------";
            Info2_txt.Text="Lisence-Information:" + Environment.NewLine+ Environment.NewLine +
            "Number:    " + D.getLisence().getNumber() + Environment.NewLine +
            "Expire-Date:    " + D.getLisence().getDate() + Environment.NewLine +
            "Governorate:    " + D.getLisence().getAdress().getGovernorate() + Environment.NewLine +
            "City:    " + D.getLisence().getAdress().getCity() + Environment.NewLine +
            "---------------------------------------------";
            for (int i = 0; i < D.getCars().Count; i++)
            {
                Car_box.Items.Add(D.getCars()[i].getPlat_num().getNumber());
            }
        }

        private void chk_btn_Click(object sender, EventArgs e)
        {
            if (Car_box.Text == "")
            {
                MessageBox.Show("You didn't choose any car to show its info....");
            }
            else if (Car_box.FindString(Car_box.Text)==-1)
            {
                MessageBox.Show("You entered a wrong car plate number....");
            }
            else 
            {
                Car_info CI = new Car_info();
                CI.DID = this.ID;
                CI.plateNum=Car_box.Text;
                CI.Show();
                this.Hide();
            }
        }

        private void Driver_Mode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login L=new Login();
            L.Show();
            this.Hide();
        }
    }
}
