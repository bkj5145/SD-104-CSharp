using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Class___Vehicles
{
    class Vehicle
    {

        public string Make;

        public string Model;

        public Vehicle()
        {
            Make = "Honda";
            Model = "Civic";
        }

        public Vehicle(string Make, string Model)
        {
            this.Make = Make;
            this.Model = Model;
        }

        public void Start()
        {
            Console.WriteLine("Vroooommm!!!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped!!");
        }

        public void DisplayName()
        {
            Console.WriteLine("The cars make is " + Make + ", the cars model is " + Model);
        }

        //public override string ToString()
        //{
        //    string result = Make + " " + Model;

        //    return result;
        //}

    }
}
