using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahWIlliamsProject1_1_
{
    public class Shopper
    {
        // Properties
        public string Name { get; private set; }
        public double MoneyAvailable { get; private set; }

        // Data member
        private List<Car> Cars;

        // Constructor
        public Shopper(string name, double moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Shopper name cannot be empty.", nameof(name));

            if (moneyAvailable < 0)
                throw new ArgumentOutOfRangeException(nameof(moneyAvailable), "Money available cannot be negative.");

            Name = name;
            MoneyAvailable = Math.Round(moneyAvailable, 2);
            Cars = new List<Car>();
        }

        // Public methods

        /// Checks if shopper can afford car
        public bool CanPurchase(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");

            double totalCost = Math.Round(car.Price * (1 + CarLot.TAX_RATE), 2);
            return MoneyAvailable >= totalCost;
        }

        /// Purchases selected car and updates the shopper's funds
        public void PurchaseCar(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");

            double totalCost = Math.Round(car.Price * (1 + CarLot.TAX_RATE), 2);

            if (totalCost > MoneyAvailable)
                throw new InvalidOperationException($"{Name} does not have enough funds to purchase this car.");

            // Subtract cost of car from total
            MoneyAvailable = Math.Round(MoneyAvailable - totalCost, 2);

            // Add car to owned list
            Cars.Add(car);
        }


        /// Returns shoppers purchased cars
        public List<Car> GetPurchasedCars()
        {
            return new List<Car>(Cars);
        }

        public override string ToString()
        {
            return $"{Name} - ${MoneyAvailable:F2} remaining - {Cars.Count} car(s) owned";
        }
    }
}
