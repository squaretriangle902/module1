namespace Module1
{
    public static class Task3
    {
        public static void Run()
        {
            int height = ConsoleInputReader.ReadIntUntilCorrect("Input triangle height: ");
            WriteTriangle(height);
        }

        private static void WriteTriangle(int height)
        {
            ConsoleWriter.WriteTriangle(height - 1, asteriskCountIncrement: 2, height);
        }
    }
}