using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task2
{
    public class AverageProcessor : IDataProcessor
    {
        public int ProcessData(int[] arr)
        {
            return (int)arr.Average();
        }
    }
}
