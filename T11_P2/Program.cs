using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Books books = new Books("Authoe",25);
            Console.WriteLine(books.ToString());

            Bug bug = new Bug("Ant", 25, "Forest");
            Console.WriteLine(bug.Info());

            Journal journal = new Journal("Maxim",25,2023);
            journal.Info();

            Console.ReadKey();  



        }
    }
}
