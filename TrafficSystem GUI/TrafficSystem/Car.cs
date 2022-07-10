using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Car
    {
        //local attributes
        private Lisence plate_number;
        private string type;
        private string color;
        private string model;
        private Driver Owner;
        private List<Fine> fines=new List<Fine>();
        private string buying_Date;

        //setters
        public void setPlat_num(Lisence l)
        {
            this.plate_number = l;
        }
        public void setType(string T)
        {
            this.type = T;
        }

        public void setColor(string c)
        {
            this.color = c;
        }

        public void setModel(string m)
        {
            this.model = m;
        }

        public void setOwner(Driver O)
        {
            this.Owner = O;
        }

        public void setBuy_date(string d)
        {
            this.buying_Date = d;
        }

        //getters
        public Lisence getPlat_num()
        {
            return this.plate_number;
        }
        public string getType()
        {
            return this.type;
        }

        public string getColor()
        {
            return this.color;
        }

        public string getModel()
        {
            return this.model;
        }

        public Driver getOwner()
        {
            return this.Owner;
        }

        public string getBuy_date()
        {
            return this.buying_Date;
        }

        public List<Fine> getFines()
        {
            return this.fines;
        }

        //********************* Methods **********************

        //To add fine to the car
        public void addFine(Fine F)
        {
            fines.Add(F);
        }

        //To remove a fine
        public void removeFine(Fine F)
        {
            fines.Remove(F);
        }

    }
}
