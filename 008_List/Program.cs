using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建List要指明类型
            List<int> _scoreList_1 = new List<int>();
            var _scoreList_2 = new List<int>();
            var _scoreList_3 = new List<int>() { 1,2,3};
            _scoreList_1.Add(1);
            //可以通过索引访问，索引即添加时的顺序，从0开始
            //向List里添加东西的时候，当长度大于2的倍数时，他的容量就会自动扩大一倍
            //注意区别List的容量capacity和在列表中存储的元素个数count
            //空列表的容量capacity是0
            Console.WriteLine(_scoreList_1[0]);
            //用for循环是按索引取值
            for (int i = 0; i < _scoreList_3.Count; i++) {
                Console.WriteLine(_scoreList_3[i]);
            }
            //foreach直接顺序取值
            foreach (int i in _scoreList_3) {
                Console.WriteLine(i);
            }
            //插入，在某索引位插入一个数据，原来的数据后移一位，但这个索引位必须是已存在的
            _scoreList_3.Insert(1,8);
            //RemoveAt移除指定索引位置上的元素，移除后所有的数据前移一位
            _scoreList_3.RemoveAt(1);
            //indexOf输入数据返回该数据在List中的索引，如果数据不存在于List，则返回-1
            //indexOf是从0号索引从前向后搜索的，如果List里有两个相同的数据，indexOf返回在前面的那个索引
            //LastIndexOf是从某后往前搜索，如果List里有两个相同的数据，indexOf返回在后面的那个索引
            //但是如果有三个相同的数据就不行了
            Console.WriteLine(_scoreList_3.IndexOf(8));
            Console.WriteLine(_scoreList_3.LastIndexOf(8));
            //sort是按照从大到小的顺序对列表里的数据进行排序
            _scoreList_3.Sort();
            Console.ReadKey();

           
        }
    }
}
