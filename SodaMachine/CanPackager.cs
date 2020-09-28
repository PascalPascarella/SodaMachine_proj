using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	static class CanPackager
	{
		// Member Variables


		// Member Methods
		// Can Builders
		public static Cola Cola()
		{
			Cola cola = new Cola();
			return cola;
		}
		public static OrangeSoda OrangeSoda()
		{
			OrangeSoda orangeSoda = new OrangeSoda();
			return orangeSoda;
		}
		public static	RootBeer RootBeer()
		{
			RootBeer rootBeer = new RootBeer();
			return rootBeer;
		}

		// Can Listers
		public static void AddCanToList(int incoming, List<Cola> colas)
		{
			for (int i = 0; i < incoming; i++)
			{
				colas.Add(Cola());
			}
		}
		public static void AddCanToList(int incoming, List<OrangeSoda> orangeSodas)
		{
			for (int i = 0; i < incoming; i++)
			{
				orangeSodas.Add(OrangeSoda());
			}
		}
		public static void AddCanToList(int incoming, List<RootBeer> rootBeers)
		{
			for (int i = 0; i < incoming; i++)
			{
				rootBeers.Add(RootBeer());
			}
		}

		// Can Removers
		public static void RemoveCanFromList(int outgoing, List<Cola> colas)
		{
			for (int i = 0; i < outgoing; i++)
			{
				colas.RemoveAt(0);
			}
		}
		public static void RemoveCanFromList(int outgoing, List<OrangeSoda> orangeSodas)
		{
			for (int i = 0; i < outgoing; i++)
			{
				orangeSodas.RemoveAt(0);
			}
		}
		public static void RemoveCanFromList(int outgoing, List<RootBeer> rootBeers)
		{
			for (int i = 0; i < outgoing; i++)
			{
				rootBeers.RemoveAt(0);
			}
		}
	}
}
