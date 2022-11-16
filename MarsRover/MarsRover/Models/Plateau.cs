namespace MarsRover.Models
{
    public class Plateau
    {
        public string Name { get; set; }

        public int MaxX { get; set; }

        public int MinX { get; set; }

        public int MaxY { get; set; }

        public int MinY { get; set; }

        public Plateau(string name, int maxX, int minX, int maxY, int minY)
        {
            Name = name;
            MaxX = maxX;
            MinX = minX;
            MaxY = maxY;
            MinY = minY;
        }
    }
}
