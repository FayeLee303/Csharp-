using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Json
{
    class Enemy
    {
        //字段和属性都要和Json文件里对应
        public string Name { get; set; }

        public int Level { get; set; }
        public List<Skill> SkillList { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level}, SkillList: {SkillList}";
        }
    }
}
