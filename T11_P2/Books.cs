using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Books
    {

        public string author;
        public int year;
        public Books() { }
        public Books(string author,int year) 
        
        {
          this.author = author;
            this.year = year;
                
        }


        public override string ToString()
        {
            return $"author={author} \n year={year}";
        }



    }




}
