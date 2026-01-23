using System;

namespace Bai3
{
    public class RadixConverter
    {
        public static string Convert(int n, int b)
        {
            if (b < 2 || b > 16)
                throw new ArgumentException("Invalid base");

            if (n == 0)
                return "0";

            string result = "";
            string digits = "0123456789ABCDEF";

            while (n > 0)
            {
                int remainder = n % b;
                result = digits[remainder] + result;
                n /= b;
            }

            return result;
        }
    }
}
