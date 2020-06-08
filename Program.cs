using System;
using Hungry_Ninja.Models;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet food = new Buffet();
            Ninja A = new Ninja();
            while(!A.IsFull)
            {
                A.Eat(food.Serve());
            }
            A.Eat(food.Serve());
        }
    }
}
