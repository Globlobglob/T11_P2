using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Bug
    {
        public string name ;
        public int speed;
        public string area;

        Bug() { }
        public Bug(string name,int speed, string area)
        {
            this.name = name;
            this.speed = speed;
            this.area = area;
        }

        public string Info()
        {
            return $"Name {name}\n Speed {speed} \n Area {area}";
        }

    }
}
