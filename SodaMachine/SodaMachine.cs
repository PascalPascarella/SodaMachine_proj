using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SodaMachine
{
	class SodaMachine
	{
		// Member Variables
		public ArrayList till;
		public ArrayList inventory;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;

		// Constructor
		public SodaMachine()
		{
			till = new ArrayList()
			{
				quarters,
				dimes,
				nickles,
				pennies
			};
			inventory = new ArrayList();
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
		}
		// Member Method
		public void CoinListerTester()
		{
			Register.AddCoinToList(20, quarters);
			Console.WriteLine(quarters.Count + "Quarters");
			Register.AddCoinToList(10, dimes);
			Console.WriteLine(dimes.Count + "Dimes");
			Register.AddCoinToList(20, nickles);
			Console.WriteLine(nickles.Count + "Nickles");
			Register.AddCoinToList(50, pennies);
			Console.WriteLine(pennies.Count + "Pennies");
		}
	}
}
