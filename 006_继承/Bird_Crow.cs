using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    //继承抽象类的时候必须去实现抽象方法，给出函数体
    class Bird_Crow:Bird
    {
        public override void Fly()
        {
            Console.WriteLine("乌鸦 Fly");
        }
    }
}
