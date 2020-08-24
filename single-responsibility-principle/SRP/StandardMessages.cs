using System;

namespace SRP
{
	public class StandardMessages
	{
		public static void WelcomeMessage()
		{
			Console.WriteLine("Welcome to my application");
		}

		public static void EndApplication()
		{
			Console.Write("Press enter to console...");
			Console.ReadKey();
		}

		public static void DisplayValidationError(string fldName)
		{
			Console.WriteLine($"You did not give us a valid {fldName}!");
		}
	}
}