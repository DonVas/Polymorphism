namespace WildFarm.Models.Animals.Birds
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;
    public class Hen : Bird
    {
        private const double GainFat = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }
        
        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() { nameof(Meat),nameof(Fruit),nameof(Seeds),nameof(Vegetable) }, GainFat);
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
