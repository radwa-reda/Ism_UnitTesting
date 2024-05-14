using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class CarFactoryTests
    {
        // Reference Assert
        [Fact]
        public void NewCar_AskForAudi_Null()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Audi);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void NewCar_AskForBMW_BMWObject()
        {
            // Arrange
            BMW bmw = new BMW();

            // Act
            Car? result = CarFactory.NewCar(CarTypes.BMW);

            // Reference Assert
            Assert.NotNull(result);
            Assert.NotSame(bmw, result);
        }


        // Type Assert
        [Fact]
        public void NewCar_AskForToyota_ToyotaObject()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Toyota);

            // Type Assert
            Assert.IsType<Toyota>(result);
            Assert.IsNotType<BMW>(result);
            
            Assert.IsAssignableFrom<Car>(result);
        }
    }
}
