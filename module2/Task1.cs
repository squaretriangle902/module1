namespace module2
{
    internal static class Task1
    {
        internal static void Run()
        {
            if (ConsoleInputReader.TryReadDouble(out double radius, "Enter radius: ") &&
                ConsoleInputReader.TryReadPoint(out Point center, "Enter center: "))
            {
                try
                {
                    Round round = new Round(center, radius);
                    Console.WriteLine("Round: {0}", round.ToString());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Radius cannot be nonpositive");
                }
            }
        }
    }
}
