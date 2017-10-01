using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    class DerivedClass : BaseClass
    {
        //可以把重写的方法声明为密封方法，表示该方法只能被这么重写一次
        //比如另一个类继承BaseClass，就不能再重写Test方法了
        public sealed override void Test()
        {
            base.Test();
        }


        private int y;
        public static int testStaticParma;

        public static void TestStaticFuction() {
            Console.WriteLine("这个是静态方法");
        }

        //调用父类中无参数的构造函数
        //调用顺序是先调用父类的构造函数再调用子类的构造函数
        //:base()也可以不写；默认会调用父类的【无参数】构造函数
        public DerivedClass() : base() {
            Console.WriteLine("Derived class 无参数的构造函数");
        }

        //同名不同参的函数是重写，系统根据传入的参数判断调用哪个
        public DerivedClass(int x,int y) :base(x){
            //有参数的构造函数
            this.y = y;
            Console.WriteLine("把x赋值给父类的构造函数");
            Console.WriteLine("y赋值完成");
        }
    }
}
