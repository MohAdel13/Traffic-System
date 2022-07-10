using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Address
    {
        //*********************** Locale attributes ************************
        private string Governorate;
        private string City;
        private string Street;

        //*********************** Setters ***************************
        public void setGovernorate(string G)
        {
            this.Governorate = G;
        }
        public void setCity(string C)
        {
            this.City = C;
        }
        public void setStreet(string S)
        {
            this.Street = S;
        }

        //*********************** Getters ************************
        public string getGovernorate()
        {
            return this.Governorate;
        }
        public string getCity()
        {
            return this.City;
        }
        public string getStreet()
        {
            return this.Street;
        }
    }
}
