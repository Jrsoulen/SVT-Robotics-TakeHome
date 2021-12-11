using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVT_Robotics_TakeHome;
using SVT_Robotics_TakeHome.Infrastructure;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetRobotForLoad_ReturnsCorrectRobot()
        {
            // Arrange
            var repo = new SvtRoboticsRepo();
            var load = new Load() { 
                LoadId = 1, 
                XCoordinate = 2, 
                YCoordinate = 3 
            };

            // Act
            var robot = repo.GetRobotForLoadAsync(load).Result;

            // Assert
            Assert.AreEqual(1, robot.RobotId);
        }
    }
}
