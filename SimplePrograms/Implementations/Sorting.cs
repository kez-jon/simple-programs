using SimplePrograms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Implementations
{
    public class Sorting : ISorting
    {
        public Sorting()
        {

        }

        public int[] GetOrderedNumbers(int[] numbers)
        {           
            Array.Sort(numbers);
            return numbers;
        }
    }
}
