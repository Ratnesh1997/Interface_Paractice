using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Paractice
{
   interface My_practice
    {
         void Sum();
    }

    class add : My_practice
    {
        public void Sum()
        {
            int a, b, sum;

            Console.WriteLine("Enter 2 Number TO perform adddition");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Sum of {0} And {1} is {2}", a, b, sum);
            for (int i = 1; i < 4; i++)
            {
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Interface Implimented");
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            add obj = new add();
            obj.Sum();
            Console.ReadKey();


        }
    }

}