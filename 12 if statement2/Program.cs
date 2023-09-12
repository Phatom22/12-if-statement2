using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_if_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2");
           int  num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMax(num1,num2));

            //freeze console
            Console.ReadLine();

        }
        static int GetMax( int num1, int num2)
        {

            
            if (num1 > num2)
            {
                Console.Write("the max is ");
                return num1;
            }
            else {
                Console.Write("the max is ");
                return num2;
            }
        }
    }
}
