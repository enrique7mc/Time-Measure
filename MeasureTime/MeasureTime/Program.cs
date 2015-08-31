using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            using(var timeBlock = new TimeMeasurementBlock(stopwatch))
            {
                for(int i = 0; i < 300000; i++)
                {
                    IsPrime(i);
                }

                Console.WriteLine(timeBlock.Stopwatch.ElapsedMilliseconds);                
            }
        }

        private static bool IsPrimeSlow(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            int i = 5;
            int w = 2;
            while (i * i <= n)
            {
                if (n % 2 == 0)
                {
                    return false;
                }

                i += w;
                w = 6 - w;
            }

            return true;
        }
    }
}
