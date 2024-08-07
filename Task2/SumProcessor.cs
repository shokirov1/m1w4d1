using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task2
{
    public class SumProcessor : IDataProcessor
    {
        public int ProcessData(int[] arr)
        {
            return arr.Sum();
        }
    }
}
