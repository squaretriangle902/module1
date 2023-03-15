namespace Module1
{
    public static class Task8
    {
        public static void Run()
        {
            int[,,] array3d = new int[2, 3, 4];
            RandomFiller.FillArray3dWithRandom(array3d, lowerBound: -10, upperBound: 10);
            ConsoleWriteArray3d(array3d);
            Array3dReplace(array3d, number: 0);
            ConsoleWriteArray3d(array3d);
        }

        private static void ConsoleWriteArray3d(int[,,] array3d)
        {
            for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
            {
                for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
                {
                    for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                    {
                        Console.WriteLine("array[{0}, {1}, {2}] = {3}", i, j, k, array3d[i, j, k]);
                    }
                }
            }
            Console.WriteLine();
        }

        private static void Array3dReplace(int[,,] array3d, int number)
        {
            for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
            {
                for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
                {
                    for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                    {
                        if (array3d[i, j, k] > 0)
                        {
                            array3d[i, j, k] = number;
                        }
                    }
                }
            }
        }
    }
}