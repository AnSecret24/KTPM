using System;

namespace Bai1
{
    public class PowerCalculator
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;

            if (n > 0)
                return x * Power(x, n - 1);

            // n < 0
            return Power(x, n + 1) / x;
        }
    }
}
