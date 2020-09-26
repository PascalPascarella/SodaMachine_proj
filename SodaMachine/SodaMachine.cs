using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SodaMachine
{
	class SodaMachine
	{
		// Member Variables
		public List<Coin> register;
		public List<Can> inventory;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;

		// Constructor
		public SodaMachine()
		{
			register = new List<Coin>();
			inventory = new List<Can>();
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
		}
		// Member Method
		public void ListerTester()
		{
			Register.AddCoinToList(4, quarters);
			Register.AddCoinToList(4, nickles);
			Console.WriteLine("Quarter count at: " + quarters.Count);
			Register.RemoveCoin(2, quarters);
			Console.WriteLine("Quarter count at: " + quarters.Count);
			Register.RemoveCoin(1, quarters);
			Console.WriteLine("Quarter count at: " + quarters.Count);
			Register.RemoveCoin(1, quarters);
			Console.WriteLine("Quarter count at: " + quarters.Count);
		}
	}
}
