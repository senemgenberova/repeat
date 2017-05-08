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
            //int n = Convert.ToInt32(Console.ReadLine());
            //List<int> myList = new List<int>();

            //while(n != 0)
            //{
            //    myList.Add(n % 10);
            //    n = n / 10;
            //}

            //int[] digits = myList.ToArray();
            //int length = digits.Length;

            //if (length % 2 == 1)
            //{
            //    if (digits[0] + digits[length-1] == 2 * digits[length / 2])
            //    {
            //        Console.WriteLine("duzdu");
            //    }
            //}

            //else
            //{
            //    for (int i = 0; i < digits.Length; i++)
            //    {
            //        if (digits[i] + digits[length-1] == digits[i + 1] + digits[length - 2])
            //        {
            //            Console.WriteLine("duzdu");
            //        }
            //    }
            //}

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int temp_i = 0;
            List<int> myList = new List<int>();

            for (int i = n; i <= m; i++)
            {
                while (temp_i != 0)
                {
                    myList.Add(temp_i % 10);
                    temp_i /= 10;
                }

                int[] digits = myList.ToArray();
                int length = digits.Length;

                if (length % 2 == 1)
                {
                    if (digits[0] + digits[length - 1] == 2 * digits[length / 2])
                    {
                        Console.WriteLine(i);
                    }
                }

                else
                {
                    for (int j = 0; j < digits.Length; j++)
                    {
                        if (digits[j] + digits[length - 1] == digits[j + 1] + digits[length - 2])
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
