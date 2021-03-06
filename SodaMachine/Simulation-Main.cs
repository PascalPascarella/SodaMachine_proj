﻿using System;
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
		public int sodaSelection;
		public int depositedAmount;
		// Constructor
		public Simulation_Main()
		{
			sodaMachine = new SodaMachine();
			customer = new Customer();
			depositedAmount = 0;
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
				case 1:		// User Balances
					UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.CoinTotals(), customer.backpack.CansInPack());
					UserInterface.EnterToContinue();
					break;
				case 2:		// Soda Choices
					UserInterface.SodaCheck(sodaMachine.colas[0].name, sodaMachine.orangeSodas[0].name, sodaMachine.rootBeers[0].name);
					UserInterface.EnterToContinue();
					break;
				case 3:		// Soda Details and exit loop
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
			userInput = UserInputInt();
			return userInput;
		}
		// Nav Menu 02
		public void NavMenu02()
		{
			validChoice = false;
			while (validChoice == false)
			{
				sodaMachine.SodasCostAndAvailable();
				sodaSelection = UserInputInt();
				DepositCoins();
				
			}
		}
		public void DepositCoins()
		{
			validChoice = false;
			while (validChoice == false)
			{
				UserInterface.EnterToContinue();
				UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.CoinTotals(), customer.backpack.CansInPack());
				DepositNav();
				SodaToUser(); // --> TODO
				UserInterface.EnterToContinue();
			}
		}
		public void DepositNav()
		{
			UserInterface.EnterChange();
			userInput = UserInputInt();
			CoinSelectValidate();

		}
		public void CoinSelectValidate()
		{
			if (customer.wallet.CoinTotals() > 0)
			{
				switch (userInput)
				{
					case 1:   // User chooses quarter
						UserInterface.EnterChangeAmount();
						int iQ = UserInputInt();
						depositedAmount += iQ * 25;
						UserInterface.EnterChangeConfirm(depositedAmount);
						customer.wallet.RemoveCoins(iQ, customer.wallet.quarters);
						sodaMachine.AddCoins(iQ, sodaMachine.quarters);
						break;
					case 2:   // User chooses dime
						UserInterface.EnterChangeAmount();
						int iD = UserInputInt();
						depositedAmount += iD * 10;
						UserInterface.EnterChangeConfirm(depositedAmount);
						customer.wallet.RemoveCoins(iD, customer.wallet.dimes);
						sodaMachine.AddCoins(iD, sodaMachine.dimes);
						break;
					case 3:   // User chooses nickel
						UserInterface.EnterChangeAmount();
						int iN = UserInputInt();
						depositedAmount += iN * 5;
						UserInterface.EnterChangeConfirm(depositedAmount);
						customer.wallet.RemoveCoins(iN, customer.wallet.nickles);
						sodaMachine.AddCoins(iN, sodaMachine.nickles);
						break;
					case 4:   // User chooses penny
						UserInterface.EnterChangeAmount();
						int iP = UserInputInt();
						depositedAmount += iP;
						UserInterface.EnterChangeConfirm(depositedAmount);
						customer.wallet.RemoveCoins(iP, customer.wallet.pennies);
						sodaMachine.AddCoins(iP, sodaMachine.pennies);
						break;
					case 5:   // User completes deposit
						UserInterface.EnterChangeConfirm(depositedAmount);
						UserInterface.EnterToContinue();
						validChoice = true;
						break;
					default:
						UserInterface.ValidationError();
						UserInterface.EnterToContinue();
						break;
				}
			}
			else
			{
				UserInterface.ValidationErrorNoMoney();
				UserInterface.EnterToContinue();
			}
		}
		public void SodaToUser()
		{
			if(depositedAmount > sodaMachine.colas[0].Cost || depositedAmount > sodaMachine.orangeSodas[0].Cost || depositedAmount > sodaMachine.rootBeers[0].Cost)
			switch (sodaSelection)
			{
				case 1:   // Spit out coke
						if (sodaMachine.colas.Count > 0)
							UserInterface.DispenseDrink(sodaMachine.colas[0]);
							sodaMachine.UnLoadCans(1, sodaMachine.colas);
							customer.backpack.LoadCans(1, customer.backpack.colas);
							customer.wallet.total += depositedAmount - sodaMachine.colas[0].Cost;
						depositedAmount = 0;
						UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.total, customer.backpack.CansInPack());
						break;
				case 2:   // Spit out crush
						if (sodaMachine.orangeSodas.Count > 0)
							UserInterface.DispenseDrink(sodaMachine.orangeSodas[0]);
							sodaMachine.UnLoadCans(1, sodaMachine.orangeSodas);
							customer.backpack.LoadCans(1, customer.backpack.orangeSodas);
							customer.wallet.total += depositedAmount - sodaMachine.orangeSodas[0].Cost;
						depositedAmount = 0;
						UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.total, customer.backpack.CansInPack());
						break;
				case 3:   // Spit out IBC
						if (sodaMachine.rootBeers.Count > 0)
							UserInterface.DispenseDrink(sodaMachine.rootBeers[0]);
							sodaMachine.UnLoadCans(1, sodaMachine.rootBeers);
							customer.backpack.LoadCans(1, customer.backpack.rootBeers);
							customer.wallet.total += depositedAmount - sodaMachine.rootBeers[0].Cost;
						depositedAmount = 0;
						UserInterface.BalanceCheck(customer.wallet.card.AvailableFunds, customer.wallet.total, customer.backpack.CansInPack());
						break;
				default:
					UserInterface.ValidationErrorNoMoney();
					UserInterface.EnterToContinue();
					break;
			}
			else
			{
				UserInterface.ValidationErrorNoMoney();
				UserInterface.EnterToContinue();
			}
		}

		// User Input to Int
		public int UserInputInt()
		{
			int i;
			bool isINT = false;
			while (isINT == false)
			{
				i = Convert.ToInt32(Console.ReadLine());
				isINT = true;
				return i;
			}
			UserInterface.ValidationError();
			int no = 0;
			return no;
		}
	}
}
