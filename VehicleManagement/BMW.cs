using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class BMW : Car
    {
        // define model and top speed of the vehicle
        public BMW()
        {
            topSpeed = 200;
            model = "BMW";
        }

        // unique way of horn
        public new void HonkHorn()
        {
            Console.Write("beep beep\n");
        }
    }
}
