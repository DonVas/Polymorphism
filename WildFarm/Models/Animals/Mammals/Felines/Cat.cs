namespace WildFarm.Models.Animals.Mammals.Felines
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Cat : Feline
    {
        private const double GainFat = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() { nameof(Meat), nameof(Vegetable) }, GainFat);
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
