using System;
using MarsRover.Contracts;
using MarsRover.Enums;
using MarsRover.Models;

namespace MarsRover.Services
{
    public class MovingService : IMovingService
    {
        private readonly IMovementService _movementService;

        public MovingService(IMovementService movementService)
        {
            _movementService = movementService;
        }

        public void MoveRover(Rover rover, string commands)
        {
            foreach (var command in commands)
            {
                if (string.Equals(command.ToString(), Movement.M.ToString(), StringComparison.InvariantCulture))
                {
                    _movementService.MoveForward(rover);
                }
                else if (string.Equals(command.ToString(), Movement.L.ToString(), StringComparison.InvariantCulture))
                {
                    _movementService.RotateLeft(rover);
                }
                else if (string.Equals(command.ToString(), Movement.R.ToString(), StringComparison.InvariantCulture))
                {
                    _movementService.RotateRight(rover);
                }

                Console.WriteLine($"{rover}");
            }
        }
    }
}
