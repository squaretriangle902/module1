namespace Common
{
    static public class Common
    {
        static public bool DoubleEqual(double x, double y, double epsilon = 1e-6)
        {
            return Math.Abs(x - y) < epsilon;
        }
    }
}