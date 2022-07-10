using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Lisence
    {
        //******************* Locale attributes *********************
        private string number;
        private string date;
        private Address address;

        //******************* Setters ********************
        public void setNumber(string N)
        {
            this.number= N;
        }
        public void setDate(string D)
        {
            this.date= D;
        }
        public void setAddress(Address A)
        {
            this.address= A;
        }

        //****************** Getters **********************
        public string getNumber()
        {
            return this.number;
        }
        public string getDate()
        {
            return this.date;
        }
        public Address getAdress()
        {
            return this.address;
        }

    }
}
