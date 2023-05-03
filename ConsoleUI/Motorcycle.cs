using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicles
	{
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcyle can go in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is in operation.");
        }

        public bool CanWheelie = true;
    }
	
}

