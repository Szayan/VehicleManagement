using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class Volvo : Car
    {
        // define model and top speed of the vehicle
        public Volvo ()
        {
            topSpeed = 200;
            model = "Volvo";
        }

        // unique way of horn
        public new void HonkHorn()
        {
            Console.Write("peep peep\n");
        }
    }
}
