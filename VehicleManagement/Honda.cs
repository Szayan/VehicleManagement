using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class Honda : Motorcycle
    {
        // define model of the vehicle
        public Honda()
        {
            model = "Honda";
        }

        // unique way of horn
        public new void HonkHorn()
        {
            Console.Write("peee peee\n");
        }
    }
}
