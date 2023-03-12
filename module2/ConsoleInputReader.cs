using System.Globalization;

namespace module2
{
    static internal class ConsoleInputReader
    {
        static public bool TryReadPoint(out Point result, string consoleMessage = "")
        {
            result = new Point();
            Console.WriteLine(consoleMessage);
            if (TryReadDouble(out double x, "x: ", "incorrect x:") &&
                TryReadDouble(out double y, "y: ", "incorrect y:"))
            {
                result = new Point(x, y);
                return true;
            }
            return false;
        }

        static public bool TryReadDouble(out double result, string consoleMessage = "", string errorMessage = "")
        {
            Console.Write(consoleMessage);
            if (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(errorMessage);
                return false;
            }
            return true;
        }
    }
}
