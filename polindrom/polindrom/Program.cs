using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int temp_i = 0;
            int reqem = 0;
            int ters_i = 0;

            for (int i = n; i <= m; i++)
            {
                temp_i = i;
                while (temp_i != 0)
                {
                    reqem = temp_i % 10;
                    ters_i = ters_i * 10 + reqem;
                    temp_i /= 10;
                }
                if (ters_i == i)
                {
                    Console.WriteLine(i);
                }
                ters_i = 0;
            }
            Console.ReadKey();
        }
    }
}
