using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_xml例子
{
    class Skill
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public int TriggerType { get; set; }
        public string ImageFile { get; set; }//图片路径
        public int AvailableRace { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, EnglishName: {EnglishName}, TriggerType: {TriggerType}, ImageFile: {ImageFile}, AvailableRace: {AvailableRace}, Name: {Name}";
        }
    }
}
