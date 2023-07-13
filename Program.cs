using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The Number is Zero");
            }
            string evenorodd =(num % 2 == 0 )? "The Number isEven" : "The Number is Odd";
            Console.WriteLine("The number is "+evenorodd+".");
            Console.ReadKey();
        }
    }
}
