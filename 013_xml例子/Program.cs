using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _013_xml例子
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("SkillInfo.txt");
            XmlNode SkillInfoNode = xmlDoc.FirstChild;//得到根节点
            XmlNode SkillListNode = SkillInfoNode.FirstChild;//得到二级结点
            XmlNodeList SkillNodeList = SkillListNode.ChildNodes;
            foreach (XmlNode skillNode in SkillNodeList)
            {
                Skill skill = new Skill();
                XmlElement ele = skillNode["Name"];
                skill.Name = ele.InnerText;
                XmlAttributeCollection col = skillNode.Attributes;//获取结点属性的集合
                skill.Id = Int32.Parse(col["SkillID"].Value);//通过字符串索引获取集合内数据
                skill.TriggerType = Int32.Parse(col["TriggerType"].Value);
                skill.EnglishName = col["SkillEngName"].Value;
                skill.ImageFile = col["ImageFile"].Value;
                skill.AvailableRace = Int32.Parse(col["AvailableRace"].Value);
                skillList.Add(skill);
            }

            foreach (Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }
            Console.ReadKey();
        }
    }
}
