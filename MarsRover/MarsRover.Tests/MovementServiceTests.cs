using MarsRover.Enums;
using MarsRover.Models;
using MarsRover.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Tests
{
    [TestClass]
    public class MovementServiceTests
    {
        private static Plateau _plateau;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _plateau = new Plateau("Mars1", 4, 0, 4, 0);
        }

        [TestMethod]
        public void MoveForward_ToNorth_YPositionIncreased()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.N, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(2, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForwardToNorth_AlreadyAtMaxNorthPosition_DoNotMove()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 4), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.N, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(4, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForward_ToEast_XPositionIncreased()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.E, new Position(1, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.E, rover.Coordinate);
            Assert.AreEqual(2, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForwardToEast_AlreadyAtMaxEastPosition_DoNotMove()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.E, new Position(4, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.E, rover.Coordinate);
            Assert.AreEqual(4, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForward_ToSouth_YPositionDecreased()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.S, new Position(1, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.S, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(0, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForwardToSourth_AlreadyAtMaxSouthPosition_DoNotMove()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.S, new Position(1, 0), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.S, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(0, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForward_ToWest_XPositionDecreased()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.W, new Position(1, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.W, rover.Coordinate);
            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void MoveForwardToWest_AlreadyAtMaxWestPosition_DoNotMove()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.W, new Position(0, 1), _plateau);

            // Act
            movementService.MoveForward(rover);

            // Assert
            Assert.AreEqual(Coordinate.W, rover.Coordinate);
            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateLeft_FromNorth()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movementService.RotateLeft(rover);

            // Assert
            Assert.AreEqual(Coordinate.W, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateLeft_FromEast()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.E, new Position(1, 1), _plateau);

            // Act
            movementService.RotateLeft(rover);

            // Assert
            Assert.AreEqual(Coordinate.N, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateLeft_FromSouth()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.S, new Position(1, 1), _plateau);

            // Act
            movementService.RotateLeft(rover);

            // Assert
            Assert.AreEqual(Coordinate.E, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateLeft_FromWest()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.W, new Position(1, 1), _plateau);

            // Act
            movementService.RotateLeft(rover);

            // Assert
            Assert.AreEqual(Coordinate.S, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateRight_FromNorth()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.N, new Position(1, 1), _plateau);

            // Act
            movementService.RotateRight(rover);

            // Assert
            Assert.AreEqual(Coordinate.E, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateRight_FromEast()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.E, new Position(1, 1), _plateau);

            // Act
            movementService.RotateRight(rover);

            // Assert
            Assert.AreEqual(Coordinate.S, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateRight_FromSouth()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.S, new Position(1, 1), _plateau);

            // Act
            movementService.RotateRight(rover);

            // Assert
            Assert.AreEqual(Coordinate.W, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RotateRight_FromWest()
        {
            // Arrange
            var movementService = new MovementService();
            var rover = new Rover("Rover1", Coordinate.W, new Position(1, 1), _plateau);

            // Act
            movementService.RotateRight(rover);

            // Assert
            Assert.AreEqual(Coordinate.N, rover.Coordinate);
            Assert.AreEqual(1, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }
    }
}
