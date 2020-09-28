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
		// Load Cans Into Backpack
		public void LoadCans(int inputColaNumber, List<Cola> cans)
		{
			CanPackager.AddCanToList(inputColaNumber, colas);
		}
		public void LoadCans(int inputOrangeSodaNumber, List<OrangeSoda> cans)
		{
			CanPackager.AddCanToList(inputOrangeSodaNumber, colas);
		}
		public void LoadCans(int inputRootBeerNumber, List<RootBeer> cans)
		{
			CanPackager.AddCanToList(inputRootBeerNumber, colas);
		}

		// Local Can Counter
		public int CansInPack()
		{
			int canCount = colas.Count + orangeSodas.Count + rootBeers.Count;
			return canCount;
		}

		
	}
}
