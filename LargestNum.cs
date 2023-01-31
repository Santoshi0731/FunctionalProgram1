using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LargestNum
    {
        public static void FindTheLargestNum()
        {
            int num1, num2, num3;

            Console.WriteLine("Enter The 1st Number");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The 2st Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter The 3st Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("1st number is greatest among three");
                }
                else
                {
                    Console.WriteLine("3st number is greatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("2st number is greatest among three");
            }
            else 
            {
                Console.WriteLine("3st number is greatest among three");
            }
        }
    }
}
