using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_xml
{
    //技能类
    class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public string Language{ get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Damage: {Damage}, Language: {Language}";
        }
    }
}
