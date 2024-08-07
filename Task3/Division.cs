using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task3
{
    public class Division : IMathOperation
    {
        public double Calculate(double x, double y)
        {
            return x / y;
        }
    }
}
