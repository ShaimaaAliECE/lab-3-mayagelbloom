using System;
namespace Lab3App
{
	public class CollectionBoard
	{
		public int TotalScore { get; set; }
		public int TotalValue { get; set; }
		public CollectionBoard()
		{
			TotalScore = 0;
			TotalValue = 0;
		}
		//Updating the total score and value
		public void UpdateTotalScore(int score)
		{
			TotalScore += score;
		}
		public void UpdateTotalValue(int value)
		{
			TotalValue += value;
		}
	}
}

