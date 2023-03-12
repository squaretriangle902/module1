namespace module1
{
    public static class Task4
    {
        public static void Execute()
        {
            int triangleCount = ConsoleInputReader.ReadIntUntilCorrect("Input count of triangles: ");
            WriteTriangles(triangleCount);
        }

        private static void WriteTriangles(int triangleCount)
        {
            for (int i = 1; i <= triangleCount + 1; i++)
            {
                ConsoleWriter.WriteTriangle(triangleCount, asteriskCountIncrement: 2, i);
            }
        }
    }
}