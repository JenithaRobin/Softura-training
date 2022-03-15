using System;
class Students
{
public static void Main()
{
string name;
int i,sum=0,per;
int []marks= new int[5];
Console.WriteLine("Enter your name:");
name=Console.ReadLine();
Console.WriteLine("Enter Marks:");
for(i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
sum=sum+marks[i];
} 
Console.WriteLine(sum);
Console.WriteLine();
per=sum/5;
Console.WriteLine("percentage:"+per+"%");
}
}
