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
    public partial class Car_info : Form
    {
        public int DID = 0;
        public string plateNum = "";
        public int CID = 0;
        public Car_info()
        {
            InitializeComponent();
        }

        private void Car_info_Load(object sender, EventArgs e)
        {
            CID = Database.car_map[plateNum];
            Car C =Database.drivers[DID].getCars()[CID];
            Info_txt.Text = Environment.NewLine + "Type:     " + C.getType() + Environment.NewLine +
                "Plate-Number:    " + C.getPlat_num().getNumber() + Environment.NewLine +
                "Color:    " + C.getColor() + Environment.NewLine +
                "Model:    " + C.getModel() + Environment.NewLine + Environment.NewLine +
                "Owner:    " + C.getOwner().getName() + Environment.NewLine +
                "Buying-Date:    " + C.getBuy_date() + Environment.NewLine +
                "Fines_Count:    " + C.getFines().Count.ToString() + Environment.NewLine +
                "-----------------------------------------";
            for (int i = 0; i < C.getFines().Count; i++)
            {
                fines_box.Items.Add(C.getFines()[i].getID().ToString());
            }
        }

        private void Fine_show_Click(object sender, EventArgs e)
        {
            if (fines_box.Text == "")
            {
                MessageBox.Show("You didn't choose a fine to get info for....");
            }
            else if (fines_box.FindString(fines_box.Text) == -1)
            {
                MessageBox.Show("You entered a wrong fine ID....");
            }
            else 
            {
                Fine_info FI = new Fine_info();
                FI.DID = this.DID;
                FI.CID = this.CID;
                FI.FID = int.Parse(fines_box.Text);
                FI.Show();
                this.Hide();
            }
        }

        private void Car_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Driver_Mode DM=new Driver_Mode();
            DM.ID = DID;
            DM.Show();
            this.Hide();
        }
    }
}
