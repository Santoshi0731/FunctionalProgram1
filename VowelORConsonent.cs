using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{X
    public class VowelORConsonent
    {
        public static void Character()
        {
            Console.WriteLine("Enter the charachter");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a'|| ch=='e' || ch=='i' || ch=='o' || ch=='u' || 
                ch=='A'|| ch=='E' || ch=='I' || ch=='O'|| ch=='U')
            { 
                Console.WriteLine(ch + "is a Vowel");
            }
            else if((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
            {
                Console.WriteLine(ch + "is a Constant");
            }
        
        }
    }
}
