﻿using System;
namespace ConsoleUI
{
	public abstract class Vehicles
	{
		public int Year { get; set; } = 2019;
		public string Make { get; set; } = "Defalt Make";
		public string Model { get; set; } = "Default Model";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This {GetType().Name} is in operation.");
		}

	}
}

