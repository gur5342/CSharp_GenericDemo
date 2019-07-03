using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Marine : IComparable<Marine>, IName // 비교할 수 있게 한다.
    {
        public Marine(int hp, string name)
        {
            HP = hp;
            Name = name;
        }
        public int HP { get; set; }

        public string Name { get; set; }

        public int CompareTo(Marine other) // 다른 것과 비교하라.
        {
            //return HP - other.HP
            return HP.CompareTo(other.HP); // 위와 같은 말
            //return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"HP : {HP}, Name : {Name}";
        }

        public string SayName() // program에 있는 SayName 인터페이스
        {
            return Name;
        }
    }
}
