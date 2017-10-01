using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _004_面向对象编程_类;

namespace _005_堆和栈
{
    //栈空间小，读取速度快；只能从顶端插入push删除pop；先入后出
    //堆空间大，读取速度慢；能以任意顺序存储删除
    //普通的字段都是值类型，单独定义时放在栈中，只需要一段内存
    //string，数组，自定义的类，内置类都是引用类型，需要两段内存
    //一段存实际数据，放在堆中，一段存引用，指向数据在堆中的位置，引用放在栈里
    class Program
    {
        static void Main(string[] args)
        {
            //Test4();
            Test5();
            Console.ReadKey();
        }
        static void Test1 (){
            //值类型放在栈中，先入后出，d在栈顶
            int a = 1;
            int b = 1;
            int temp = 2;
            char c = 'c';
            bool d = true;
        }
        static void Test2() {
            //引用类型分两段储存，引用地址放在栈里，实际数据放在堆中
            //方法调用完释放内存时，先按照栈先入后出的规则清空栈
            //然后堆中的数据没有了引用，垃圾回收器会检测到它没有引用了就把它清空
            int a = 1;
            int b = 1;
            string c = "ccc";
        }
        static void Test3() {
            string a = "aaa";
            string b = "bbb";
            a = b; //当使用引用类型赋值的时候，实际是交换引用
            Console.WriteLine(a+":"+b);
        }
        static void Test4() {
            //自定义类是引用类型；user_1和user_2的内存地址放在栈中，实际数据放在堆中
            Customer user_1 = new Customer("A",100);
            Customer user_2 = new Customer("B", 200);
            //给引用类型赋值其实是把引用的内存地址改变了，user_1和user_2的地址都指向"B", 200，原来的"A",100在堆中被释放掉了
            user_1 = user_2;
            //这里给数据赋值，把堆里的数据改了，但是因为user_1和user_2指向的是一个数据，所以user_2的值也变了
            user_1.Hp = 300;
            Console.WriteLine(user_2.Hp);
        }
        static void Test5() {
            //userArray是一个放在栈里的内存地址引用，存着数组中的两个元素，这两个元素放在堆中
            //userArray[0]userArray[1]也是引用，他们存的实际数据放在堆中，他们只是放在堆中的一个栈中内存地址
            //数组中如果存的是值类型，则就是直接数据放在堆中
            //数组中如果存的是引用类型，则数组中存的还是个地址，地址还会再指向数据，只是说这个地址和数据都放在堆中
            //这些地址都是栈储存的，是把一个栈放进堆里了
            Customer[] userArray = new Customer[] { new Customer("A", 100), new Customer("B", 200) };
            Customer user_1 = userArray[0];
            userArray[0].Hp = 300;
            user_1.Hp = 400;
            Console.WriteLine(userArray[0].Hp);
        }
    }
}
