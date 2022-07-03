using SimplePrograms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Implementations
{
    public class TimesTable : ITimesTable
    {
        public TimesTable()
        {
        }

        public string[] GetTable(int tableNo)
        {
            int length = 10;
            string[] output = new string[length];

            for (int i = 1; i <= length; i++)
            {
                int result = tableNo * i;
                output[i-1] = $"{tableNo} x {i} = {result}";
            }

            return output;            
        }

        public string[] GetTable(int tableNo, int limit)
        {
            int length = limit;
            string[] output = new string[length];

            for (int i = 1; i <= length; i++)
            {
                int result = tableNo * i;
                output[i - 1] = $"{tableNo} x {i} = {result}";
            }

            return output;
        }
    }
}
