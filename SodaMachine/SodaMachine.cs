using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SodaMachine
{
	class SodaMachine
	{
		// Member Variables
		public List<Coin> till;
		public List<Can> inventory;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;

		// Constructor
		public SodaMachine()
		{
			till = new List<Coin>();
			inventory = new List<Can>();
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
		}
		// Member Method
		public void ListerTester()
		{

		}
	}
}
