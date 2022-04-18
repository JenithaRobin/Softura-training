using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Activityapr15
{
    class product
    {
        public void validation(int CustID)
        {

            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
            SqlCommand cmd = new SqlCommand("select Custname from Customerinfo where CustID= " + CustID + "", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(" Custname : " + dr[0]);
            }
            con.Close();



            if (CustID >= 321 & CustID <= 324)
            {
                Console.WriteLine("You're existing customer!!!!!,products are");
                SqlCommand cmd2 = new SqlCommand("select  ProdID,Productname,Price,Expiry from productinfo ", con);
                con.Open();
                SqlDataReader dread = cmd2.ExecuteReader();
                while (dread.Read())
                {
                    Console.WriteLine(" ProdID- " + dread[0] + "  " + "Productname-" + dread[1] + "   " + "Price-" + dread[2] + "  " + "Expiry-" + dread[3]);
                }
                con.Close();

            }
            else
            {
                Console.WriteLine("You're not an existing customer!!!!!,please enter your details: ");
                Console.WriteLine("Please Enter your Name:");
                string Custname = Console.ReadLine();
                Console.WriteLine("Male/Female:enter M or F");
                string Gender = Console.ReadLine();
                Console.WriteLine("Please Enter your DOB:");
                string DoB = Console.ReadLine();
                Console.WriteLine("Enter your contactno:");
                string Contactno = Console.ReadLine();
                Console.WriteLine("Please Enter your Emailaddress:");
                string EmailID = Console.ReadLine();
                Console.WriteLine("Please Enter your City:");
                string City = Console.ReadLine();
                
                SqlConnection con1 = new SqlConnection("data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                
                SqlCommand cmd1 = new SqlCommand("insert into Customerinfo(Custname,Gender,DoB,Contactno,EmailID,City) values('" + Custname + "','" + Gender + "','" + DoB + "','" + Contactno + "','" + EmailID + "','" + City + "')", con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                Console.WriteLine("Row inserted:");
                

            }

        }



    }
    public class purchasedet

    {
        int totala;
        public void prodetails(int p,int CustID)
        {
            SqlConnection con = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
            SqlCommand cmd = new SqlCommand("select CustID,Custname,Gender,Contactno,EmailID,DoB,City from Customerinfo where CustID = " + CustID + "", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int P = p;
            switch (P)
            {
                case 101:

                    Console.WriteLine(" Dhal ");
                    Console.WriteLine("enter the Quantity of Rice:");
                    int q = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmd2 = new SqlCommand("select price* " + q + " from productinfo where ProdID = " + P + "", con1);
                    

                    con1.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd2.ExecuteReader();
                    while (dr1.Read())
                    {
                        totala = Convert.ToInt32(dr1[0]);
                        Console.WriteLine(" \nBill: \n you purchased:Rice \n Total Amount " + totala);
                       
                    }

                    con1.Close();
                    SqlConnection conA = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmdA = new SqlCommand("insert into purchaseinfo(Cusid,Proid, Quantity,Totalamt)values("+CustID+","+P+","+q+","+totala+")", conA);
                    conA.Open();
                    cmdA.ExecuteNonQuery();
                    conA.Close();
                    break;
                case 102:
                    Console.WriteLine("SunflowerOil ");
                    Console.WriteLine("enter the Quantity of sunfloweroil:");
                    int q2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmd3 = new SqlCommand("select price* " + q2 + " from productinfo where ProdID = " + P + "", con2);
                    con2.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd3.ExecuteReader();
                    while (dr2.Read())
                    {
                        totala = Convert.ToInt32(dr2[0]);
                        Console.WriteLine("\nBill: \nyou purchased: SunflowerOil \n  Total Amount " + totala);
                    }
                    con2.Close();
                    SqlConnection conB = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmdB = new SqlCommand("insert into purchaseinfo(Cusid,Proid, Quantity,Totalamt)values(" + CustID + "," + P + "," + q2+ "," + totala + ")", conB);
                    conB.Open();
                    cmdB.ExecuteNonQuery();
                    conB.Close();
                    break;
                case 103:
                    Console.WriteLine("lemonPickle");
                    Console.WriteLine("Enter the Quantity");
                    int q3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmd4 = new SqlCommand("select price* " + q3 + " from productinfo where ProdID = " + P + "", con3);
                    con3.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd4.ExecuteReader();
                    while (dr3.Read())
                    {
                        totala = Convert.ToInt32(dr3[0]);
                        Console.WriteLine("\nBill: \n you purchased: lemonPickle  \n  Total Amount " + totala);
                    }
                    con3.Close();
                    SqlConnection conC = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmdC = new SqlCommand("insert into purchaseinfo(Cusid,Proid, Quantity,Totalamt)values(" + CustID + "," + P + "," + q3 + "," + totala + ")", conC);
                    conC.Open();
                    cmdC.ExecuteNonQuery();
                    conC.Close();
                    break;
                case 104:
                    Console.WriteLine("Dates");
                    Console.WriteLine("Enter the Quantity");
                    int q4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source =Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmd5 = new SqlCommand("select price* " + q4 + " from productinfo where ProdID = " + P + "", con4);
                    con4.Open();
                    cmd5.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd5.ExecuteReader();
                    while (dr4.Read())
                    {
                        totala = Convert.ToInt32(dr4[0]);
                        Console.WriteLine("\nBill: \n you Purchased:Dates \n  Total Amount " + totala);
                    }
                    con4.Close();
                    SqlConnection conD = new SqlConnection("Data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                    SqlCommand cmdD = new SqlCommand("insert into purchaseinfo(Cusid,Proid, Quantity,Totalamt)values(" + CustID + "," + P + "," + q4 + "," + totala + ")", conD);
                    conD.Open();
                    cmdD.ExecuteNonQuery();
                    conD.Close();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }

            con.Close();
        }

        
    }
    public class pinfo
    {
        public void billinfo()
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
            SqlCommand cmd = new SqlCommand("select pur.BillNo,CustID,Custname,ProdID,Productname,Totalamt,City from Purchaseinfo pur join productinfo pro on pur.Proid = pro.ProdID join Customerinfo cus on pur.Cusid = cus.CustID", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine(" BillNo " + read[0] + " CustID " + read[1] + " Custname " + read[2] + " ProdID " + read[3] + " Productname " + read[4] + " Totalamt " + read[5] + " City " + read[6]);
                Console.WriteLine("Enter customerid:");
            }
            con.Close();
            int customerid = Convert.ToInt32(Console.ReadLine());
                SqlConnection con9 = new SqlConnection("data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
                SqlCommand cmd9 = new SqlCommand("select * from Purchaseinfo where Cusid = "+customerid, con9);
                con9.Open();
                SqlDataReader dr9 = cmd9.ExecuteReader();
                while(dr9.Read())
                {
                    Console.WriteLine("        BillNo :      " + dr9[0] + "        Cusid:        " + dr9[1] + "       Proid:     " + dr9[2] + "     Quantity      " + dr9[3] + "        Totalamt     " + dr9[4] + "      purchaseDate      " + dr9[5]);
                }
            con9.Close();
                Console.WriteLine("Enter Date:");
                var date = Convert.ToString(Console.ReadLine());
            SqlConnection con10 = new SqlConnection("data source =LAPTOP-0SAKDNQM; database = Deptstores;integrated security=true");
            SqlCommand cmd10 = new SqlCommand("select * from Purchaseinfo where PurchaseDate = '"+date+"'", con10);
            con10.Open();
            SqlDataReader dr10 = cmd10.ExecuteReader();
                while(dr10.Read())
                {
                    Console.WriteLine("   BillNo :   " +  dr10[0] +  "    Cusid:   "+dr10[1]+"    Proid:     "+dr10[2]+"    Quantity     "+dr10[3]+"     Totalamt    "+dr10[4]+"    purchaseDate    "+dr10[5]);
                }
                con10.Close();

            con.Close();

        }



    }
    public class Mainmeth
    {
        public static void Main()
        {
            product obj = new product();
            Console.WriteLine("Please enter your CustomerID:");
            int CustID = Convert.ToInt32(Console.ReadLine());
            obj.validation(CustID);
            purchasedet obj1 = new purchasedet();
            Console.WriteLine("Enter which you want to purchase:");
            int p = Convert.ToInt32(Console.ReadLine());
            obj1.prodetails(p,CustID);
            pinfo obj2 = new pinfo();
            Console.WriteLine("Hello customer!!!your bill is here!!! ");
            obj2.billinfo();

        }


    }
}




    



