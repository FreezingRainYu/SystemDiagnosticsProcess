using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static double Qcalculator(int k)
        {
            double q = 0;
            for(int i = 0; i <= k; i++)
            {
                q += 1 / (double)Factorial(i) + i * i;
            }
            return q;
        }

        static void Main(string[] args)
        {
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("q={0}", Qcalculator(k));
        }
    }
}
