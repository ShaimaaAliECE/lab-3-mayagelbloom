using System;
namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(string description, int score) : base(score)
        {
            Description = description;
        }
        public void Display()
        {
            Console.WriteLine($"Diamond{Description} is displayed");

        }
    }
}
