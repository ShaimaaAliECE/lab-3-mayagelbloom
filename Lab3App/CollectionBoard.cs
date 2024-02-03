using System;
namespace Lab3App
{
	public class CollectionBoard
	{
		private static int TotalValue;
		private static int TotalScore;

		public int totalValue
		{
			get
			{
				return TotalValue;
			}
			set
			{
				TotalValue = value;
			}
		}
		public int totalScore
		{
			get
			{
				return TotalScore;
			}
			set
			{
				TotalScore = value;
			}
		}

	}
}