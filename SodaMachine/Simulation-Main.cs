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

		}

	}
}
