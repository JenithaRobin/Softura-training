using System;
class todaytask
{
public static void Main()
{
int Rs,unit;
Console.WriteLine("Enter consumed unit:");
unit = Convert.ToInt32(Console.ReadLine());
if (unit<=200)
{
Rs = unit *2;
Console.WriteLine(Rs);
}
 else if((unit>200) && (unit<=350))
{
unit = unit-200;
Rs = unit*3;
Console.WriteLine(Rs+400);
}
else if((unit>350) && (unit<=500))
{
unit = unit-350;
Rs =  unit*5;
Console.WriteLine(Rs+450+400);
}
else if(unit>500)
{
unit = unit-500;
Rs = unit *7;
Console.WriteLine(Rs+750+450+400);
}
}
}