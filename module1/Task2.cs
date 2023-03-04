namespace module1
{
    public static class Task2
    {
        public static void Execute()
        {
            int height = ConsoleInputReader.ReadIntUntilCorrect("Input triangle height: ");
            WriteTriangle(height);
        }

        public static void WriteTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}