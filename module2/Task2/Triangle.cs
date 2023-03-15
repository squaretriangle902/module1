using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Module2;

namespace Module2.Task2
{
    internal class Triangle
    {
        private Point a;
        private Point b;
        private Point c;
        private string collinearPointsErrorMessage = "Points of triangle cannot be collinear";

        internal Triangle(Point a, Point b, Point c)
        {
            SetPoints(a, b, c);
        }

        internal void SetPoints(Point a, Point b, Point c)
        {
            if (Point.Collinear(a, b, c))
            {
                throw new ArgumentException(collinearPointsErrorMessage);
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        internal Point A
        {
            get { return a; }
            set
            {
                if (Point.Collinear(value, b, c))
                {
                    throw new ArgumentException(collinearPointsErrorMessage);
                }
            }
        }

        internal Point B
        {
            get { return b; }
            set
            {
                if (Point.Collinear(a, value, c))
                {
                    throw new ArgumentException(collinearPointsErrorMessage);
                }
            }
        }

        internal Point C
        {
            get { return c; }
            set
            {
                if (Point.Collinear(a, b, value))
                {
                    throw new ArgumentException(collinearPointsErrorMessage);
                }
            }
        }

        internal double Area
        {
            get
            {
                double sideA = Point.Distance(b, c);
                double sideB = Point.Distance(a, c);
                double sideC = Point.Distance(a, b);
                double p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
        }
    }
}
