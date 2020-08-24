﻿using System;

namespace SRP
{
	public class PersonDataCapture
	{
		public static Person Capture()
		{
			Person output = new Person();

			Console.Write("What is your first name: ");
			output.FirstName = Console.ReadLine();

			Console.Write("What is your last name: ");
			output.LastName = Console.ReadLine();

			return output;
		}
	}
}
