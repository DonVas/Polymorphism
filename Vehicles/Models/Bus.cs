using System;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double workingAirConditionerAdditionalConsumption = 1.4;

        public Bus(double fuelConsumption, double fuelConsumptionPerKm, int tankCapacity) 
            : base(fuelConsumption, fuelConsumptionPerKm + workingAirConditionerAdditionalConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumptionPerKm -= workingAirConditionerAdditionalConsumption;
            return base.Drive(distance);
        }
    }
}
