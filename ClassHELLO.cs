using System;
using ClassLibraryHELLO;

namespace ConsoleAppHELLO
{
    class ClassHELLO
    {
        public static void Main(String[]args)
        {
            //Class1 C = new Class1();
            //Operator O = new Operator();
            //C.HelloMethod();
            //Console.WriteLine();
            //O.ArithmaticOPR();
            //Console.WriteLine();
            //O.Unary();
            //Console.WriteLine();
            //O.Relational();
            //Console.WriteLine();
            //O.Logical();
            //Console.WriteLine();
            //O.Assignment();
            //Console.WriteLine();
            //O.Conditional1();
            //Console.WriteLine();
            //O.Conditional2();
            //Console.WriteLine();
            //O.Conditional3();
            //Console.WriteLine();
            //O.Conditional4();
            //Console.WriteLine();
            //O.Strings();
            //ConditionalEg CEg = new ConditionalEg();
            //CEg.ElseIfLadder();
            //CEg.switchcase();
            //ElseIfEg2 El = new ElseIfEg2();
            //El.ElseIfExample();
            //El.NestedIfElse();
            ArrayEg A = new ArrayEg();
            //A.AssigningArray();
            //A.TwoDArray();
            //AccessModifier acc = new AccessModifier();
            //acc.MethodPublic();
            //acc.PublicA = 10;
            //acc.InternalA = 30;
            //acc.PInternalA = 20;
            //acc.PrivateA = 90;
            //acc.ProtectedA = 20;
            //Inheritance I = new Inheritance();
            //I.Id = 10;
            //I.Name = "Anita";
            //Employee e1 = new Employee();
            //e1.Designation = "Professor";
            //e1.Id = 29;
            //e1.Name = "Tom";
            //Console.WriteLine(e1.Designation);
            //Console.WriteLine(e1.Id);
            //Console.WriteLine(e1.Name);

            SQLconn L = new SQLconn();
            L.LINQ();
            LinqBasicOperationsEx L1 = new LinqBasicOperationsEx();
            L1.LinqOp();
            ArmstrongExample arm = new ArmstrongExample();
            arm.Armstrong();
            PrimeNumberExample pr = new PrimeNumberExample();
            pr.Prime();
            LargestNo Lar = new LargestNo();
            Lar.LargestNum();
            SwapExample sw = new SwapExample();
            sw.Swap();
            ReverseExample re = new ReverseExample();
            re.reverse();
            FibonacciExample fibo = new FibonacciExample();
            fibo.Fibo();

            FactorialExample facto = new FactorialExample();
            facto.Facto();
            MainClass table = new MainClass();
            table.TablePrint();
            PalindromeExample pali = new PalindromeExample();
            pali.Palindrome();
            SumExample sum = new SumExample();
            sum.sum();
            NumberPattern pattern = new NumberPattern();
            pattern.pattern();


            Console.ReadKey();

        }

        
    }
}
