namespace Galactica
{
    internal class Planet : SpaceObject
    {
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant };
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public Position? PlanetPosition { get; set; }

        public List<Moon> Moons = new();
        public double Distance(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
