using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //当使用泛型类构造时要指定数据类型
            var test_1 = new ClassA<int,int>(1,2);
            var test_2 = new ClassA<string,int>("a", "b");
            GetSum<int,string,int>(1, "2",3);


            MyList<int> mylist = new MyList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist[0] = 100;//通过索引器设置值
            mylist.Insert(2, 400);
            mylist.RemoveAt(3);
            for (int i = 0;i<mylist.Count;i++) {
                //这里是还没有索引器
               // Console.WriteLine(mylist.GetItem(i));
               //通过索引器取值
                Console.WriteLine(mylist[i]);
            }


            //利用构造函数构造
            StringBuilder sb = new StringBuilder("xxx");
            //创建初始空的stringBuilder对象，占有20个字符大小
            //stringBuilder是可变的，当他申请了一块内存空间之后就不用再申请新的空间了
            //如果需要用一个东西存频繁变动的字符串最好用stringBuilder
            //当存的字符串长度超过设置的容量时，stringBuilder会自动进行2倍容量扩容
            StringBuilder sb_1 = new StringBuilder(20);
            StringBuilder sb_2 = new StringBuilder("xxx",20);
            sb_2.Append("aaa");

            Console.WriteLine(sb_2);
            Console.ReadKey();
        }

        //泛型方法是指这个方法的数据类型是不确定的，当使用这个方法时才才确定
        //可以处理多种数据，省得重写同名不同参的函数
        public static string GetSum<T,T1,T2>(T a,T1 b,T2 c){
            return a +""+ b+""+c;
        }
    }
}
