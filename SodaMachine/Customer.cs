using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace SodaMachine
{
	class Customer
	{
		// Member Variables
		public Wallet wallet;
		public Backpack backpack;
		// Constructor
		public Customer()
		{
			wallet = new Wallet();
			backpack = new Backpack();
		}
		// Member Method

	}
}
