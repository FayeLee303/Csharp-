using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_错误处理_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    可能会发生异常的代码，
            //    如果这里的代码没有发生异常，则catch和finally都不会执行
            //    而是直接执行正常的代码
            //    int[] myArray = { 1, 2, 3, 4 };
            //    int myEle = myArray[4];
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    当捕捉到什么异常就执行什么代码
            //    如果catch没有参数则捕捉到任何异常信息都执行catch语句块
            //    Console.WriteLine("发生了异常");
            //    Console.WriteLine("数组越界了");
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine("发生了异常");
            //    Console.WriteLine("变量为空");
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}
            //Console.WriteLine("test");


            int num1 = 0,num2 = 0;
           
            while (true) {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;//在try块中有一行代码发生了异常，try块剩下的代码就不会再执行了
                }
                catch
                {
                    Console.WriteLine("发生了异常");
                    Console.WriteLine("输入的不是整数");
                }
               // break;//在这里放一个break，不管是否发生异常都会执行，因为try块对异常已经进行了处理
            }
            while (true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;//在try块中有一行代码发生了异常，try块剩下的代码就不会再执行了
                }
                catch
                {
                    Console.WriteLine("发生了异常");
                    Console.WriteLine("输入的不是整数");
                }
                // break;//在这里放一个break，不管是否发生异常都会执行，因为try块对异常已经进行了处理
            }
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
