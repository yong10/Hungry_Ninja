using System;
using System.Collections.Generic;

namespace Hungry_Ninja.Models
{
    public class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();
        
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 200, false, true),
                new Food("Hamburger", 600, false, true),
                new Food("Steak", 550, false, true),
                new Food("Spicy Butter Chicken", 450, true, true),
                new Food("Fish & Chips", 800, false, false),
                new Food("Drunken Noodle", 500, true, true),
                new Food("Ice Cream", 250, false, true),
            };
          
            
        }
     
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}