using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    class Monster:Enemy
    {
        public void Attack()
        {
            Console.WriteLine("Monster 攻击");
        }
        public override void Move()
        {
            Console.WriteLine("Monster Move");
        }
    }   
 }

