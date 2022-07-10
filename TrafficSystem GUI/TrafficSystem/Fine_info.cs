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
    public partial class Fine_info : Form
    {
        public int DID = 0;
        public int CID = 0;
        public int FID = 0;
        Fine F = new Fine();
        Car C=new Car();
        public Fine_info()
        {
            InitializeComponent();
        }

        private void Fine_info_Load(object sender, EventArgs e)
        {
            C = Database.drivers[DID].getCars()[CID];
            F = C.getFines()[Database.fine_map[FID]];
            Info_txt.Text = Environment.NewLine +Environment.NewLine+ "Fine ID :    " + F.getID().ToString() + Environment.NewLine +
                Environment.NewLine+"Driver Name :    " + F.getDriver().getName() + Environment.NewLine +
                Environment.NewLine + "Car plate-number :    " + F.getCar().getPlat_num().getNumber() + Environment.NewLine +
                Environment.NewLine + "Date :    " + F.getDate() + Environment.NewLine +
                Environment.NewLine + "Address :    " + F.getAddress().getGovernorate() + " - " +
                F.getAddress().getCity() + " - " +
                F.getAddress().getStreet() + Environment.NewLine +
                Environment.NewLine + "Cost :    " + F.getCost().ToString()+ Environment.NewLine +
                "---------------------------------------------";
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fine_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Driver_Mode DM = new Driver_Mode();
            DM.ID = DID;
            DM.Show();
            this.Hide();
        }
    }
}
