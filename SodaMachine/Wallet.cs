using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
	class Wallet
	{
		// Member Variables
		public ArrayList coins;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;
		public Card card;

		// Constructor
		public Wallet()
		{
			card = new Card();
			coins = new ArrayList()
			{
				quarters,
				dimes,
				nickles,
				pennies
			};
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
			LoadCoins();
			CoinTotals();
		}
		// Member Methods
		// Load Coins
		public void LoadCoins()
		{
			Register.AddCoinToList(22, quarters);
			Register.AddCoinToList(25, dimes);
			Register.AddCoinToList(20, nickles);
			Register.AddCoinToList(23, pennies);
		}
		public int CoinTotals()
		{
			int i =
				MoneyMath.GetListValue(quarters) +
				MoneyMath.GetListValue(dimes) +
				MoneyMath.GetListValue(nickles) +
				MoneyMath.GetListValue(pennies);
			return i;
		}
		// Local Coin Adders
		public void AddCoins(int coinNumber, List<Quarter> coins)
		{
			Register.AddCoinToList(coinNumber, coins);
		}
		public void AddCoins(int coinNumber, List<Dime> coins)
		{
			Register.AddCoinToList(coinNumber, coins);
		}
		public void AddCoins(int coinNumber, List<Nickle> coins)
		{
			Register.AddCoinToList(coinNumber, coins);
		}
		public void AddCoins(int coinNumber, List<Penny> coins)
		{
			Register.AddCoinToList(coinNumber, coins);
		}

		// Local Coin Removers
		public void RemoveCoins(int coinNumber, List<Quarter> coins)
		{
			Register.RemoveCoinFromList(coinNumber, coins);
		}
		public void RemoveCoins(int coinNumber, List<Dime> coins)
		{
			Register.RemoveCoinFromList(coinNumber, coins);
		}
		public void RemoveCoins(int coinNumber, List<Nickle> coins)
		{
			Register.RemoveCoinFromList(coinNumber, coins);
		}
		public void RemoveCoins(int coinNumber, List<Penny> coins)
		{
			Register.RemoveCoinFromList(coinNumber, coins);
		}
	}
}
