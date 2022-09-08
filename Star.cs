namespace Galactica
{
    enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
    internal class Star : SpaceObject
    {
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> Planets = new();
        private Position StarPosition = new() { X = 0, Y = 0};
    }
}
