namespace module1
{
    public static class Task5
    {
        public static void Execute()
        {
            Console.WriteLine(SummOfSatisfyingNumbers(strictUpperBound: 10, firstDivisor: 3, secondDivisor: 5));
        }

        private static int SummOfSatisfyingNumbers(int strictUpperBound, int firstDivisor, int secondDivisor)
        {
            return SummOfDivisble(strictUpperBound, firstDivisor) 
                + SummOfDivisble(strictUpperBound, secondDivisor)
                - SummOfDivisble(strictUpperBound, firstDivisor * secondDivisor);
        }

        private static int SummOfDivisble(int strictUpperBound, int divisor)
        {
            int endNumber = NearestDivisibleToNumber(strictUpperBound, divisor);
            int progressionNumberCount = NumberCount(divisor, endNumber, divisor);
            ArithmeticProgressionSumm(divisor, endNumber, progressionNumberCount);
            return endNumber;
        }

        private static int ArithmeticProgressionSumm(int startNumber, int endNumber, int numberCount)
        {
            return (startNumber + endNumber) * numberCount / 2;
        }

        private static int NearestDivisibleToNumber(int number, int divisor)
        {
            return number - (number % divisor);
        }

        private static int NumberCount(int firstNumber, int lastNumber, int increment)
        {
            return (firstNumber - lastNumber) / increment + 1;
        }
    }
}