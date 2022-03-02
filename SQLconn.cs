using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    //LinqEg
    class SQLconn
    {
        public void LINQ()
        {
            // 1.Data Source
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2.Query Creation
            //numQuery is ArgumentNullException IEnumrable<int>
            var numQuery =

                from num in numbers
                where (num % 2) == 0

                select num;
            // 3.Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0}", num);
            }

            Console.ReadKey();
        }
    }
}
