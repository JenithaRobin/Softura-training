using System;
class tvchannel
{
public static void Main()
{
string package;
Console.WriteLine("What Package do you want?");
package=Console.ReadLine();
switch(package)
{
case "packageA":Console.WriteLine("SouthSpecial,Children's club,Movies"+"Price is Rs.250");
  break;
case "packageB":Console.WriteLine("News,Sports,Movies"+"Price is Rs.450");
   break;
case "packageC":Console.WriteLine("Discovery,History,national"+"Price is Rs.350");
   break;
}
}

}