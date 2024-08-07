using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task5
{
    public class Mage : IAttack
    {
        private const int b = 15;
        public int Attack()
        {
            Console.Write("Mage атакует и наносит магический урон : ");
            return b;
        }
    }
}
