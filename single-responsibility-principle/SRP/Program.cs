using System;
using System.Linq;

namespace SRP
{
	class Program
	{
		static void Main(string[] args)
		{
			StandardMessages.WelcomeMessage();

			Person user = PersonDataCapture.Capture();

			AccountGenerator.CreateAccount(user);

			bool isuserValid = PersonValidator.Validate(user);

			if (!isuserValid)
			{
				StandardMessages.EndApplication();
				return;
			}

			StandardMessages.EndApplication();
		}
	}
}
