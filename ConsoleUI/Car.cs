using System;
namespace ConsoleUI
{
    public class Car : Vehicles
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is fast!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This car is in reverse.");
        }

        public bool AllWheelDrive = true;
    }
}
