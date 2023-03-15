namespace Module2.Task6
{
    internal class Ring : Module2.Task7.Figure
    {
        private double outerRadius;
        private double innerRadius;
        private Point center;

        internal Ring(Point center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        internal double OuterRadius
        {
            get { return outerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Outer radius cannot be non positive");
                }
                outerRadius = value;
            }
        }

        internal double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Outer radius cannot be non positive");
                }
                if (value >= outerRadius)
                {
                    throw new ArgumentException("Inner radius must be lesser than outer radius");
                }
                outerRadius = value;
            }
        }

        internal Point Center
        {
            get { return center; }
            set { center = value; }
        }

        internal double Area { get { return Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius); } }

        internal double BoundaryLength { get { return 2 * Math.PI * (outerRadius + innerRadius); } }

        public override string ToString()
        {
            return string.Format("center: {0}; outerRaduis: {1}; innerRaduis: {2}",
                                  center.ToString(), OuterRadius.ToString(), InnerRadius.ToString());
        }
    }
}
