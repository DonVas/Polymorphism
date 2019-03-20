namespace WildFarm.Models.Animals.Birds
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Owl : Bird
    {
        private const double GainFat = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() { nameof(Meat) }, GainFat);
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
