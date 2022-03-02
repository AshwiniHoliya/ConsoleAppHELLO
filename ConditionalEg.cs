using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    class ConditionalEg
    {
        public void ElseIfLadder()
        {
            Console.WriteLine("Enter Mark 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            if (m1 >= 40)
            {
                Console.WriteLine("\nResult: PASS");

                Console.WriteLine("\nTotal Marks: {0}", m1);

                double percentage = m1;
                Console.WriteLine("\nPercentage: {0}", percentage);

                string resultClass = string.Empty;
                if (percentage >= 40 && percentage <= 49.99)
                {
                    resultClass = "Third";
                }
                else if (percentage >= 50 && percentage <= 59.99)
                {
                    resultClass = "Second";
                }
                else if (percentage >= 60 && percentage <= 74.99)
                {
                    resultClass = "First";
                }
                else if (percentage >= 75)
                {
                    resultClass = "Distinction";
                }

                Console.WriteLine("\nClass: {0}", resultClass);
            }
            else
            {

                Console.WriteLine("\nResult: Fail");
            }
            Console.WriteLine("\nResult: Fail");

             }

        public void switchcase()
        {
            int cashPrize = 0;
            string resultClass = "First";
            switch (resultClass)
            {
                case "Third":
                    cashPrize = 500;
                    break;
                case "Second":
                    cashPrize = 1000;
                    break;
                case "First":
                    cashPrize = 2000;
                    break;

                case "Distinction":
                    cashPrize = 5000;
                    break;
                default:
                    Console.WriteLine("Default Value");
                    break;

            }

            Console.WriteLine("\nCash Prize: {0}", cashPrize);
        }


       }
    
}
    
