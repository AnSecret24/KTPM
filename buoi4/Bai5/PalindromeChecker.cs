using System;

namespace Bai5
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            if (input == null)
                throw new ArgumentException("Input is null");

            // Chuỗi rỗng xem là palindrome
            if (input.Length == 0)
                return true;

            // Chuẩn hóa: bỏ khoảng trắng + về lowercase
            string cleaned = input.Replace(" ", "").ToLower();

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
