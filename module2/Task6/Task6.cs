namespace Module2.Task6
{
    internal static class Task6
    {
        internal static void Run()
        {
            if (ConsoleInputReader.TryReadPoint(out Point center, "Enter center: ") &&
                ConsoleInputReader.TryReadDouble(out double outerRadius, "Enter outer radius: ") &&
                ConsoleInputReader.TryReadDouble(out double innerRadius, "Enter inner radius: "))
            {
                try
                {
                    Ring round = new Ring(center, outerRadius, innerRadius);
                    Console.WriteLine("Round: {0}", round.ToString());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Incorrect radius input");
                }
            }
        }
    }
}
