using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Firstprogram
{
    class Fstream2
    {
        public static void Main()
        {
            FileStream fs = new FileStream("D:\\csharp\\Content.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.Write("Vande maatram was written by bankim chandra chatterji");
            sw.Flush();
            sw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\csharp\\trail.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String str = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(str);



        }

    }
}
