using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	static class MoneyMath
	{
		// Member Variables
		public static int listValueTotal;

		// Member Methods
		public static int GetListValue(List<Quarter> coins)
		{
			listValueTotal = 0;
			foreach (Coin coin in coins)
			{
				listValueTotal += coin.Value;
			}
			double LVT = listValueTotal * .01;
			Console.WriteLine($"The sum total value of this list is currently {LVT:c}");
			return listValueTotal;
		}
		public static int GetListValue(List<Dime> coins)
		{
			listValueTotal = 0;
			foreach (Coin coin in coins)
			{
				listValueTotal += coin.Value;
			}
			double LVT = listValueTotal * .01;
			Console.WriteLine($"The sum total value of this list is currently {LVT:c}");
			return listValueTotal;
		}
		public static int GetListValue(List<Nickle> coins)
		{
			listValueTotal = 0;
			foreach (Coin coin in coins)
			{
				listValueTotal += coin.Value;
			}
			double LVT = listValueTotal * .01;
			Console.WriteLine($"The sum total value of this list is currently {LVT:c}");
			return listValueTotal;
		}
		public static int GetListValue(List<Penny> coins)
		{
			listValueTotal = 0;
			foreach (Coin coin in coins)
			{
				listValueTotal += coin.Value;
			}
			double LVT = listValueTotal * .01;
			Console.WriteLine($"The sum total value of this list is currently {LVT:c}");
			return listValueTotal;
		}
	}
}
