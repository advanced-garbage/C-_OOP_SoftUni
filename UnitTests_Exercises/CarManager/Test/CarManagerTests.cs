namespace CarManager.Tests
{
    using NUnit.Framework;
    using CarManager;
    using System.Linq;
    using System.Collections.Generic;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private string make = "Honda";
        private string model = "Civic";
        private double fuelConsumption = 5.5;
        private double fuelAmount = 0;
        private double fuelCapacity = 200;
        public Car car;

        [SetUp]
        public void InitializeCarObj()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
        }

        [Test]
        public void CONSTRUCTOR_ShouldBeInitialized()
        {
            Assert.That(car, Is.Not.Null);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PROPERTY_MAKE_ShouldThrowExceptionWhenNull(string exception)
        {
            var ex = Assert.Throws<ArgumentException>(()
                => new Car(exception, model, fuelConsumption, fuelCapacity));
            Assert.AreEqual(ex.Message, "Make cannot be null or empty!");
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PROPERTY_MODEL_ShouldThrowExceptionWhenNull(string exception)
        {
            var ex = Assert.Throws<ArgumentException>(()
                => new Car(make, exception, fuelConsumption, fuelCapacity));
            Assert.AreEqual(ex.Message, "Model cannot be null or empty!");
        }

        [Test]
        [TestCase(-0.50)]
        [TestCase(-20)]
        [TestCase(-1000)]
        public void PROPERTY_FUELCONSUMPTION_ShouldThrowExceptionWhenValueIsNegative(double value)
        {
            var ex = Assert.Throws<ArgumentException>(()
                => new Car(make, model, value, fuelCapacity));
            Assert.AreEqual(ex.Message, "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        [TestCase(-0.50)]
        [TestCase(-20)]
        [TestCase(-1000)]
        public void PROPERTY_FUELCAPACITY_ShouldThrowExceptionWhenValueIsNegative(double value)
        {
            var ex = Assert.Throws<ArgumentException>(()
                => new Car(make, model, fuelConsumption, value));
            Assert.AreEqual(ex.Message, "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        [TestCase(20)]
        [TestCase(40)]
        [TestCase(100)]
        public void REFUEL_ShouldWorkWhenPassedWithPositiveValues_BelowCapacity(double value)
        {
            car.Refuel(value);
            Assert.AreEqual(car.FuelAmount, value);
        }

        [Test]
        [TestCase(201)]
        [TestCase(300)]
        public void REFUEL_FuelAmountShouldEqualCapacityWhenAmountIsGreaterThan(double value)
        {
            car.Refuel(value);
            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-0.50)]
        [TestCase(-20)]
        [TestCase(-1000)]
        public void REFUEL_ThrowExceptionWhenPassedArgsIsZeroOrNegative(double value)
        {
            var ex = Assert.Throws<ArgumentException>(() => car.Refuel(value));
            Assert.AreEqual(ex.Message, "Fuel amount cannot be zero or negative!");
        }

        [Test]
        [TestCase(100)]
        [TestCase(90)]
        public void DRIVE_MethodShouldLowerFuelAmount(double value)
        {
            car.Refuel(50);
            car.Drive(value);
            double evaluation = (value / 100) * car.FuelConsumption;
            Assert.IsTrue(car.FuelAmount == 50 - evaluation);
        }
        [Test]
        [TestCase(10000)]
        [TestCase(5000)]
        public void DRIVE_ThrowExceptionWhenValueIsGreaterThanFuelAmount(double value)
        {
            car.Refuel(50);

            var ex = Assert.Throws<InvalidOperationException>(() => car.Drive(value));
            Assert.AreEqual(ex.Message, "You don't have enough fuel to drive!");
        }
    }
}