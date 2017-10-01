using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss _boss = new Boss();
            _boss.Ai();
            _boss.Attack();
            _boss.Speak();
            //隐藏方法：如果使用子类声明的对象，就会调用子类的方法
            //如果使用父类声明；就会调用父类的同名方法
            Monster _monster = new Monster();
            _monster.Move();
            _monster.Attack();

            //父类声明的对象可以用子类来构造
            //子类声明的对象不能用父类来构造
            Enemy enemy;
            enemy = new Boss();//但此时还不能调用子类的方法
            Boss boss = (Boss)enemy; //使用强制转换成子类才能调用子类的方法
            //一个对象是什么类型的，主要是看他是通过什么构造的
            //如果是父类构造一个对象，强制转换成子类是不通过的
            //如果父类写了虚函数，子类重写，当用父类去构造时调用原来的默认虚函数
            //用子类构造时调用重写后的函数

            Bird_Crow _crow = new Bird_Crow();
            _crow.Fly();
            Bird _bird = new Bird_Crow();
            //可以使用抽象类声明，但要用子类去构造
            //抽象类是不完整的，没有构造方法
            _bird.Fly();

            DerivedClass _derived = new DerivedClass();
            DerivedClass _derived_2 = new DerivedClass(1,2);
            //静态变量只能通过类名来访问，不能通过对象来访问
            //静态变量是始终存在的
            DerivedClass.testStaticParma = 100;
            DerivedClass.TestStaticFuction();
            Console.ReadKey();
        }
    }
}
