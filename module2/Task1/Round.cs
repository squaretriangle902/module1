namespace Module2.Task1
{
    internal class Round : Task7.Circle
    {
        internal Round(Point center, double radius) : base(center, radius)
        {
            Center = center;
            Radius = radius;
        }

        internal double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
    }
}
