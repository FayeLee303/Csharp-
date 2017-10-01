using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    class Enemy
    {
        private float hp;
        private float speed;

        public float HP { get; set; }
        public float Speed { get; set; }

        public void Ai() {
            Console.WriteLine("这是Ai都会执行的方法");
        }
        public virtual void Move() {
            Console.WriteLine("这是Ai都会执行的move方法");
            //可以在子类重写
            //当方法重写后，原来的方法就不存在了
        }
        public new void Speak()
        {
            //当子类里有一个命名参数都和父类里某个方法相同的方法时，就会把父类的方法隐藏
            //当隐藏后只是父类的方法看不见了，但这个方法还存在
            Console.WriteLine("这是Ai都会执行的speak方法");
        }
    }
}
