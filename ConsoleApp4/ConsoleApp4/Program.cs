using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class myclass
    {
        public int a;
        public int b;
        public int c;
        public myclass(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int sum()
        {
            return a + b + c;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass triangle = new myclass(4, 5, 6);
            Console.Write(triangle.sum());
            Console.ReadKey(); 
        }
    }
}

