using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequential_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int temp_i = 0;
            List<int> myList = new List<int>();
            int k = 0;

            for (int i = n; i <= m; i++)
            {
                temp_i = i;
                while (temp_i != 0)
                {
                    myList.Add(temp_i % 10);
                    temp_i /= 10;
                }

                int[] digits = myList.ToArray();
                int length = digits.Length;

                for (int j = 1; j < digits.Length; j++)
                {
                    if (digits[j] - digits[j - 1] == -1)
                    {
                        k++;
                    }
                }

                if(k == digits.Length - 1)
                {
                    Console.WriteLine(i);
                }

                k = 0;
                myList.Clear();
            }
            Console.ReadKey();
        }
    }
}
