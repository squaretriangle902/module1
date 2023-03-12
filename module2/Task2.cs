using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace module2
{
    static internal class Task2
    {
        static internal void Run()
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
