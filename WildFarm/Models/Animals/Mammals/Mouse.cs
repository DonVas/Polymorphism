namespace WildFarm.Models.Animals.Mammals
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Mouse : Mammal
    {
        private const double GainFat = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight,livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() {nameof(Vegetable),nameof(Fruit)}, GainFat);
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
