using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Fine
    {
        //********************* Locale attributes **********************
        private Driver driver=new Driver();
        private Car car=new Car();
        private string date="";
        private Address address=new Address();
        private int Cost=0;
        private int ID=0;

        //******************** Setters *************************
        public void setDriver(Driver D)
        {
            this.driver = D;
        }
        public void setCar(Car C)
        {
            this.car= C;
        }
        public void setDate(string D)
        {
            this.date= D;
        }
        public void setAddress(Address A)
        {
            this.address= A;
        }
        public void setCost(int C)
        {
            this.Cost= C;
        }
        public void setId (int ID)
        {
            this.ID= ID;
        }
        //********************* Getters **********************
        public Driver getDriver()
        {
            return this.driver;
        }
        public Car getCar()
        {
            return this.car;
        }
        public string getDate()
        {
            return this.date;
        }
        public Address getAddress()
        {
            return this.address;

        }
        public int getCost()
        {
            return this.Cost;
        }
        public int getID()
        {
            return this.ID;
        }
    }
}
