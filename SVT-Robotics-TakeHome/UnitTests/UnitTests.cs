using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SVT_Robotics_TakeHome;
using SVT_Robotics_TakeHome.Infrastructure;
using System.Collections.Generic;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetOptimalRobot_ReturnsCorrectRobot()
        {
            // Arrange
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var robotsPath = Path.Combine(directory, "Fixtures/AvailableRobots.json");
            var loadPath = Path.Combine(directory, "Fixtures/SampleLoad.json");

            var availableRobots = JsonConvert.DeserializeObject<List<Robot>>(File.ReadAllText(robotsPath));
            var load = JsonConvert.DeserializeObject<Load>(File.ReadAllText(loadPath));

            // Act
            var robot = RobotMaths.GetOptimalRobotForLoad(availableRobots, load);

            // Assert
            Assert.AreEqual(2, robot.X);
            Assert.AreEqual(7, robot.Y);
        }
    }

    [TestClass]
    // [Ignore]
    // We should ignore if this will impact live data, for now using this API is ok
    public class IntegrationTests
    {
        [TestMethod]
        // Verifies url returns data shaped as expected
        public void GetRobots_ReturnsCorrectRobots()
        {
            // Arrange
            var repo = new SvtRoboticsRepo();

            // Act
            var robots = repo.GetAvailableRobotsAsync().Result;

            // Assert
            Assert.IsTrue(robots.Count > 0);
        }
    }
}
