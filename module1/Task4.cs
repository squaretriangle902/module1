namespace module1
{
    public static class Task4
    {
        public static void Execute()
        {
            int trianglesNumber = ConsoleInputReader.ReadIntUntilCorrect("Input count of triangles: ");
            WriteTriangles(trianglesNumber);

        }

        private static void WriteTriangles(int trianglesNumber)
        {
            for (int i = 1; i <= trianglesNumber + 1; i++)
            {
                ConsoleWriter.WriteTriangle(trianglesNumber, asteriskCountIncrement: 2, i);
            }
        }
    }
}