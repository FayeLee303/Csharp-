using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _012_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();//技能集合，用来储存所有的技能信息
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Skill.txt");//这里是直接加载文件
            //xmlDoc.LoadXml(File.ReadAllText("Skill.txt"));//这里是传递一个xml格式的字符串
            //得到根节点
            XmlNode rootNode = xmlDoc.FirstChild;//获取第一个节点
            //得到根节点下面子节点的集合
            XmlNodeList skillNodeList = rootNode.ChildNodes;
            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();
                XmlNodeList fieldNodeList = skillNode.ChildNodes;//获取skill结点下的所有节点
                foreach (XmlNode fieldNode in fieldNodeList)
                {
                    if (fieldNode.Name == "id")//通过Name属性获取一个结点的名字
                    {
                        int id = Int32.Parse(fieldNode.InnerText); //获取结点内部的文本,并转换成int
                        skill.Id = id;
                    }
                    else if (fieldNode.Name == "name")//通过Name属性获取一个结点的名字
                    {
                        string name = fieldNode.InnerText.ToString(); //获取结点内部的文本,
                        skill.Name = name;
                        skill.Language = fieldNode.Attributes[0].Value;//获取结点的属性
                    }
                    else if (fieldNode.Name == "damage")//通过Name属性获取一个结点的名字
                    {
                        int damage = Int32.Parse(fieldNode.InnerText); //获取结点内部的文本,并转换成int
                        skill.Damage = damage;
                    }
                }
                skillList.Add(skill);//添加到列表里
            }
            //输出
            foreach (Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }

            Console.ReadKey();
        }
    }
}
