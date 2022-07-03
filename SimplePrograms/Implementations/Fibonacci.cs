using SimplePrograms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Implementations
{
    public class Fibonacci : IFibonacci
    {
        public int[] GenerateSeries(int length)
        {
            int a = -1, b = 1, c;
            int[] output = new int[length];

            for (int i = 0; i < length; i++)
            {
                c = a + b;
                output[i] = c;
                a = b;
                b = c;
            }

            return output;
        }

        public int GenerateSumOfSeries(int length)
        {
            int a = -1, b = 1, c;
            int output = 0;

            for (int i = 0; i < length; i++)
            {
                c = a + b;
                output += c;
                a = b;
                b = c;
            }

            return output;
        }
    }
}
