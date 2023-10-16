using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5B_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isTempGreaterOrLess(120, -1));
            Console.WriteLine(isTempGreaterOrLess(-1, 120));
            Console.WriteLine(isTempGreaterOrLess(2, 120));

            Console.ReadLine();
        }
        //Method that checks whether one temperature is less than 0 and another is greater than 100.
        public static bool isTempGreaterOrLess(int temp1, int temp2)
        {
            if(temp1 <0 ||temp1>100 && temp2 > 100 || temp2< 0)
            {
                return true;
            }
            return false;
        }
    }
}
