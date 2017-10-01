using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace _014_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Skill> skillList = new List<Skill>();
            ////使用JsonMapper解析Json文本
            ////JsonData代表一个数组或者一个对象
            ////在这里jsonData代表一个数组
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("SkillJson.txt"));
            //foreach (JsonData temp in jsonData)//在这里temp代表一个对象
            //{
            //    Skill skill = new Skill();
            //    //通过字符串索引器取得键值对的值
            //    JsonData idValue = temp["id"];
            //    JsonData nameValue = temp["name"];
            //    JsonData damageValue = temp["damage"];

            //    skill.Id = Int32.Parse(idValue.ToString());
            //    skill.Name = nameValue.ToString();
            //    skill.Damage = Int32.Parse(damageValue.ToString());
            //    skillList.Add(skill);

            //}
            //foreach (Skill skill in skillList)
            //{
            //    Console.WriteLine(skill);
            //}

            //使用泛型解析Json,会返回指定类型的数组
            //json文件里的对象的键值对中的建必须跟类里的字段或属性(名字，类型)对应上
            Skill[] skillArray = JsonMapper.ToObject<Skill[]>(File.ReadAllText("SkillJson.txt"));
            foreach (Skill temp in skillArray)
            {
                Console.WriteLine(temp);
            }

            List<Skill> skillList = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("SkillJson.txt"));
            foreach (Skill temp in skillList)
            {
                Console.WriteLine(temp);
            }

            Enemy enmey = JsonMapper.ToObject<Enemy>(File.ReadAllText("EnemyJson.txt"));
            Console.WriteLine(enmey);
            foreach (var temp in enmey.SkillList)
            {
                Console.WriteLine(temp);
            }

            //向Json文件中写数据
            Enemy test = new Enemy();
            test.Name = "aaa";
            test.Level = 5;
            string j = JsonMapper.ToJson(test);
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
