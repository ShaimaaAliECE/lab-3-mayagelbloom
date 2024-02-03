using System;
namespace Lab3App
{
    public class MagicWand : Tool
    {
        public override void DoAction()
        {
            Display();
            Console.WriteLine("MagicWand is Used");
        }
        public MagicWand(string name)
        {
            description = name;
        }
        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.description + " is displayed");
        }
    }
}