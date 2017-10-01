using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Json
{
    class Skill
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Damage { get; set; }
        //public override string ToString()
        //{
        //    return $"Id: {Id}, Name: {Name}, Damage: {Damage}";
        //}
        public int id;
        public string name;
        public int damage;

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Damage: {damage}";
        }
    }
}
