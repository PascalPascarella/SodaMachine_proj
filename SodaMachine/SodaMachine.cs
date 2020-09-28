using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SodaMachine
{
	class SodaMachine
	{
		// Member Variables
		public ArrayList till;
		public ArrayList inventory;
		public List<Quarter> quarters;
		public List<Dime> dimes;
		public List<Nickle> nickles;
		public List<Penny> pennies;
		public List<Cola> colas;
		public List<OrangeSoda> orangeSodas;
		public List<RootBeer> rootBeers;
		// Constructor
		public SodaMachine()
		{
			till = new ArrayList()
			{
				quarters,
				dimes,
				nickles,
				pennies
			};
			inventory = new ArrayList();
			quarters = new List<Quarter>();
			dimes = new List<Dime>();
			nickles = new List<Nickle>();
			pennies = new List<Penny>();
			colas = new List<Cola>();
			orangeSodas = new List<OrangeSoda>();
			rootBeers = new List<RootBeer>();
			LoadCans();
			LoadCoins();
		}
		// Member Method
		// Load Coins Into Soda Machine
		public void LoadCoins()
		{
			Register.AddCoinToList(20, quarters);
			Register.AddCoinToList(10, dimes);
			Register.AddCoinToList(20, nickles);
			Register.AddCoinToList(50, pennies);
		}
		// Load Cans Into Soda Machine
		public void LoadCans()
		{
			CanPackager.AddCanToList(21, colas);
			CanPackager.AddCanToList(11, orangeSodas);
			CanPackager.AddCanToList(19, rootBeers);
		}
		// Available Sodas and Cost
		public void SodasCostAndAvailable()
		{
			UserInterface.SodaAvailable(
				colas.Count, orangeSodas.Count, rootBeers.Count,
				colas[0].name, colas[0].Cost,
				orangeSodas[0].name, orangeSodas[0].Cost,
				rootBeers[0].name, rootBeers[0].Cost);
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
