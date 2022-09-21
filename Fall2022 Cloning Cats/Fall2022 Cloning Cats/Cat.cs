using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Cloning_Cats
{
    internal class Cat : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFat { get; set; }
        // public Owner Owner { get; set; } -> shallow vs. deep clones
        public Cat()
        {
            Name = "Dez";
            Age = 7;
            IsFat = true;
        }

        public Cat(string name, int age, bool isFat)
        {
            Name = name;
            Age = age;
            IsFat = isFat;
        }

        public object Clone()
        {
            return new Cat(this.Name, this.Age, this.IsFat);
        }

        public static bool operator == (Cat a, Cat b)
        {
            return a.Name == b.Name && a.Age == b.Age && a.IsFat == b.IsFat;
        }
        public static bool operator != (Cat a, Cat b)
        {
            return !(a.Name == b.Name && a.Age == b.Age && a.IsFat == b.IsFat);
        }
    }
}
