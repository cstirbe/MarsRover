using MarsRover.Enums;
using MarsRover.Models;
using MarsRover.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Tests
{
    [TestClass]
    public class MovingServiceTests
    {
        private static Plateau _plateau;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _plateau = new Plateau("Mars1", 4, 0, 4, 0);
        }

        [TestMethod]
        public void MoveRover()
        {
            // Arrange
            const string commands = "LMRM";

            var movingService = new MovingService(new MovementService());
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movingService.MoveRover(rover, commands);

            // Assert
            Assert.AreEqual(Coordinate.N, rover.Coordinate);
            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(2, rover.Position.Y);
        }

        [TestMethod]
        public void MoveRover_InvalidCommands_ExecuteOnlyKnownCommands()
        {
            // Arrange
            const string commands = "LMlx23;u";

            var movingService = new MovingService(new MovementService());
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movingService.MoveRover(rover, commands);

            // Assert
            Assert.AreEqual(Coordinate.W, rover.Coordinate);
            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void MoveRover_CaseSensitiveCommands_ExecuteOnlyCapitalLetterCommands()
        {
            // Arrange
            const string commands = "lMrmRm";

            var movingService = new MovingService(new MovementService());
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movingService.MoveRover(rover, commands);

            // Assert
            Assert.AreEqual(Coordinate.E, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(2, rover.Position.Y);
        }
    }
}
