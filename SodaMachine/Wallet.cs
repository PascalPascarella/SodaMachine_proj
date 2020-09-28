using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	class Wallet
	{
		// Member Variables
		public ArrayList coins;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;
		public Card card;

		// Constructor
		public Wallet()
		{
			coins = new ArrayList()
			{
				quarters,
				dimes,
				nickles,
				pennies
			};
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
		}
		// Member Method
		public void CoinListerTester()
		{
			Register.AddCoinToList(22, quarters);
			Console.WriteLine(quarters.Count + "Quarters");
			Register.AddCoinToList(25, dimes);
			Console.WriteLine(dimes.Count + "Dimes");
			Register.AddCoinToList(20, nickles);
			Console.WriteLine(nickles.Count + "Nickles");
			Register.AddCoinToList(23, pennies);
			Console.WriteLine(pennies.Count + "Pennies");
			double totals = .01 * (
				MoneyMath.GetListValue(quarters) +
				MoneyMath.GetListValue(dimes) +
				MoneyMath.GetListValue(nickles) +
				MoneyMath.GetListValue(pennies));
			Console.WriteLine($"{ totals:c}");
		}

	}
}
