using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _009_正则表达式
{
    class Program
    {
        private static void Main(string[] args)
        {
            //string s = " I am a blue cat.";
            ////搜索字符串所有符合正则表达式的情况，然后替换成后面的字符串
            ////"^"表示定位字符串的开头,"$"表示定位字符串的结尾
            //string str =Regex.Replace(s,"^","开始：");
            //string str_1 = Regex.Replace(s,"$","结束");
            //Console.WriteLine(str);
            //string s = Console.ReadLine();
            //bool isMatch = true;//默认标志位，表示s是一个合法密码
            //for (int i = 0;i<s.Length;i++) {
            //    if (s[i]<'0'||s[i]>'9')
            //    {
            //        isMatch = false;
            //        break;
            //    }
            //    if (isMatch)
            //    {
            //        Console.WriteLine("是一个合法密码");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不55是一个合法密码");
            //    }
            //}
            //正则表达式式子,以数字\d开头以数字结尾，@表示中间遇到\不当成转义字符
            //式子中\d*表示数字有零个或多个
            //string pattern = @"^\d*$";
            //string pattern_1 = @"\d*";//表示任意只要有数字出现的都符合
            //string pattern_2 = @"^\w*$";
            
            ////Regex.IsMatch是只要s中有一个满足pattern的子字符串就返回true
            //bool isMatch = Regex.IsMatch(s,pattern);
            //Console.WriteLine(isMatch);

            //string pattern_3 = @"[^hhh]";//表示除了hhh以外的所有字符
            //string str = "asdgragfsghhhhs";
            //string _str = Regex.Replace(str, pattern_3, "*");//表示把除了hhh以外所有的字符替换为*
            //Console.WriteLine(str);
            //Console.WriteLine(_str);

            //string qq = "54465346840";
            //string pattern_4 = @"^\d{5,12}$";//表示5-12位的数字
            //Console.WriteLine(Regex.IsMatch(qq,pattern_4));

            //string test = "asda23()></?啊手动阀";
            //string pattern_5 = @"\d|[a-z]";//表示数字或者a到z的之间的字母
            //MatchCollection col =  Regex.Matches(test,pattern_5);//Matches表示多次匹配
            //foreach (Match match in col)
            //{
            //    Console.WriteLine(match);//相当于输入match.tostring方法提取的字符串
            //}

            //string s = "zhangfuyuan;liyifei,dashabi.shidan";
            //string pattern_6 = @"[;,.]";
            //string pattern_7 = @"[;]|[,]|[.]";//或的关系，任意一个都可以
            //string[] resArray = Regex.Split(s,pattern_6);//按照规则划分
            //foreach (var so in resArray)
            //{
            //    Console.WriteLine(so);
            //}

            //()括号表示当成一个整体
            string test_2 = "ab12ab34ab4242";
            string strGroup2 = @"(ab\w{2}){2}";// == ab\w{2}ab\w{2}
            Console.WriteLine(Regex.Replace(test_2,strGroup2, "55555"));

            //这是一个Ip地址的规则，0-255.0-255.0-255.0-255
            string pattern_8_Ip = @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}2[0-4]\d|25[0-5]|[01]?\d\d?)$";
            Console.ReadKey();

        }  
    }
}
