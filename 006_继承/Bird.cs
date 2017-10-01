using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_继承
{
    //一个抽象类就是一个不完整的模板，要声明抽象方法，必须包含在抽象类里
    abstract class Bird
    {
        private float speed;
        public void Eat() {
        }
        //抽象方法只需要声明不需要函数体{}
        public abstract void Fly();
    }
}
