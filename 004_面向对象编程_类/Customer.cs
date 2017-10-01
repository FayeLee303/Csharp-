using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_面向对象编程_类
{
    public class Customer
    {
        //把字段设置为private,然后用public方法设置它或者返回它
        private string name;
        private int hp;
        public void SetName(string n) {
            this.name = n;
        }
        public void SetHp(int hp) {
            this.hp = hp;
        }

        //定义属性来获取字段
        public string Name {
            get { return this.name; }
            private set { this.name = value; }
            //如果在get或set块前面加private表示这个块只能在类内部调用
            //这里是只能读，不能修改
        }
        public int Hp
        {
            get { return this.hp; }
            set {
                //通过set方法可以在设置值之前做一些校验
                if (value>=0) {
                    this.hp = value;
                }
            }
        }

        public int Age { get; set; }//编译器会自动生成一个字段来储存age
        public void Show() {
            Console.WriteLine("名字" + name);
            Console.WriteLine("Hp" + hp);
        }

        //和类方法同名的叫做构造函数
        public Customer(string name,int hp){
            //做初始化
            this.name = name;
            this.hp = hp;
        }

        //定义属性,注意名称后面没有括号
        public int MyIntProperty{
            set{
                Console.WriteLine("属性中的set块被调用");
                Console.WriteLine("在set块中访问value的值是"+value);
            }
            //如果没有get块就不能通过属性取值了
            get{
                Console.WriteLine("属性中的get块被调用");
                return 100;
            }
        }
    }
}
