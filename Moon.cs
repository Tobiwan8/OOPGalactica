namespace Galactica
{
    internal sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
        public double Distance(int x1, int x2, int y1, int y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            return distance;
        }
    }
}
