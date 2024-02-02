using System;
namespace Lab3App
{
	public class Treasure
	{
		public int Score { get; set; }
		public Treasure(int score)
		{
			Score = score;
		}
		public virtual void UpdateTotalScore(CollectionBoard)
		{
			CollectionBoard.TotalScore += Score;
		}
		public void AddMe(List<Collectable> collectables)
		{
			collectables.Add(this as Collecable);
		}
	}
}

