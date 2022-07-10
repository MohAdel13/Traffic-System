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
    public partial class Officer_Mode : Form
    {
        public Officer_Mode()
        {
            InitializeComponent();
        }

        private void Officer_Mode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Officer_Mode_Load(object sender, EventArgs e)
        {
            Type_box.Items.Add("Address");
            Type_box.Items.Add("License");
            Type_box.Items.Add("Driver");
            Type_box.Items.Add("Car");
            Type_box.Items.Add("Fine");
        }

        private void Edt_btn_Click(object sender, EventArgs e)
        {
            if (Type_box.Text!="")
            {
                if (Type_box.Text=="Address")
                {
                    AddressEdit AE = new AddressEdit();
                    AE.Show();
                    this.Hide();
                }
                else if(Type_box.Text=="License")
                {
                    LisenceEdit LI=new LisenceEdit();
                    LI.Show();
                    this.Hide();
                }
                else if(Type_box.Text=="Driver")
                {
                    DriverEdit DE = new DriverEdit();
                    DE.Show();
                    this.Hide();
                }
                else if (Type_box.Text=="Car")
                {
                    CarEdit CE = new CarEdit();
                    CE.Show();
                    this.Hide();
                }
                else if(Type_box.Text=="Fine")
                {
                    FineEdit FE = new FineEdit();
                    FE.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Category.....");
                }
            }
            else
            {
                MessageBox.Show("You must choose a category to edit....");
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            Loading L = new Loading();
            L.Show();
            this.Hide();
        }
    }
}
