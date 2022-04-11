using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class taskapr11
    {
        public class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int Age { get; set; }

            public int BranchId { get; set; }
        }
        public class Specilization
        {
            public int BranchId { get; set; }

            public string BranchName { get; set; }
        }
        public static void Main()
        {
            IList<Doctor> StuData = new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, DoctorName = "Jeni", Age = 22, BranchId = 1},
                new Doctor() { DoctorID = 2, DoctorName = "Robi", Age = 23, BranchId = 2},
                new Doctor() { DoctorID = 3, DoctorName = "Dev", Age = 21, BranchId = 3},
                new Doctor() { DoctorID = 4, DoctorName = "Nila", Age = 21, BranchId = 2},
                new Doctor() { DoctorID = 5, DoctorName = "Darshan", Age = 23, BranchId = 3},
            };

            IList<Specilization> BranchData = new List<Specilization>()
            {
                new Specilization() {BranchId = 1,BranchName = "Physio"},
                new Specilization() {BranchId = 2,BranchName = "Homeo"},
                new Specilization() {BranchId = 3,BranchName = "Siddha"},

            };
            var JoinData = StuData.Join(
                BranchData,
                stu => stu.BranchId,
                brd => brd.BranchId,
                (stu, brd) => new
                {
                    DoctorName = stu.DoctorName,
                    BranchName = brd.BranchName
                }
                    );
            foreach (var v in JoinData)
            {
                Console.WriteLine(v.DoctorName + "  " + v.BranchName);
            }

        }
    }
}
