using System;
class EmpID
{
public void EDetails()
{
int Eid,YOE,Salary;
string Name,Gender;
Console.WriteLine("Enter your EmployeeId:");
Eid=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Name:");
name=Console.ReadLine();
Console.WriteLine("Enter your Gender:");
Gender=Console.ReadLine();
Console.WriteLine("Year of Experience:");
YOP=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Salary:");
Salary=Convert.ToInt32(Console.ReadLine());
}
}
class bonus1:EmpID
{
public void sales()
{
int bonusS;
bonusS=Salary*(20/100);
}
}
class bonus2:EmpID
{
public void Prod()
{
int bonusP;
bonusP=Salary*(10/100);
}
}
public static void Main()
{
EmpID obj =new EmpID();
obj.EDetails();
bonus1 obj1 =new bonus1();
obj1.sales();
bonus2 obj2 =new bonus2();
obj2.Prod();
}






