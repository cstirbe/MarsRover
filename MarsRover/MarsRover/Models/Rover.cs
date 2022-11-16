using MarsRover.Enums;

namespace MarsRover.Models
{
    public class Rover
    {
        public string Name { get; set; }

        public Coordinate Coordinate { get; set; }

        public Position Position { get; set; }

        public Plateau Plateau { get; set; }

        public Rover(string name, Coordinate coordinate, Position position, Plateau plateau)
        {
            Name = name;
            Coordinate = coordinate;
            Position = position;
            Plateau = plateau;
        }

        public override string ToString()
        {
            var result = $"{Name}: {Position.X}, {Position.Y}, {Coordinate.ToString()}";
            return result;
        }
    }
}
