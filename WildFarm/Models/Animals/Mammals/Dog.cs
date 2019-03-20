namespace WildFarm.Models.Animals.Mammals
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Dog : Mammal
    {
        private const double GainFat = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }
     
        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() { nameof(Meat) }, GainFat);
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
