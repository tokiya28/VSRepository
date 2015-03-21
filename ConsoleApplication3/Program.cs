using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello To this World full of fun");
            

            object x = new object();

            Console.WriteLine(x ?? "test");
            Console.ReadLine();
        }
    }
}
