using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution1 = level1(1000, 3, 5);
            Console.Out.WriteLine("The answer is: " + solution1);
            Console.ReadKey();
        }

        static int level1(int below, int m1, int m2)
        {
            int result = 0;
            for (int i = 1; i < below; i++)
            {
                if (i % m1 == 0 || i % m2 == 0)
                    result = result + i;
            }

            return result;
        }
    }

}
