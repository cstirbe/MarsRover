using System;
using MarsRover.Contracts;
using MarsRover.Enums;
using MarsRover.Models;
using MarsRover.Services;

namespace MarsRover
{
    public class Program
    {
        private const string rover1Commands = "LMLMLMLMM";
        private const string rover2Commands = "MMRMMRMRRM";

        private static IMovingService _movingService;

        public static void Main(string[] args)
        {
            _movingService = new MovingService(new MovementService());

            var plateau = new Plateau("Mars1", 4, 0, 4, 0);
            var rover1 = new Rover("Rover1", Coordinate.N, new Position(1, 2), plateau);
            var rover2 = new Rover("Rover2", Coordinate.E, new Position(2, 3), plateau);

            Console.WriteLine($"Rover 1 initial position: {rover1}");
            Console.WriteLine($"Rover 2 initial position: {rover2}");
            Console.WriteLine();

            _movingService.MoveRover(rover1, rover1Commands);

            Console.WriteLine();

            _movingService.MoveRover(rover2, rover2Commands);

            Console.ReadKey();
        }
    }
}
