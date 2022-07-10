using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Data.SqlClient;

namespace TrafficSystem
{
    public partial class Loading : Form
    {
        ////Connect to the database
        //string ordb = "Data Source=ORCL; User Id=hr; password=tiger;";
        //OracleConnection conn;
        static string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            ////Open the connection
            //conn = new OracleConnection(ordb);
            //conn.Open();
            conn = new SqlConnection(db);
            conn.Open();
            Database.drivers = new List<Driver>();
            Database.addresses = new List<Address>();
            Database.lisences = new List<Lisence>();
            Database.officers = new List<Officer>();
            Database.driver_map = new Dictionary<string, int>();
            Database.car_map = new Dictionary<string, int>();
            Database.address_map = new Dictionary<int, int>();
            Database.lisence_map = new Dictionary<string, int>();
            Database.fine_map = new Dictionary<int, int>();
            Database.officer_map = new Dictionary<string, int>();
    }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Start_btn.Visible = false;
            load_text.Visible = true;
            this.Controls.Add(load_text);
            //OracleCommand cmd;
            //OracleDataReader dr;
            SqlCommand cmd;
            SqlDataReader dr;
            int counter;


            //Storing Addresses into code
            // cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Address";
            dr = cmd.ExecuteReader();
            Address A;
            counter = 0;
            while (dr.Read())
            {
                Database.address_map.Add(int.Parse(dr[0].ToString()), counter);
                A = new Address();
                A.setGovernorate(dr[1].ToString());
                A.setCity(dr[2].ToString());
                A.setStreet(dr[3].ToString());
                Database.addresses.Add(A);
                counter++;
            }
            dr.Close();
            load_text.Text = "LoADiNg";
            this.Controls.Add(load_text);


            //Storing lisences into code
            // cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From lisence";
            dr = cmd.ExecuteReader();
            Lisence L;
            counter = 0;
            while (dr.Read())
            {
                Database.lisence_map.Add(dr[0].ToString(), counter);
                L = new Lisence();
                L.setNumber(dr[0].ToString());
                L.setDate(dr[1].ToString());
                try
                {
                    A = Database.addresses[Database.address_map[int.Parse(dr[2].ToString())]];
                }
                catch
                {
                    A = null;
                }
                L.setAddress(A);
                Database.lisences.Add(L);
                counter++;
            }
            dr.Close();
            load_text.Text = "LOADiNg";
            this.Controls.Add(load_text);


            //Storing drivers into code
            //cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Driver";
            dr = cmd.ExecuteReader();
            Driver D;
            counter = 0;
            while (dr.Read())
            {
                Database.driver_map.Add(dr[0].ToString(), counter);
                D = new Driver();
                A = new Address();
                D.setName(dr[1].ToString());
                D.setLisence(Database.lisences[Database.lisence_map[dr[0].ToString()]]);
                D.setNumber(dr[2].ToString());
                D.setAge(int.Parse(dr[3].ToString()));
                A = Database.addresses[Database.address_map[int.Parse(dr[4].ToString())]];
                D.setAddress(A);
                D.setGender(char.Parse(dr[5].ToString()));
                D.setMar_stat(char.Parse(dr[6].ToString()));
                D.setPassword(dr[7].ToString());
                Database.drivers.Add(D);
                counter++;
            }
            dr.Close();
            load_text.Text = "LOADING";
            this.Controls.Add(load_text);

            //Storing Cars into code
            // cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Car";
            dr = cmd.ExecuteReader();
            Car C;
            counter = 0;
            while (dr.Read())
            {
                D = new Driver();
                C = new Car();
                L = new Lisence();
                L = Database.lisences[Database.lisence_map[dr[0].ToString()]];
                C.setPlat_num(L);
                C.setType(dr[1].ToString());
                C.setColor(dr[2].ToString());
                C.setModel(dr[3].ToString());
                D = Database.drivers[Database.driver_map[dr[4].ToString()]];
                counter = D.carsCount();
                Database.car_map.Add(dr[0].ToString(), counter);
                C.setOwner(D);
                C.setBuy_date(dr[5].ToString());
                Database.drivers[Database.driver_map[dr[4].ToString()]].addCar(C);
            }
            dr.Close();
            load_text.Text = "LOADING.";
            this.Controls.Add(load_text);

            //Storing fines into code
            //cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Fine";
            dr = cmd.ExecuteReader();
            Fine F;
            counter = 0;
            int ID = 0;
            while (dr.Read())
            {
                F = new Fine();
                D = new Driver();
                C = new Car();
                A = new Address();
                counter = Database.car_map[dr[2].ToString()];
                D = Database.drivers[Database.driver_map[dr[1].ToString()]];
                C = D.getCars()[counter];
                ID = C.getFines().Count();
                F.setId(int.Parse(dr[0].ToString()));
                F.setDriver(D);
                F.setCar(C);
                F.setDate(dr[3].ToString());
                A = Database.addresses[Database.address_map[int.Parse(dr[4].ToString())]];
                F.setAddress(A);
                F.setCost(int.Parse(dr[5].ToString()));
                Database.drivers[Database.driver_map[dr[1].ToString()]].getCars()[counter].addFine(F);
                Database.fine_map.Add(int.Parse(dr[0].ToString()), ID);
            }
            dr.Close();
            load_text.Text = "LOADING..";
            this.Controls.Add(load_text);


            //Storing officers into code
            //cmd = new OracleCommand();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Officer";
            dr = cmd.ExecuteReader();
            counter = 0;
            while (dr.Read())
            {
                Database.officer_map.Add(dr[0].ToString(), counter);
                Officer O = new Officer();
                O.setId(dr[0].ToString());
                O.setPassword(dr[1].ToString());
                Database.officers.Add(O);
                counter++;
            }
            dr.Close();
            load_text.Text = "LOADING..";
            this.Controls.Add(load_text);


            Login Lo = new Login();
            Lo.Show();
            this.Hide();
        }

        private void Loading_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }
    }
}
