using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\Defends\quiz\ConsoleApp2\ConsoleApp2\digits.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            String[] parts = s.Split();
            fs.Close();
            sr.Close();
            int[] arr = new int[parts.Length]; 
            for (int i=0; i<arr.Length;i++)
            {
                arr[i] = int.Parse(parts[i]); 
            }
            FileStream fs2 = new FileStream(@"C:\Users\User\Desktop\Defends\quiz\ConsoleApp2\ConsoleApp2\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs2);
            
            for (int i=0; i<arr.Length; i++)
            {
                if (isPrime(arr[i]))
                    sw.Write(arr[i] + " ");

            }
            
            sw.Close();
            fs2.Close(); 
            

            
        }
        static bool isPrime (int a)
        {
            if (a == 1) return true;
            if (a == 2) return true;
            if (a == 3) return true; 
            for (int i=2; i<a; i++)
            {
                if (a % i == 0) return false; 
            } return true; 
        }
    }
}
