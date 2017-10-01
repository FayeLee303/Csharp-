using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_接口
{
    interface IFlyHandler:IMoveHandler
    {
        //只做声明不做实现
        void Fly();
    }
}
