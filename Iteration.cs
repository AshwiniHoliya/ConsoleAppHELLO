using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    class Iteration
    {
        public void WhileLoop()
        {//initialization,condition,increament/decreament,loop will run upto 6 times 1-5
            Console.WriteLine("\nWhile Example");
            int a = 1;
            while (a <= 5)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("***END***");
            Console.ReadLine();
        }

        public void DOWhileLoop()
        {
            Console.WriteLine("\nDo-While Example");
            int b = 1;
            //we must write do block to perform prosess what we want to print and then inc
            do
            {
                Console.WriteLine(b);
                b++;

            } while (b <= 10);
            Console.WriteLine("***END***");
            Console.ReadLine();
                       
        }

        public void ForLoop()
        {
            Console.WriteLine("For Loop Example");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***END***");
            Console.WriteLine();
        }
    }
}
