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
		public static void SodaCheck()
		{

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
				$"\n C3  ({(rbCost * .01):c}) {rootBeer}: {rootBeersAvailable} are available for purchase!");
		}

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
