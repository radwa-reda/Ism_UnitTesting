using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 0;

            // Act
            bool actualResult = bmw.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void IsStopped_Velocity10_false()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 10;

            // Act
            bool actualResult = bmw.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }
        [Fact]
        public void IncreaseVelocity_velocity10Add40_Velocity50()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 10 };
            double AddedVelocity = 40;

            // Act
            bmw.IncreaseVelocity(AddedVelocity);

            // Equality Assert
            Assert.Equal(50, bmw.velocity);
            
        }
        [Fact]
        public void TimeToCoverDistance_distance400mod40_time10()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 40 };
            double distance = 400;

            // Act
            double time = bmw.TimeToCoverDistance(distance);

            // Equality Assert
            Assert.Equal(10, time);

        }
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            // Arrange
            BMW bmw = new BMW() { drivingMode = DrivingMode.Backward };

            // Act
            string result = bmw.GetDirection();

            // String Assert
            Assert.Equal("Backward", result);
            Assert.StartsWith("Ba", result);
            Assert.EndsWith("ard", result);

            Assert.Contains("ck", result);
            Assert.DoesNotContain("zx", result);

            Assert.Matches("B[a-z]{6}", result);
            Assert.DoesNotMatch("B[a-z]{8}", result);
        }
    }
}
