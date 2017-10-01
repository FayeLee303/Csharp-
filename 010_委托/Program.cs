using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_委托
{
    class Program
    {
        private delegate string MyString();

        static void Main(string[] args)
        {
            int x = 1;

            MyString test = new MyString(x.ToString);//其实是给方法加了一层引用
            MyString test_1 = x.ToString;
            string s = test();

            PrintString _p = Method1;
            PrintStr(_p);
        }

        private delegate void PrintString();
        //委托类型可以作为一个方法的参数，传入一个方法
        static void PrintStr(PrintString print)
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("method1");
        }
    }
}
