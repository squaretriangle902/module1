namespace module1
{
    public static class Task5
    {
        public static void Execute()
        {
            Console.WriteLine(SummOfSatisfyingNumbers(strictUpperBound: 1000, firstDivisor: 3, secondDivisor: 5));
        }

        private static int SummOfSatisfyingNumbers(int strictUpperBound, int firstDivisor, int secondDivisor)
        {
            return ArithmeticProgressionUntilBoundSumm(strictUpperBound, firstDivisor)
                + ArithmeticProgressionUntilBoundSumm(strictUpperBound, secondDivisor)
                - ArithmeticProgressionUntilBoundSumm(strictUpperBound, firstDivisor * secondDivisor);
        }

        private static int ArithmeticProgressionUntilBoundSumm(int strictUpperBound, int divisor)
        {
            return ArithmeticProgressionSumm(divisor, (strictUpperBound - 1) / divisor);
        }

        private static int ArithmeticProgressionSumm(int increment, int numberCount)
        {
            return increment * (numberCount + 1) * numberCount / 2;
        }
    }
}