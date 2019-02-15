using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class triangle
    {
        private int a, b, c; 
        public triangle (int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public int GetA()
        {
            return a; 
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
            FileStream fs = new FileStream(@" C:\Users\User\Desktop\Defends\quiz\ConsoleApp5\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            string[] parts = s.Split();
            int[] a = new int[parts.Length];
            for (int i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(parts[i]); 
            }
            FileStream fs1 = new FileStream(@" C:\Users\User\Desktop\Defends\quiz\ConsoleApp5\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1); 

              
            triangle triangle = new triangle(4, 5, 6);
            Console.WriteLine(triangle.GetA());
            Console.WriteLine(triangle.sum());
            Console.ReadKey();

        }
    }
}
