using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeTrackerConfigFirst;

namespace TestProject1
{
    [TestClass]
    public class CodeTrackerConfigFirstTests
    {
        [TestMethod]
        public void CalculateDuration_EndTimeIs24HoursAfterStartTime_ReturnsCorrectDurationInMinutes()
        {
            // Arrange
            DateTime startTime = new DateTime(2023, 5, 20, 12, 12, 12);
            DateTime endTime = new DateTime(2023, 5, 21, 12, 12, 12);

            // Act
            double duration = GameEngine.CalculateDuration(startTime, endTime);

            // Assert
            Assert.AreEqual(1440, duration);
        }
    }
}