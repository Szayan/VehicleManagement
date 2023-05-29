using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class HarleyDavidson : Motorcycle
    {
        // define model of the vehicle
        public HarleyDavidson()
        {
            model = "Harley Davidson";
        }

        // unique way of horn
        public new void HonkHorn()
        {
            Console.Write("paaa paaa\n");
        }
    }
}
