namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double additionalConsumptionPerKm = 0.9;

        public Car(double fuelConsumption, double fuelConsumptionPerKm, int tankCapacity) 
            : base(fuelConsumption, fuelConsumptionPerKm + additionalConsumptionPerKm, tankCapacity)
        {
        }
     
    }
}
