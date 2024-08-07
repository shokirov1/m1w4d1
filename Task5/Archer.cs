using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task5
{
    public class Archer : IAttack
    {
        private const int c = 20;
        public int Attack()
        {
            Console.Write("Archer атакует и наносит в дальнем бою : ");
            return c;
        }
    }
}
