namespace module2
{
    internal class Round
    {
        private Point center;
        double radius;

        internal Round(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        internal double Radius
        {
            get { return radius; }
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
            get { return center; } 
            set { center = value; }
        }

        internal double Circumference
        {
            get { return 2 * Math.PI * radius; }          
        }

        internal double Area
        {
            get { return Math.PI * radius * radius; }
        }

        public override string ToString()
        {
            return String.Format("center: {0}; raduis: {1}", center.ToString(), radius.ToString());
        }

    }
}
