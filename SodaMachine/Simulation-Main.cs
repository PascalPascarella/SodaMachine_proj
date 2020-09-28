using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	class Simulation_Main
	{
		// Member Variables
		public SodaMachine sodaMachine;
		public Customer customer;
		public int userInput;
		public bool validChoice;
		public string sodaSelection;
		// Constructor
		public Simulation_Main()
		{
			sodaMachine = new SodaMachine();
			customer = new Customer();
		}
		// Member Method
		public void Main()
		{
			UserInterface.Meet();
			UserInterface.Acknowledge();
			UserInterface.NavigationPrompt();
			NavMenu01();
			NavMenu02();

		}

		// Nav Menu 01
		public void NavMenu01()
		{
			validChoice = false;
			while (validChoice == false)
			{
				NavSelection01(BalanceOrSoda());
			}
		}
		public void NavSelection01(int userInput)
		{
			switch (userInput)
			{
				case 1:
					UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.totals, customer.backpack.CansInPack());
					UserInterface.EnterToContinue();
					break;
				case 2:
					UserInterface.SodaCheck(sodaMachine.colas[0].name, sodaMachine.orangeSodas[0].name, sodaMachine.rootBeers[0].name);
					UserInterface.EnterToContinue();
					break;
				case 3:
					UserInterface.BuySoda();
					UserInterface.EnterToContinue();
					validChoice = true;
					break;
				default:
					UserInterface.ValidationError();
					UserInterface.EnterToContinue();
					break;
			}
		}
		public int BalanceOrSoda()
		{
			UserInterface.Navigation00();
			userInput = Convert.ToInt32(Console.ReadLine());
			return userInput;
		}
		// Nav Menu 02
		public void NavMenu02()
		{
			validChoice = false;
			while (validChoice == false)
			{
				sodaMachine.SodasCostAndAvailable();
				sodaSelection = Console.ReadLine();
				DepositCoins(); // --> TODO: Not complete
			}
		}
		public void DepositCoins()
		{
			validChoice = false;
			while (validChoice == false)
			{
				UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.totals, customer.backpack.CansInPack());
			}
		}
		public void DepositNav()
		{
			UserInterface.EnterChange();
			userInput = 0;
		}
	}
}
