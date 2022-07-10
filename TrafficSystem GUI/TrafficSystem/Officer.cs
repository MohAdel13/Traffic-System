using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Officer
    {
        //--------------------- Local attributes ----------------------
        private string ID = "";
        private string password = "";

        //----------------------- Setters -----------------------
        public void setId(string Id)
        {
            this.ID=Id;
        }
        public void setPassword(string Pass)
        {
            this.password=Pass;
        }

        //----------------------- Getters -----------------------
        public string getId()
        {
            return this.ID;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
