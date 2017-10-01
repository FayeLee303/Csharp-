using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    struct CustomerName {
        public string firstName;
        public string lastName;
        public  string GetName() {
            return firstName + lastName;
        }
    }
    //定义一个委托
    public delegate int MyDelegate(); 
    class Program
    {
        static void Main(string[] args)
        {
            CustomerName myname;
            myname.firstName = "Faye";
            myname.lastName = "Lee";
            Console.WriteLine(myname.GetName());

            MyDelegate myTest;
            myTest = Test;//委托其实就给一个函数赋值，赋的值也是函数；注意被当成变量赋值的函数要是static类型
            Console.ReadKey();
        }
        static int Sum(params int[] arr) {//定义了int类型的参数数组，长度不确定，调用的时候可以传入任意多的参数，自动拼入这个数组
            return arr[1];
        }
        static int MaxValue(int a) {
            return 1;
        }
        static float MaxValue(float a) {
            return 1f;
        }
        //当两个函数名一样；参数不一样；就叫做函数的重载；系统根据输入参数选择使用哪个方法
        static int Test() {
            return 1;
        }
        //函数调用本身叫做函数的递归，要注意递归的终止条件
    }
}
