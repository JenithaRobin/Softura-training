using System;
class Objtask
{
public void name()
{
string name;
Console.WriteLine("Enter your name:");
name=Console.ReadLine();
}
}
class task2
{
public void age()
{
int age;
Console.WriteLine("Enter your age:");
age=Convert.ToInt32(Console.ReadLine());
}
}
class Object
{
public static void Main()
{
Objtask obj1 =new Objtask();
obj1.name();
task2 obj2 =new task2();
obj2.age();
}
}




