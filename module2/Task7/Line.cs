namespace Module2.Task7
{
    internal class Line : Figure
    {
        private Point a;
        private Point b;

        public Line(Point a, Point b)
        {
            A = a;
            B = b;
        }

        internal Point A { get { return a; }  set { a = value; } }
        internal Point B { get { return b; }  set { b = value; } }

        public override string ToString()
        {
            return string.Format("A: {0}, B: {1}", A.ToString(), B.ToString());
        }

    }
}
