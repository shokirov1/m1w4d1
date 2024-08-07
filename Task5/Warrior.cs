using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task5
{
    public class Warrior : IAttack
    {
        private const int a = 10;
        public int Attack()
        {
            Console.Write("Warrior атакует и наносит физический урон : ");
            return a;
        }
    }
}
