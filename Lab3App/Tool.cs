using System;

namespace Lab3App
{
    public abstract class Tool : Displayable
    {
        public abstract void DoAction();
        
        void Displayable.Display()
        {
            Console.WriteLine($"Displaying {GetType().Name}");
        }
    }
}