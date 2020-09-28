using System;
using System.Collections.Concurrent;
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
			Console.Write("Hello, Customer! Please enter your first name: ");
			userName = Console.ReadLine();
			return userName;
		}
		public static void Acknowledge()
		{
			Console.WriteLine($"Thank you!");
		}
		// Menu Options
		public static void NavigationPrompt()
		{
			Console.WriteLine($"What would you like to do next, {userName}?");
		}
		public static void Navigation00()
		{
			Console.WriteLine(
				"Press 1 to view your available funds." +
				"\nPress 2 to view our list of drink options." +
				"\nPress 3 to make a drink selection.");
		}
		public static void BalanceCheck(int cardAvailableFunds, int coinsInWallet)
		{
			Console.WriteLine($"The current balance is {(cardAvailableFunds*.01):c} on your card and {(coinsInWallet * .01):c} in your wallet.");
		}
		public static void SodaCheck(string cola, string orangeSoda, string rootBeer)
		{
			Console.WriteLine("We have 3 beverages for selection:" +
				$"\n{cola}" +
				$"\n{orangeSoda}" +
				$"\n{rootBeer}");
		}
		public static void BuySoda()
		{
			Console.WriteLine($"Please make your soda selection and enter the correct change, {userName}.");
		}

		// Soda List and Costs
		public static void SodaAvailable(int colasAvailable, int orangeSodasAvailable, int rootBeersAvailable, string cola, double colaCost, string orangeSoda, double osCost, string rootBeer, double rbCost)
		{
			Console.WriteLine($"Our available sodas are: " +
				$"\n C1  ({(colaCost * .01):c}) {cola}: {colasAvailable} are available for purchase!" +
				$"\n C2  ({(osCost * .01):c}) {orangeSoda}: {orangeSodasAvailable} are available for purchase!" +
				$"\n C3  ({(rbCost * .01):c}) {rootBeer}: {rootBeersAvailable} are available for purchase!" + 
				"\nPlease select one of the items above (C1/C2/C3)");
		}
		// Enter Change
		public static void EnterChange()
		{
			Console.WriteLine("What will you be depositing? " +
				"\n  Press 1 for Quarters." +
				"\n  Press 2 for Dimes." +
				"\n  Press 3 for Nickels." +
				"\n  Press 4 for Pennies.");
		}

		// Dispense Drink
		public static void DispenseDrink(Cola soda)
		{
			Console.WriteLine($"Thank you for choosing us for your beverage needs! Here comes your {soda}!");
		}
		public static void DispenseDrink(OrangeSoda soda)
		{
			Console.WriteLine($"Thank you for choosing us for your beverage needs! Here comes your {soda}!");
		}
		public static void DispenseDrink(RootBeer soda)
		{
			Console.WriteLine($"Thank you for choosing us for your beverage needs! Here comes your {soda}!");
		}
		// Dispense Change

		// Continue Message
		public static void EnterToContinue()
		{
			Console.WriteLine($"Please press any key to continue, {userName}");
			Console.ReadLine();
			Console.Clear();
		}
		// Error Messages
		public static void ValidationError()
		{
			Console.WriteLine($"Apologies, {userName}, please try selecting an option again.");
		}
	}
}
