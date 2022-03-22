using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp1


{
    [Serializable]
    class empdetails
    {

        public string name = "Jenitha";
        public int age = 20;
        public string Empid = "456123E";
        public string gender = "Female";

    }
    class sereialization
    {
        public void SeretoFile()
        {
            empdetails sobj = new empdetails();
            FileStream fs = new FileStream(@"D:\csharp\empdetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, sobj);
            fs.Close();
        }
        public void Dserial()
        {
            FileStream fs = new FileStream(@"D:\csharp\empdetails.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            empdetails stu = (empdetails)f.Deserialize(fs);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.gender);
            Console.WriteLine(stu.Empid);



        }

        public static void Main()
        {
            sereialization lobj = new sereialization();
            lobj.SeretoFile();
            lobj.Dserial();
            Console.ReadLine();


        }
    }

}