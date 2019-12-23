using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet Resturant = new Buffet();
            // Resturant.Serve();
            Ninja Angelo = new Ninja("Angelo");
            System.Console.WriteLine($"Ninja Name: {Angelo.NinjaName}, Ninja Calorie: {Angelo.CalorieIntake}");
            Angelo.Eat(Resturant.Serve());
            Angelo.Eat(Resturant.Serve());
            Angelo.Eat(Resturant.Serve());
            Angelo.Eat(Resturant.Serve());

            System.Console.WriteLine($"Ninja Name: {Angelo.NinjaName}, Ninja Calorie: {Angelo.CalorieIntake}");




        }
    }
    class Food
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy {get; set;} 
        public bool IsSweet {get; set;}
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food (string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet
    {

        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Twix", 1000, false, true),
                new Food("Strawberry", 20, false, true),
                new Food("Bananna", 30, false, true),
                new Food("Hot Cheetos", 2000, true, false),
                new Food("Burgers", 500, false, false),
                new Food("Ice Cream", 600, false, true),
                new Food("Hot Pot", 50, true, false)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            int idx = rand.Next(0,7);
            System.Console.WriteLine(Menu[idx].Name);
            return (Menu[idx]);

        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public int CalorieIntake
        {
            get { return calorieIntake; }
        }
        public string NinjaName;
         
        // add a constructor
        public Ninja (string ninjaName)
        {
            NinjaName = ninjaName; 
            calorieIntake = CalorieIntake;
            FoodHistory = new List<Food>();
        }
         
        // add a public "getter" property called "IsFull"
        public Boolean isFull
        {
            get 
            {
                if (this.calorieIntake > 1200){
                    return true;
                }
                return false;
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            this.calorieIntake += item.Calories;
            this.FoodHistory.Add(item);
            if (this.isFull == false)
            {
                System.Console.WriteLine($"I ate {item.Name}");
            }
            else
            {
                System.Console.WriteLine($"I'm FULL!!");
            }
    
        }
    }



}
