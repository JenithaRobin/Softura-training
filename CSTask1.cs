using System;
class CStask1
{
public static void Main()
{
string name;
int age;
Console.WriteLine("Enter your name");
name=Console.ReadLine();
Console.WriteLine("Please enter your age:");
age=Convert.ToInt32(Console.ReadLine());
 for(int i=1;i<=age;i++)
 {
 Console.WriteLine("name:"+name);
 Console.WriteLine("age is:"+age);
 }
} 
}
