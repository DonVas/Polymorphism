using System;

namespace Vehicles
{
    public abstract class Vehicle 
    {
        private int tankCapacity;
        private double fuelQuantity;

        protected Vehicle(double fuelConsumption, double fuelConsumptionPerKm, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelConsumption;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
           
        }

        public  double FuelConsumptionPerKm { get; protected set; }
        public int TankCapacity { get; private set; }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }                
            }
        }                 

        public string Drive(double distance)
        {
            double requiredFuel = this.FuelConsumptionPerKm * distance;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            else if(fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
