using System;
using System.Linq;

namespace ConsoleApp4
{    class Program
    {
        private static bool Increment(int baseNumber, int[] digits)
        {
            int i = digits.Length - 1;

            while (i >= 0 && digits[i] == baseNumber - 1)
            {
                digits[i] = 0;
                i -= 1;
            }

            if (i < 0)
            {
                return false;
            }

            digits[i] += 1;

            return true;
        }

        static void Main(string[] args)
        {
            int[] m = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int n = 6;
            int size = 12 * n + 1;
            var digits = new int[n];
            int[] sum = new int[size];
            long result = 0;

            do
            {
                int sumLeft = 0;

                for (int i = 0; i < n; i++)
                {
                    sumLeft += digits[i];
                }

                sum[sumLeft]++;
            }
            while (Increment(m.Length, digits));


            for (int l = 0; l < sum.Count(); l++)
            {
                result += sum[l] * sum[l];
            }

            result *= m.Length;

            Console.WriteLine((result).ToString());
            Console.Read();
        }
    }
}
