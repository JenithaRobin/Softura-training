using System;
class covidtask
{
public static void Main()
{

string hist,temp,cough;

Console.WriteLine("Do you have any travel history?");
hist=Console.ReadLine();



if(hist=="Yes")
{
Console.WriteLine("please tell your bodytemperature?");
temp=Console.ReadLine();

if(temp=="Yes")
{
Console.WriteLine("Do you have cough/sneeze?");
cough=Console.ReadLine();

if(cough=="Yes")
{
Console.WriteLine(" take Swab Test");
}
else
{
Console.WriteLine("Quarantine Fever Medicine");
}
}
else
{
Console.WriteLine("You have to Home Quartine for 28 days");
}

}
else
{
Console.WriteLine("You're Safe-Not Covid-19");
}
}
}