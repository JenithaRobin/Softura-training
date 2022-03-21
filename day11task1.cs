using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Firstprogram
{
    class day11task1
    {
        public static void Main()
        {

            FileStream fs = new FileStream("D:\\csharp\\RDessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Gulab Jaamun");
            str.Add("Laddo");
            str.Add("Ice cream");
            str.Add("Halwa");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\csharp\\RDessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"D:\csharp\RDessert.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}
