using System;
class multable
{
public static void Main()
{
int numb;
Console.WriteLine("Enter number to multiply:");
numb=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
Console.Write("{0}*{1}={2}\n",numb,i,numb*i);
}
}
}