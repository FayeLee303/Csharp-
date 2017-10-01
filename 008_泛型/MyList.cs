using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_泛型
{
    class MyList<T> where T:IComparable //继承可比较接口
    {
        private T[] array;
        private int count = 0;//数据的个数
        //构造方法定义时不用加<T>
        public MyList(int size){
            if (size>0) {
                array = new T[size];
            }
        }
        public MyList() {
            //在默认的构造函数里创建空的列表
            array = new T[0];
        }
        //获得容量
        public int Capacity {
            get{ return array.Length; }
        }
        //获得个数
        public int Count
        {
            get { return count; }
        }
        //添加数据
        public void Add(T item) {
            //先判断元素个数跟列表容量是不是相等，如果一样大，说明容量不够，需要创建新的数组
            if (Count == Capacity)
            {   //扩容
                if (Capacity == 0)
                {   //如果容量为零就初始化一个长度为4的数组
                    array = new T[4];
                }
                else {
                    //如果不为零，就初始化一个容量是原数组容量2倍的新数组，并把原来的数组里的数据复制过来
                    
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array,newArray,Count);
                    array = newArray;    //这句话是把新数组的引用赋值给array，原array引用的内容没有引用了就会被回收掉
                }
            }
            else {
                //添加数据
                array[Count] = item;
                count++;//元素个数自增
            }
        }

        //根据索引获取数据
        public T GetItem(int index) {
            if (index >= 0 && index <= count - 1)
            {
                return array[index];
            }
            else {
                //Console.WriteLine("索引超出了范围");
                throw new Exception("索引超出范围");//抛出异常
            }

        }

        //索引器
        public T this[int index] {
            get//当我们通过索引器取值的时候会调用get块
            {
                return GetItem(index);
            }
            set//当我们通过索引器设置值的时候会调用set块
            {
                if (index >= 0 && index <= count - 1)
                {
                    //当索引符合规则时才赋值
                    array[index] = value;
                }
                else
                {
                    //Console.WriteLine("索引超出了范围");
                    throw new Exception("索引超出范围");//抛出异常
                }
            }
        }

        //插入
        public void Insert(int index,T item) {
            if (index >= 0 && index <= count - 1)
            {
                if (Count == Capacity)
                {
                    //需要扩容
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, Count);
                    array = newArray;
                }
                //从count-1从后往前开始遍历直到index位要插入位
                for (int i = count-1;i>=index;i--) {
                    //把i位置上的数据后移一位
                    array[i + 1] = array[i];
                }
                array[index] = item;//把要插入的数值赋值给index位
                count++;//元素个数自增

            }
            else
            {
                //Console.WriteLine("索引超出了范围");
                throw new Exception("索引超出范围");//抛出异常
            }
        }
        //移除元素
        public void RemoveAt(int index) {
            if (index >= 0 && index <= count - 1)
            {
                //从index+1位向后遍历
                for (int i = index+1;i<count;i++) {
                    //把index+1位后面的元素都前移一位
                    array[i - 1] = array[i];
                }
                count--;
            }
            else
            {
                //Console.WriteLine("索引超出了范围");
                throw new Exception("索引超出范围");//抛出异常
            }
        }

        //根据数据返回它在列表中正向顺序第一次出现的索引
        public int IndexOf(T item) {
            for (int i = 0;i<count;i++)
            {
                if (array[i].Equals(item)) {
                    return i;
                }
            }
            return -1; //列表里没有这个元素
        }

        //根据数据返回它在列表中正向顺序最后一次出现的索引
        public int LastIndexOf(T item) {
            for (int i = count-1; i >=0; i--)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1; //列表里没有这个元素
        }

        //按从大到小的顺序排序
        public void Sort() {
            for (int j = 0; j < Count - 1; j++) {
                for (int i = 0; i < Count - 1-j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        //交换
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}
