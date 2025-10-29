using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahWIlliamsProject1_1_
{
    public class CarLot
    {
        // Data Member
        private List<Car> _inventory;

        // Public constant
        public const double TAX_RATE = 0.078;

        // Constructor
        public CarLot()
        {
            _inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        // Helper method
        private void StockLotWithDefaultInventory()
        {
            _inventory.Add(new Car("Ford", "Focus ST", 28.3, 26298.98));
            _inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19.0, 65401.23));
            _inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2, 26780.00));
            _inventory.Add(new Car("Lexus", "ES 350", 24.1, 42101.10));
        }

        // Oubkic method

        // Finding cars
        public List<Car> FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
                return null;

            var results = _inventory
                .Where(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return results.Any() ? results : null;
        }

        // Find car by model
        public Car FindCarByMakeModel(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
                return null;

            return _inventory.FirstOrDefault(car =>
                car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                car.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        }

        // Purchase car
        public Car PurchaseCar(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
                return null;

            var carToPurchase = FindCarByMakeModel(make, model);

            if (carToPurchase != null)
            {
                _inventory.Remove(carToPurchase);
                return carToPurchase;
            }

            return null;
        }

        // Adding cars here
        public void AddCar(string make, string model, double mpg, double price)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be empty.", nameof(make));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be empty.", nameof(model));
            if (mpg <= 0)
                throw new ArgumentOutOfRangeException(nameof(mpg), "MPG must be greater than zero.");
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than zero.");

            _inventory.Add(new Car(make, model, mpg, price));
        }

        // Total Price for car
        public double GetTotalCostOfPurchase(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");

            return Math.Round(car.Price * (1 + TAX_RATE), 2);
        }

        // Least expensive car
        public Car FindLeastExpensiveCar()
        {
            return _inventory.Any() ? _inventory.OrderBy(c => c.Price).First() : null;
        }

        // Most expensive car
        public Car FindMostExpensiveCar()
        {
            return _inventory.Any() ? _inventory.OrderByDescending(c => c.Price).First() : null;
        }

        // Find best MPG
        public Car FindBestMPGCar()
        {
            return _inventory.Any() ? _inventory.OrderByDescending(c => c.Mpg).First() : null;
        }

        // Find worse MPG
        public Car FindWorstMPGCar()
        {
            return _inventory.Any() ? _inventory.OrderBy(c => c.Mpg).First() : null;
        }

        // Inventory count
        public int Count => _inventory.Count;

        // Inventory expression
        public List<Car> Inventory => new List<Car>(_inventory);
    }
}

