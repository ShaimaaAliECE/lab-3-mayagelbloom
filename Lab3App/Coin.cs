using System;
using System.Collections.Generic;
namespace Lab3App
{
	public class Coin : Treasure
	{

		private int Value;

		public Coin(string name, int score, int value)
		{
			this.description = name;
			this.Score = score;
			Value = value;
		}
		public int UpdateTotalValue(int newValue)
		{
			Board.totalValue += newValue;
			return Board.totalValue;
		}
        public override void Display()
        {
			Console.WriteLine("Coin " + this.description + " is displayed");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			Console.WriteLine("Total Value is updated to: " + UpdateTotalValue(Value));
        }
    }
}
