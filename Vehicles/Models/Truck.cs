using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.6;
        private const double refuelingCoefficient = 0.05;

        public Truck(double fuelConsumption, double fuelConsumptionPerKm, int tankCapacity) 
            : base(fuelConsumption, fuelConsumptionPerKm + additionalConsumptionPerKm, tankCapacity)
        {
        }

        public override void Refuel(double fuel)
        {

            base.Refuel(fuel);
            this.FuelQuantity -=  fuel * refuelingCoefficient;
        }
    }
}
