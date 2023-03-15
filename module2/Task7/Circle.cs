namespace Module2.Task7
{
    internal class Circle : Figure
    {
        private Point center;
        private double radius;

        internal Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        internal double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive number");
                }
                radius = value;
            }
        }

        internal Point Center
        {
            get => center;
            set => center = value;
        }

        internal double Circumference
        {
            get => 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return string.Format("center: {0}; radius: {1}", center.ToString(), radius.ToString());
        }
    }
}
