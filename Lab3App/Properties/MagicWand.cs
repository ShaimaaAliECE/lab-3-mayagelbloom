using System;
namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public override void DoAction()
        {
            Display();
            Console.WriteLine("MagicWand is Used");
        }
    }
}