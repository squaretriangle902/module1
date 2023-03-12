namespace module2
{
    internal struct Point
	{
		internal double x;
        internal double y;

        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        internal static bool Collinear(Point a, Point b, Point c)
        {
            return Common.DoubleEqual((b.x - a.x) * (c.y - a.y), (b.y - a.y) * (c.x - a.x));
            // (x2-x1)(y3-y1) = (y2-y1)(x3-x1)
        }

        internal static double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }
}
