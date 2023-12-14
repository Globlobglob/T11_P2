using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Journal
    {
        public string name;
        public int num;
        public int date ;


        public Journal(string name,int num,int date)
        {
            this.name = name;
            this.num = num;
            this.date = date;
        
        }


        public void Info()
        {
            Console.WriteLine($"Name:{name} \n Index:{num} \n Date:{date}");
        }



    }
}
