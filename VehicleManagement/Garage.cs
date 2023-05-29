using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class Garage
    {
        public Vehicle[] parkedVehicles;

        // define parking spaces for the vehicles
        public Garage (int parkingSpaces)
        {
            parkedVehicles = new Vehicle[parkingSpaces];
        }

        public void ParkVehicle(Vehicle incomingVehicle)
        {
            bool isParked = false;
            //iterate through all the parked vehicles
            for(int counter = 0; counter <= parkedVehicles.Length-1; counter++)
            {
                // check if parking is free and incoming car is not already parked
                if(parkedVehicles[counter] == null && incomingVehicle.isParked == false)
                {
                    // park the card
                    incomingVehicle.isParked = true;
                    parkedVehicles[counter] = incomingVehicle;
                    isParked = true;
                    break;
                } 
                else
                {
                    // give the status that car is unable to parked
                    isParked = false;
                }
            }

            // display the parking status
            if(isParked)
            {
                Console.Write(incomingVehicle.model + " is parked successfully!\n");
            }
            else
            {
                Console.Write("Unable to park " + incomingVehicle + "\n");
            }
        }

        public void ListParkedVehicles()
        {
            // iterate through the vehicles and display parking status
            for (int counter = 0; counter <= parkedVehicles.Length - 1; counter++)
            {
                Console.Write(parkedVehicles[counter].model + " is parked!\n");
            }
        }

        public void GetVehicle(int parkingSpot)
        {
            // remove the vehicle from the specified parking spot
            parkedVehicles = parkedVehicles.Where((source, index) => index != parkingSpot).ToArray();
        }
    }
}
