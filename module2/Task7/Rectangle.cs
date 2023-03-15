namespace Module2.Task7
{
    internal class Rectangle : Figure
    {
        private Point leftUpPoint;
        private double width;
        private double height;

        public Rectangle(Point leftUpPoint, double width, double height)
        {
            LeftUpPoint = leftUpPoint;
            Width = width;
            Height = height;
        }

        internal double Width { get => width; set => width = value; }
        internal double Height { get => height; set => height = value; }
        internal Point LeftUpPoint { get => leftUpPoint; set => leftUpPoint = value; }

        public override string ToString()
        {
            return string.Format("Left up point: {0}, width: {1}, height: {2}", 
                                  LeftUpPoint.ToString(), width.ToString(), height.ToString());
        }
    }
}
