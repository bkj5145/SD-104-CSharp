using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Class___Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            bool PromptVehicles = true;
            ShipTruck myNewShipTruck = new ShipTruck();

            while (PromptVehicles)
            {
                Console.WriteLine("What kind of vehicle do you want?");
                string userModel;
                string userMake;
                Console.Write("What is the Make of the vehicle you would like: ");
                userMake = Console.ReadLine();
                Console.Write("What is the Model of the vehicle you would like: ");
                userModel = Console.ReadLine();

                Vehicle userVehicle = new Vehicle(userMake, userModel);

                
                myNewShipTruck.AddVehicles(userVehicle);
                bool addNewVehicleValid = false;

                while (addNewVehicleValid == false)
                {
                    Console.WriteLine("Would you like to add another vehicle? Y or N");
                    string userResponse = Console.ReadLine();
                    if (userResponse.ToUpper() == "Y")
                    {
                        PromptVehicles = true;
                        addNewVehicleValid = true;
                    }
                    else
                    {
                        if (userResponse.ToUpper() == "N")
                        {
                            PromptVehicles = false;
                            addNewVehicleValid = true;
                        }
                        else if (userResponse.ToUpper() != "Y" || userResponse.ToUpper() != "N")
                        {
                            Console.WriteLine("Please enter either Y or N");
                        }
                    }
                }
                
                
               
                
            }

            for (int i = 0; i < myNewShipTruck.GetVehicles().Count; i++)
            {
                Console.Write("Vehicle-" + (i+1) + ": ");
                myNewShipTruck.GetVehicles()[i].DisplayName();
            }

            



            Console.ReadLine();

        }
    }
}
