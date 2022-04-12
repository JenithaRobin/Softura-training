using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp_apr12
{
    class Program
    {
            public static void Main()
            {
               SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;user id =sa; password = P@ssw0rd");
                con.Open();
                SqlCommand cmd = new SqlCommand("create table task_Enrollment(sno int,Fname varchar(20),lname varchar(20),gender char(1))",con);
                Console.WriteLine("created successfully");
               
                  con.Close();
                 Program obj = new Program();
                 obj.ins();
                 obj.del();
                 obj.upd();
                 Console.WriteLine("Enter sno:");
                 int sno = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Fnamee:");
                 string Fname = Console.ReadLine();
                 Console.WriteLine("Enter Lname:");
                 string Lnmae = Console.ReadLine();
                 Console.WriteLine("Enter gender:");
                 string gender = Console.ReadLine();
                 obj.inSP(sno,Fname, Lnmae, gender);
                 string lname = Console.ReadLine();
               
                 obj.updSP(Lnmae);
                 obj.Delsp(4);
            }
           public void ins()
           {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;user id =sa; password = P@ssw0rd");
            string sqlqry = "insert task_Enrollment values(004,'Darshan','Raj','M')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row Inserted Successfully!!!");

           }
        public void del()
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;user id =sa; password = P@ssw0rd");
            string sqlqry = " delete from task_Enrollment WHERE lname = 'Raj'";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row deleted Successfully!!!");

        }
        public void upd()
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;user id =sa; password = P@ssw0rd");
            string sqlqry = "update task_Enrollment set lname = 'kutty' WHERE Fname = 'Dev' ";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row updated Successfully!!!");

        }

        public void inSP(int sno, string Fname,string Lnmae, string gender)
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;integrated security=true");
            SqlCommand cmd = new SqlCommand("sp_Enroll", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = Fname;
            cmd.Parameters.Add("@Lnmae", SqlDbType.VarChar).Value = Lnmae;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            Console.WriteLine("stored procedure inserted successfully");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
        public void updSP(string Lnmae)
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;integrated security=true");
            SqlCommand cmd = new SqlCommand("sp_upd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            cmd.Parameters.Add("@Lnmae", SqlDbType.VarChar).Value = Lnmae;
            
            Console.WriteLine("stored procedure updated successfully");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Delsp(int sno)
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = StudentInfo;integrated security=true");
            SqlCommand cmd = new SqlCommand("sp_del", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            Console.WriteLine("stored procedure deleted successfully");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}
