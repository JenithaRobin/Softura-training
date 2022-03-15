using System;
class plist
{
public static void Main()
{
string[][]List=new string[3][];
List[0]=new string[]{"Biscuits","Biscuits","Biscuits","Biscuits"};
List[1]=new string[]{"Chocolates","Chocolates","Chocolates","Chocolates","Chocolates"};
List[2]=new string[]{"Drinks","Drinks","Drinks","Drinks","Drinks","Drinks"};
for(int i=0;i<List.Length;i++)
 {
 for(int j=0;j<List[i].Length;j++)
 Console.Write(List[i][j]+"\t");
 Console.WriteLine();
 }

}
}