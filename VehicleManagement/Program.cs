using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // an instance of volvo class is created
            Volvo volvo = new Volvo();
            // accelerate method is called to speed up the car
            volvo.Accelerate();
            // accelerate method is called again to more speed up the car
            volvo.Accelerate();
            // horn is honked
            volvo.HonkHorn();
            // reduce the speed here
            volvo.Decelerate();
            // again give more speed 
            volvo.Accelerate();

            // an instance of bmw class is created
            BMW bmw = new BMW();
            // accelerate method is called to speed up the car
            bmw.Accelerate();
            // accelerate method is called again to more speed up the car
            bmw.Accelerate();
            // horn is honked
            bmw.HonkHorn();
            // reduce the speed here
            bmw.Decelerate();
            // again give more speed 
            bmw.Accelerate();

            // an instance of harleyDavidson class is created
            HarleyDavidson harleyDavidson = new HarleyDavidson();
            // accelerate method is called to speed up the car
            harleyDavidson.Accelerate();
            // accelerate method is called again to more speed up the car
            harleyDavidson.Accelerate();
            // horn is honked
            harleyDavidson.HonkHorn();
            // reduce the speed here
            harleyDavidson.Decelerate();
            // again give more speed 
            harleyDavidson.Accelerate();

            // an instance of honda class is created
            Honda honda = new Honda();
            // accelerate method is called to speed up the car
            honda.Accelerate();
            // accelerate method is called again to more speed up the car
            honda.Accelerate();
            // horn is honked
            honda.HonkHorn();
            // reduce the speed here
            honda.Decelerate();
            // again give more speed 
            honda.Accelerate();

            // an instance of garage class is created and alot total 4 parking spaces
            Garage garage = new Garage(4);
            // park volvo in garage
            garage.ParkVehicle(volvo);
            // park bmw in garage
            garage.ParkVehicle(bmw);
            // park harleyDavidson in garage
            garage.ParkVehicle(harleyDavidson);
            // park honda in garage
            garage.ParkVehicle(honda);

            // display all the parked vehicles
            garage.ListParkedVehicles();
            // remove vehicle from parking space 1
            garage.GetVehicle(1);
            // again display all parked vehicles
            garage.ListParkedVehicles();
            // remove vehicle from parking space 2
            garage.GetVehicle(2);
            // again display all parked vehicles
            garage.ListParkedVehicles();

            Console.ReadKey();

        }
    }
}
