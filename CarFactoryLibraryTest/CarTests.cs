using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class CarTests
    {
        [Fact]
        public void Accelerate_velocity10_Range20to55()
        {
            // Arrange
            Audi audi = new Audi() { velocity = 10 };
            BMW bMW = new BMW() { velocity = 10 };

            // Act
            audi.Accelerate();
            bMW.Accelerate();

            // Numeric Assert
            Assert.InRange(audi.velocity, 20, 55);
            Assert.InRange(bMW.velocity, 20, 55);

            Assert.NotInRange(audi.velocity, 90, 140);

            Assert.True(audi.velocity > 10);
            Assert.True(audi.velocity > 10);
        }
    }
}
