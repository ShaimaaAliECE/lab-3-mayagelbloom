using System;
namespace Lab3App
{
	internal class Axe : Tool
	{
        public override void DoAction()
        {
            Display();
            Console.WriteLine("Axe is Used");
        }
    }
}