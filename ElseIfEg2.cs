using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    class ElseIfEg2
    {
        public void ElseIfExample()
        {
			int i = 20, j = 20;

			if (i > j)
			{
				Console.WriteLine("i is greater than j");
			}
			else if (i < j)
			{
				Console.WriteLine("i is less than j");
			}
			else
			{
				Console.WriteLine("i is equal to j");
				Console.WriteLine("***");
			}
		}

		public void NestedIfElse()
        {
			int first = 7, second = -23, third = 13;
			if (first > second)
			{
				if (first > third)
				{
					Console.WriteLine("{0} is the largest", first);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
			else
			{
				if (second > third)
				{
					Console.WriteLine("{0} is the largest", second);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
		}
    }
}
