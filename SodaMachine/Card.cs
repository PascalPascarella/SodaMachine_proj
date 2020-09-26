using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	class Card
	{
		// Member Variables
		private int availableFunds;
		public int AvailableFunds { get { return availableFunds; } }
		// Constructor
		public Card()
		{
			availableFunds = 2000;		// 2000 cents or $20.00
		}
		// Member Method

	}
}
