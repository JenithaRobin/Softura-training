using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class day12task1
    {
        public static void Main()
        {

            FileStream fs = new FileStream(@"D:\csharp\Desert.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Gulab Jamun");
            str.Add("Halwa");
            str.Add("kaju katli");
            str.Add("laddo");
            str.Add("paal Kova");
            foreach (string d in str)
            {
             bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"D:\\csharp\\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"D:\csharp\Dessert.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}