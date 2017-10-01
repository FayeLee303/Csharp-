using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_面向对象编程_类
{
    //要使用一个类，先要引入它所在的命名空间，因为customer类和program是在一个命名空间下的，所以不需要引入了
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer_1 = new Customer("f",1);
            //customer_1.SetHp(10);
            //customer_1.SetName("F");
            customer_1.Hp = 5;//设置属性

            customer_1.Show();
            //属性的使用和字段一样；对属性设置值调用的是set方法
            customer_1.MyIntProperty = 600;
            //对属性取值;取值调用的是get方法，所以temp是100
            int temp = customer_1.MyIntProperty;
            Console.WriteLine(temp);
            //var是匿名类型；当被赋值时确定他的类型
            var a = 199;

            Console.ReadKey();
        }
    }
}
