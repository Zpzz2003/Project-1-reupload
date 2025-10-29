using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahWIlliamsProject1_1_
{
    public class Car
    {
        // Properties
        public string Make { get; private set; }
        public string Model { get; private set; }
        public double Mpg { get; private set; }
        public double Price { get; private set; }

        // Constructor 
        public Car(string make, string model, double mpg, double price)
        {
            // Pre-cons
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be empty.", nameof(make));

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be empty.", nameof(model));

            if (mpg <= 0)
                throw new ArgumentOutOfRangeException(nameof(mpg), "MPG must be greater than zero.");

            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than zero.");

            // Assigns values
            Make = make;
            Model = model;
            Mpg = Math.Round(mpg, 2);
            Price = Math.Round(price, 2);
        }

        // Debugging
        public override string ToString()
        {
            return $"{Make} {Model} - {Mpg:F2} MPG - ${Price:F2}";
        }
    }
}

