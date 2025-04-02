﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool isAllWheelDrive { get; set; } = true;//SUV properties//we can display the functionality of this property without ever having to print its value to the console.... we can achieve this via writing out a method that implements it as such (see below).
        public bool hasAdaptiveCruiseControl { get; set; } = true;
        public string model { get; set; } = "Optiq";//IVehicle properties
        public int year { get; set; } = 2025;
        public int numberOfWheels { get; set; } = 4;
        public int numberOfSeats { get; set; } = 7;
        public string typeOfFuel { get; set; } = "89 Octane fuel";
        public int numberOfDoors { get; set; } = 4;
        public string companyName { get; set; } = "Cadillac";//ICompany properties
        public int numberOfYearsAsATopTen { get; set; } = 1;
        public string logo { get; set; } = "Cadillac Symbol";
        public string motto { get; set; } = "People in motion";

        public void DisplayInformation()
        {
            Console.WriteLine($"The {companyName} corporation has allegedly spent {numberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {logo} and they go by the '{motto}' motto. Their {year} {model} {isAllWheelDrive}ly does feature an all-wheel drive functionality, and it {hasAdaptiveCruiseControl}ly has its own adaptive cruise control. It sports {numberOfWheels} different wheels, but it comes equipped with {numberOfSeats} total seats, accepts a {typeOfFuel} gasoline type, and it even comes with {numberOfDoors} doors.");
            Console.WriteLine();
            //Console.WriteLine($"Currenrtly, this {year}{companyName}{model} ");
        }

        public void Drive()//IVehicle stubbed out methods.
        {
            if (isAllWheelDrive == true && hasAdaptiveCruiseControl == true)
            {
                Console.WriteLine($"The {GetType().Name} is now driving straight ahead, implementing a nifty adaptive cruise control feature, using all four of its wheels.");//here's one way of how we can provide an already defined method with even more functionality (per my note above).
                Console.WriteLine();
            }
            //if (hasAdaptiveCruiseControl == true)
            //{
            //
            //}
            else//learned that if the else statement isn't expressed here, then the script initiated by the if statement just continues to loop into whatever else is written inside of the method, beyond the if statement itself, unless an else if or else statement is explicitly typed in here with the remainder of what was written into this method as part of its scope, in which case, it will no longer execute, as the conditions of the else statement are never met in this instance.
            {
                Console.WriteLine($"The {GetType().Name} is now driving straight ahead, using only two of its wheels.");
                Console.WriteLine();
            }
        }

        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} has had its gear shifted into park.");
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (isAllWheelDrive == true && hasAdaptiveCruiseControl == true)//adaptive cruise control probably doesn't retain as much validity when being applied to a vehicle going in reverse scenario.... but why not.
            {
                Console.WriteLine($"The {GetType().Name} has been shifted into reverse, using all four of its wheels.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} has been shifted into reverse, implementing a nifty adaptive cruise control feature, using only two of its wheels.");
                Console.WriteLine();
            }
        }
    }
}
