namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal 
    {
        
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; private set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void Eat(Food food);
        
        public abstract string ProduceSound();

        protected void FoodCheck(Food food, List<string> etableFood, double gainFat)
        {
            string typeFood = food.GetType().Name;
            if (!etableFood.Contains(typeFood))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
            }

            this.Weight += food.Quantity * gainFat;
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}