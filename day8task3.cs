using System;
class Poly1
{
public void ulogin()
{
Console.WriteLine("Please enter your Email:");
string email=Console.ReadLine();
Console.WriteLine("Please enter your password:");
string password=Console.ReadLine();
}
public void ulogin(string mem,int pin)
{
Console.WriteLine("Enter membership_ID:"+mem);
Console.WriteLine("Enter Pin:"+pin);

}
public void ulogin(long mobile,int pin)
{
Console.WriteLine("Enter mobile number:"+mobile);
Console.WriteLine("Enter Pin:"+pin);
Console.WriteLine("Validation Success");
}
public static void Main()
{ 
Poly1 obj=new Poly1();
obj.ulogin();
obj.ulogin("Jeni",123);
obj.ulogin(9876543210,123);
}
}