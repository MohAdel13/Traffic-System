using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSystem
{
    internal class Driver
    {
        //***************** Local attributes *********************
        private string name="";
        private Lisence lisence=new Lisence();
        private string tel_Number="";
        private int age=0;
        private Address address=new Address();
        private char gender=' ';
        private char marital_state=' ';
        private List<Car> cars=new List<Car>();
        private string password="";

        //***************** Setters **********************
        public void setName(string N)
        {
            this.name = N;
        }
        public void setLisence(Lisence L)
        {
            this.lisence = L;
        }
        public void setNumber(string N)
        {
            this.tel_Number = N;
        }
        public void setAge(int A)
        {
            this.age = A;
        }
        public void setAddress(Address A)
        {
            this.address = A;
        }
        public void setGender(char G)
        {
            this.gender = G;
        }
        public void setMar_stat(char S)
        {
            this.marital_state = S;
        }

        public void setPassword(string P)
        {
            this.password = P;
        }

        //****************** Getters *******************
        public string getName()
        {
            return this.name;
        }
        public Lisence getLisence()
        {
            return this.lisence;
        }
        public string getNumber()
        {
            return this.tel_Number;
        }
        public int getAge()
        {
            return this.age;
        }
        public Address getAddress()
        {
            return this.address;
        }
        public char getGender()
        {
            return this.gender;
        }
        public char getMar_stat()
        {
            return this.marital_state;
        }
        public List<Car> getCars()
        {
            return this.cars;
        }

        public string getPassword()
        {
            return this.password;
        }


        //******************* Methods ******************

        //To add new owened car by the driver
        public void addCar(Car C)
        {
            cars.Add(C);
        }

        //To remove car from owened cars
        public void removeCar(Car C)
        {
            cars.Remove(C);
        }


        //To get number of cars owned by the driver
        public int carsCount()
        {
            try
            {
                return this.cars.Count();
            }
            catch
            {
                return 0;
            }
        }
    }
}
