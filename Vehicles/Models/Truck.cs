namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.6;
        private const double refuelingCoefficient = 0.95;

        public Truck(double fuelConsumption, double fuelConsumptionPerKm) 
            : base(fuelConsumption, fuelConsumptionPerKm)
        {
        }
        protected override double AdditionalConsumption => additionalConsumptionPerKm;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * refuelingCoefficient);
        }
    }
}
