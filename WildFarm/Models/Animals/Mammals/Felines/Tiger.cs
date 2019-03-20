namespace WildFarm.Models.Animals.Mammals.Felines
{
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Tiger : Feline
    {
        private const double GainFat = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }
        
        public override void Eat(Food food)
        {
            base.FoodCheck(food, new List<string>() { nameof(Meat) }, GainFat);
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
