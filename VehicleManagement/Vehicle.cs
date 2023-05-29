using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    public class Vehicle
    {
        public int topSpeed;
        public int currentSpeed;
        public int changeInSpeed;
        public string model;
        public Random rand = new Random();
        public bool isParked;

        // contructor to initialize all the variables
        public Vehicle()
        {
            topSpeed = 60;
            model = "No model";
            currentSpeed = 0;
            isParked = false;
        }

        public void Accelerate()
        {
            // get the random number and store it in a variable
            changeInSpeed = rand.Next(0, topSpeed);

            // add the new speed change in current speed of the vehicle
            currentSpeed = currentSpeed + changeInSpeed;

            // verify if current speed does not exceed the top speed. if exceeds than do not make the change and reverse the speed
            if(currentSpeed > topSpeed) {
                currentSpeed = currentSpeed - changeInSpeed;
                changeInSpeed = 0;
            } 
            else
            {
                ShowCurrentSpeed();
            }
        }

        public void Decelerate()
        {
            // get the random number and store it in a variable
            changeInSpeed = rand.Next(0, topSpeed);

            // subtract the new speed change in current speed of the vehicle
            currentSpeed = currentSpeed - changeInSpeed;

            //verify if current speed is not less than zero. if less than zero than reverse the change
            if (currentSpeed < 0)
            {
                currentSpeed = currentSpeed + changeInSpeed;
                changeInSpeed = 0;
            }
            else
            {
                ShowCurrentSpeed();
            }
        }

        public void ShowCurrentSpeed()
        {
            // print current speed of the vehicle
            Console.Write(model + " is going " + currentSpeed + "km/h\n");
        }

        public void HonkHorn()
        {
            // print he horn of the selected vehicle model
            Console.Write(model + " honked the horn!\n");
        }
    }
}
