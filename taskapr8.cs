using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Linq
{
    class goatducks
    {
        public static void Main()
        {
            int Eyes = 52, Legs = 80;
            int count1 = 0;
            int count2 = 0;
            count1 = 2 * (Eyes) - (Legs);
            count1 = count1 / 2;

            Console.WriteLine("Number of Ducks:" + count1);
            count2 = 26 - count1;
            Console.WriteLine("Number of Goats:" + count2);


        }
    }
}
