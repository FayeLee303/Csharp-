using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_泛型
{
    //泛型就是说可以有多种数据类型选择，
    class ClassA<T,T1>//T代表一个泛指的数据类型，当用ClassA进行构造的时候需要指定数据类型
    {
        //定义泛型类的时候可以有多个数据类型位置
        private T a;
        private T b;
        private T1 c;

        //构造方法
        public ClassA(T a, T b) {
            this.a = a;
            this.b = b;
        }

        public string GetSum() {
            return a +""+ b;
        }
    }
}
