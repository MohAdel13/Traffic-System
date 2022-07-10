using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Database
    {
        public static List<Driver> drivers=new List<Driver>();
        public static List<Address> addresses=new List<Address>();
        public static List<Lisence> lisences=new List<Lisence>();
        public static List<Officer> officers = new List<Officer>();
        public static Dictionary<string, int> driver_map=new Dictionary<string, int>();
        public static Dictionary<string, int> car_map=new Dictionary<string, int>();
        public static Dictionary<int, int> address_map=new Dictionary<int, int>();
        public static Dictionary<string, int> lisence_map=new Dictionary<string, int>();
        public static Dictionary<int, int> fine_map=new Dictionary<int, int>();
        public static Dictionary<string,int> officer_map=new Dictionary<string, int>();
    }
}
