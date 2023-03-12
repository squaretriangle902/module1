namespace module1
{
    public static class Task2
    {
        public static void Execute()
        {
            int height = ConsoleInputReader.ReadIntUntilCorrect("Input triangle height: ");
            ConsoleWriter.WriteTriangle(topOffset: 0, asteriskCountIncrement: 1, height);
        }
    }
}