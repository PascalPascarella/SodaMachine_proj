using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	static class Register
	{
		// Member Variables

		// Member Methods
		// Coin Builders
		public static Quarter Quarter()
		{
			Quarter quarter = new Quarter();
			return quarter;
		}
		public static Dime Dime()
		{
			Dime dime = new Dime();
			return dime;
		}
		public static Nickle Nickle()
		{
			Nickle nickle = new Nickle();
			return nickle;
		}
		public static Penny Penny()
		{
			Penny penny = new Penny();
			return penny;
		}
		// List Builders
		public static void AddCoinToList(int incoming, List<Quarter> quarters)
		{
			for (int i = 0; i < incoming; i++)
			{
				quarters.Add(Quarter());
			}
		}
		public static void AddCoinToList(int incoming, List<Dime> dimes)
		{
			for (int i = 0; i < incoming; i++)
			{
				dimes.Add(Dime());
			}
		}
		public static void AddCoinToList(int incoming, List<Nickle> nickles)
		{
			for (int i = 0; i < incoming; i++)
			{
				nickles.Add(Nickle());
			}
		}
		public static void AddCoinToList(int incoming, List<Penny> pennies)
		{
			for (int i = 0; i < incoming; i++)
			{
				pennies.Add(Penny());
			}
		}
		// List Removers
		public static void RemoveCoinFromList(int outgoing,List<Quarter> quarters)
		{
			for (int i = 0; i < outgoing; i++)
			{
				quarters.RemoveAt(0);
			}
		}
		public static void RemoveCoinFromList(int outgoing, List<Dime> dimes)
		{
			for (int i = 0; i < outgoing; i++)
			{
				dimes.RemoveAt(0);
			}
		}
		public static void RemoveCoinFromList(int outgoing, List<Nickle> nickles)
		{
			for (int i = 0; i < outgoing; i++)
			{
				nickles.RemoveAt(0);
			}
		}
		public static void RemoveCoinFromList(int outgoing, List<Penny> pennies)
		{
			for (int i = 0; i < outgoing; i++)
			{
				pennies.RemoveAt(0);
			}
		}
	}
}
