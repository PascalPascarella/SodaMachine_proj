using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	static class UserInterface
	{
		// Member Variables
		static string userName;
		// Member Method
		public static string Meet()
		{
			Console.WriteLine("Please enter your first name");
			userName = Console.ReadLine();
			return userName;
		}
		public static void Greet()
		{
			Console.WriteLine($"Thank you, {userName}!");
		}
		public static void NavigationPrompt()
		{
			Console.WriteLine($"What would you like to do next, {userName}?");
		}
	}
}
