using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Class___Vehicles
{
    class ShipTruck
    {
        private List<Vehicle> myVehicles = new List<Vehicle>();

        public List<Vehicle> GetVehicles()
        {
            return myVehicles;
        }

        public void AddVehicles(Vehicle addedVehicle)
        {
            myVehicles.Add(addedVehicle);
        }

        
    }
}
