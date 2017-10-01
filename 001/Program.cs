using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    enum direction {
        North,
        South,
        West,
        East
    }
    struct path
    {
        float distance;
        direction dir;
    }
    //当两边操作数类型不一样，返回的结果和类型大的操作数保持一致
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}+{1}\n={2}", 11, 22, 33);

            string i = Console.ReadLine();
            Console.WriteLine(i);
            string str = "123";
            int num = Convert.ToInt32(str);//把一个数字字符串转成32位整数
            Console.WriteLine(num);
            int a = 5;
            goto skip;//goto控制程序跳转到某个标签的位置
            a++;
            skip: Console.WriteLine(a);//goto把标签中间的语句跳过了
            string resStr = (a == 6) ? "no" : "yes";//三元运算符；某些时候可以代替ifelse语句
            switch (a) {
                case 5:
                    break;
                case 6:
                    break;
                default://以上条件都不满足时执行此处的语句
                    break;
            }
            //do while会先执行一次循环体再进行条件判断，执行次数>=1
            //while先判断条件，满足条件才执行循环；循环次数最小为0
            //break跳出最近的循环体，执行下一行代码
            //continue跳出当前循环体的当前循环，执行下一次循环
            //return终止方法，剩余代码不执行了
            //for循环因为定义了i,可以根据索引取数组里的值
            //foreach(int a in scores)依次访问数组，但是没有索引
            //string可以看作char类型的数组，string.ToLower()把字符串转为小写字母。ToUpper转为大写字母并返回
            //string.Trim()去掉字符串前面和后面的空格，TrimStart去掉前面的空格，TrimEnd
            //string.Split()根据某个字符切分字符串，返回一个拆分后的字符串数组
            Console.ReadKey();
        }
    }
}
