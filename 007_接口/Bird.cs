using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_接口
{
    //继承接口的子类，必须把接口里所有的函数给出实现，包括接口继承的接口，否则就会报错
    class Bird : IFlyHandler
    {
        public void Fly()
        {
            Console.WriteLine("实现接口");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
