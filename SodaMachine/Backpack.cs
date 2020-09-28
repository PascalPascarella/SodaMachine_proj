using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	class Backpack
	{
		// Member Variables
		public ArrayList cans;
		public List<Cola> colas;
		public List<OrangeSoda> orangeSodas;
		public List<RootBeer> rootBeers;
		// Constructor
		public Backpack()
		{
			cans = new ArrayList()
			{
				colas,
				orangeSodas,
				rootBeers
			};
			colas = new List<Cola>();
			orangeSodas = new List<OrangeSoda>();
			rootBeers = new List<RootBeer>();
		}
		// Member Method
		public void CanListerTester()
		{
			CanPackager.AddCanToList(21, colas);
			Console.WriteLine(colas.Count + "Colas");
			CanPackager.AddCanToList(11, orangeSodas);
			Console.WriteLine(orangeSodas.Count + "Orange Sodas");
			CanPackager.AddCanToList(19, rootBeers);
			Console.WriteLine(rootBeers.Count + "Root Beers");
		}
	}
}
