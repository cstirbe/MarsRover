using MarsRover.Models;

namespace MarsRover.Contracts
{
    public interface IMovingService
    {
        void MoveRover(Rover rover, string commands);
    }
}
