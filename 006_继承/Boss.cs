using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    class Boss:Enemy
    {
        public void Attack() {
            Console.WriteLine("Boss 攻击");
        }

        public override void Move()
        {
            Console.WriteLine("Boss Move");
        }
        public void Speak()
        {
            Console.WriteLine("Boss speak");
        }
    }
}
