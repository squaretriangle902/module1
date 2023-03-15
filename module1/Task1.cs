namespace Module1
{
    public static class Task1
    {
        public static void Run()
        {
            int a = ReadPositiveIntUntilCorrect("Enter a: ");
            int b = ReadPositiveIntUntilCorrect("Enter b: ");
            Console.WriteLine("Area of rectangle: {0}", (a * b).ToString());
        }

        private static int ReadPositiveIntUntilCorrect(string consoleMessage)
        {
            while (true)
            {
                int result = 0;
                bool intReadFailed = !ConsoleInputReader.TryReadInt(out result, consoleMessage);
                if (intReadFailed)
                {
                    continue;
                }
                else if (result <= 0)
                {
                    Console.WriteLine("Incorrect input: nonpositive integer");
                    continue;
                }
                return result;
            }
        }
    }
}
