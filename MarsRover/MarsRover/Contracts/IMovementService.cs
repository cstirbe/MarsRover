using MarsRover.Models;

namespace MarsRover.Contracts
{
    public interface IMovementService
    {
        Rover MoveForward(Rover rover);

        Rover RotateLeft(Rover rover);

        Rover RotateRight(Rover rover);
    }
}
