using MarsRover.Contracts;
using MarsRover.Enums;
using MarsRover.Models;

namespace MarsRover.Services
{
    public class MovementService : IMovementService
    {
        public Rover MoveForward(Rover rover)
        {
            switch (rover.Coordinate)
            {
                case Coordinate.N:
                    if (rover.Position.Y < rover.Plateau.MaxY)
                    {
                        rover.Position.Y++;
                    }
                    break;

                case Coordinate.E:
                    if (rover.Position.X < rover.Plateau.MaxX)
                    {
                        rover.Position.X++;
                    }
                    break;

                case Coordinate.S:
                    if (rover.Position.Y > rover.Plateau.MinY)
                    {
                        rover.Position.Y--;
                    }
                    break;

                case Coordinate.W:
                    if (rover.Position.X > rover.Plateau.MinX)
                    {
                        rover.Position.X--;
                    }
                    break;
            }

            return rover;
        }

        public Rover RotateLeft(Rover rover)
        {
            if (rover.Coordinate == Coordinate.N)
            {
                rover.Coordinate = Coordinate.W;
            }
            else
            {
                rover.Coordinate -= 1;
            }

            return rover;
        }

        public Rover RotateRight(Rover rover)
        {
            if (rover.Coordinate == Coordinate.W)
            {
                rover.Coordinate = Coordinate.N;
            }
            else
            {
                rover.Coordinate += 1;
            }

            return rover;
        }
    }
}
