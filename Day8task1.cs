using System;
class addsub
{
public void Aoper(int num1,int num2)
{
int res1,res2;
res1=num1+num2;
res2=num1-num2;
Console.WriteLine(res1);
Console.WriteLine(res2);
}
}
class muldiv:addsub
{
public void Aoper1(int num1,int num2) 
{
int res3,res4;
res3=num1*num2;
res4=num1/num2;
Console.WriteLine(res3);
Console.WriteLine(res4);
}
}
class Inherit
{
public static void Main()
{
Console.WriteLine("Enter 2Nos:");
addsub obj1=new addsub();
obj1.Aoper(45,21);
muldiv obj2=new muldiv();
obj2.Aoper1(75,56);
}
}
