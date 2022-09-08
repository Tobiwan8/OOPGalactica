namespace Galactica
{
    internal abstract class SpaceObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"Position: ({X},{Y})";
        }
    }
}
