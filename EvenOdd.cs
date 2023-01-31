using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class EvenOdd
    {
        public static void EvenOdd1() 
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }

        }
    }
}
