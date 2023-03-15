using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Module2;

namespace Module2.Task2
{
    internal static class Task2
    {
        internal static void Run()
        {
            ConsoleInputReader.TryReadPoint(out Point a, "Input A:");
            ConsoleInputReader.TryReadPoint(out Point b, "Input B:");
            ConsoleInputReader.TryReadPoint(out Point c, "Input C:");
            try
            {
                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine("Area: {0}", triangle.Area);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: points are collinear");
            }
        }
    }
}
