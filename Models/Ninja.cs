using System;
using System.Collections.Generic;

namespace Hungry_Ninja.Models
{
    public class Ninja
    {
        private int calorieIntake;
        private int calorieLimit = 1200;
        public List<Food> FoodHistory;
        public int numCal
        {
            get{
                return calorieIntake;
            }
        }
        public int Limit
        {
            get
            {
                return calorieLimit;
            }
        }
        public bool IsFull
        {
            get 
            {
                return calorieIntake >= calorieLimit;
            }
        }
        
        public Ninja()
        {
            calorieIntake = 0; 
            FoodHistory = new List<Food>(); 
        }
    
        
        public void Eat(Food item)
         {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name} (Food).  Calories: {item.Calories}.  Spicy?: {item.IsSpicy}, Sweet?: {item.IsSweet}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ninja is full, cannot eat anymore!");
                Console.ResetColor();
            }
            
        }
    }
}