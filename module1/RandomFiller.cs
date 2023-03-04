namespace module1
{
    public static class RandomFiller
    {
        private static Random random = new Random();

        public static void FillArrayWithRandom(int[] array, int lowerBound, int upperBound)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowerBound, upperBound);
            }
        }

        public static void FillArray2dWithRandom(int[,] array2d, int lowerBound, int upperBound)
        {
            for (int i = array2d.GetLowerBound(0); i <= array2d.GetUpperBound(0); i++)
            {
                for (int j = array2d.GetLowerBound(1); j <= array2d.GetUpperBound(1); j++)
                {
                    array2d[i, j] = random.Next(lowerBound, upperBound);
                }
            }
        }

        public static void FillArray3dWithRandom(int[,,] array3d, int lowerBound, int upperBound)
        {
            for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
            {
                for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
                {
                    for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                    {
                        array3d[i, j, k] = random.Next(lowerBound, upperBound);
                    }
                }
            }
        }
    }
}
