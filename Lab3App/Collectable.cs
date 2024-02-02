using System;
using System.Collections.Generic;
namespace Lab3App
{
	public class Collectable : Displayable
	{
		//Adding fields
		private string Description { get; set; }

        //Adding field of type CollectionBoard
        private CollectionBoard Board;

        public CollectionBoard Board
        {
            get { return board; }
            set { board = value; }
        }

		public Collectable(string description)
		{
			Description = description;
		}
		}
		//Adding the current Collectable to a list
		public void AddMe(List<Collectable> collectables)
		{
		Console.WriteLine($"{Description} Collected, Congrats!!!!");
		board.UpdateTotalScore(20);
        Console.WriteLine($"Total Score is updated to: {board.TotalScore}");
		collectables.Add(this);
		}
	void Displayable.Display()
	{
        Console.WriteLine($"Displaying Collectable:{Description}");
    }
}

