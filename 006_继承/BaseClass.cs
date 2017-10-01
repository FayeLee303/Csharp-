using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    //sealed密封类无法被继承
    //sealed class BaseClass
     class BaseClass
    {
        public virtual void Test() {

        }
        private int x;
        //类同名构造函数
        public BaseClass() {
            Console.WriteLine("base class 无参数的构造函数");
        }

        //有参数的构造方法，用来对类中的private字段做初始化
        public BaseClass(int x) {
            this.x = x;
            Console.WriteLine("x赋值完成");
        }
    }
}
