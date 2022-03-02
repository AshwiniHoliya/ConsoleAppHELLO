using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    class ArrayEg
    {
        public void AssigningArray()
        {
            int[] arr = new int[3];  //Declaration of array
            arr[0] = 10;              //Initialization
            arr[1] = 20;
            arr[2] = 30;

            int[] copyarray = new int[] { 1, 3, 5, };  //other way to declare and initialize array in a single line

            arr = copyarray;  //assigning one array into ather
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);   //retriving the value from array
            }
            Console.ReadKey();

        }

        public void TwoDArray()
        {
            int[,] a = new int[5, 2]
            {
                {0,0 },{1,2},{2,4},{3,6},{4,8}
            };
            int i, j;

            for(i =0; i< 5; i++)
            {
                for(j =0;j < 2; j++)
                {
                   // Console.WriteLine("a[{0},{ 1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();
        }

        public void Matrix()
        {
            //Addition of Matrix

            int[,] a = new int[3, 3];
            int[,] c = new int[3, 3];

            Console.WriteLine("Enter Elements into the first Array");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] b = new int[3, 3];
            Console.WriteLine("Enter Element into second array");
            for(int i = 0; i< 3; i++)
            {
                for(int j =0;j < 3;j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //
            Console.WriteLine("Sum of two matrces");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for(int i = 0;i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
