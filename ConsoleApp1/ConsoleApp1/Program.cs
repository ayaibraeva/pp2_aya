using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\Defends\quiz\ConsoleApp1\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = ""; 
            // s = s.Replace (" ","");
            bool check = true; 
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    check = false;
                    break; 
                }
            }
            if (check) Console.Write("YES");
            else Console.Write("No");
            fs.Close();
            sr.Close();
            Console.ReadKey(); 


        }
    }
}
