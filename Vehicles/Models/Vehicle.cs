namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelConsumption, double fuelConsumptionPerKm)
        {
            this.FuelQuantity = fuelConsumption;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        private double FuelConsumptionPerKm { get; set; }

        private double FuelQuantity { get; set; }

        protected abstract double AdditionalConsumption { get; }

        public string Drive(double distance)
        {
            double requiredFuel = (FuelConsumptionPerKm + AdditionalConsumption) * distance;

            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }


    }
}
