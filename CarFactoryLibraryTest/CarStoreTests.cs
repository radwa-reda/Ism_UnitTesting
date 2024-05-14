using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_AddAudi_ListContainObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Audi audi = new Audi() { drivingMode = DrivingMode.Forward };
            BMW bmw = new BMW() { velocity = 20 };
            BMW bmw2 = new BMW() { velocity = 30 };

            // Act
            carStore.AddCar(audi);
            carStore.AddCar(bmw);
            carStore.AddCar(bmw2);
            // Collection Asserts
            Assert.NotEmpty(carStore.cars);

            Assert.Contains<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Forward);
           
            // Check if the list contains only instances of Car or its derived classes
            Assert.All(carStore.cars, c => Assert.IsAssignableFrom<Car>(c));

            // Check if the list contains exactly two instances of BMW
            Assert.Equal(2, carStore.cars.Count(c => c is BMW));

            Assert.DoesNotContain<Car>(carStore.cars, c => c.velocity == 10);
        }
    }
}
