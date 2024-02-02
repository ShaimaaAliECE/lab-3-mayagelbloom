using System;
namespace Lab3App
{
	internal class Coin : Treasure
	{
        public int Value { get; set; }
        public Coin(string description, int score, int value) : base(score)
		{
			Description = description;
			Value = value;
		}
		public void UpdateTotalValue()
		{
			Board.UpdateTotalValue(Value);
		}
		public void Display()
		{
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}

