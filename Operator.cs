using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    public class Operator
    {
        public void ArithmaticOPR()
        {
            int a = 10, b = 5;
            Console.WriteLine("ArithmaticOPR");
            Console.WriteLine(a + b );
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

        }
        public void Unary()
        {
            int x = 10;
            Console.WriteLine("Unary");

            System.Console.WriteLine("Value : " + x);
            Console.WriteLine("PreInc : " + ++x);
            Console.WriteLine("PreDec : " + --x);

            Console.WriteLine("PostInc : " + x++);           
            Console.WriteLine("PostDec : " + x--);

            Console.WriteLine("Setting Unsigned : " + +x);
            Console.WriteLine("Setting Signed : " + -x);


        }

        public void Relational()
        {
            int a = 10, b = 5;
            Console.WriteLine("Relational");

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);

        }

        public void Logical()
        {
            int a = 10, b = 5, c = 10;
            Console.WriteLine("Logical");

            Console.WriteLine(a == b && a == c);
            Console.WriteLine(a == b || a == c);
            Console.WriteLine(!(a == b && a == c));
            Console.WriteLine(!(a == b || a == c));

        }

        public void Assignment()
        {
            int x = 20;
            x += 10;
            Console.WriteLine("Assignment");

            Console.WriteLine("Add Assignment: " + x);
            x -= 10;
            Console.WriteLine("Sub Assignment: " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x /= 10;
            Console.WriteLine("Divide Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 10;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);
            Console.WriteLine("Press Enter Key to Exit..");
        }

        public void Conditional1()
        {
            int a = 6;
            int b = 4;
            Console.WriteLine("Conditional1");
            Console.WriteLine(a > b ? "a is greater than b" : "a is less than b");
            Console.WriteLine(a < b ? "a is greater than b" : "a is less than b");
            b = 6;
            Console.WriteLine(a == b ? "a is equal to b" : "a is not equal to b");
            Console.WriteLine(a != b ? "a is equal to b" : "a is not equal to b");
            Console.WriteLine((6 + 2 == 8) ? 8 : 6);
        }

        public void Conditional2()
        {

            bool loggedIn = true;
            Console.WriteLine("Conditional2");

            string status = loggedIn ? "Online" : "Offline";
            Console.WriteLine("User is " + status); // Print
        }

        public void Conditional3()
        {
            Console.WriteLine("Conditional3");

            bool loggedIn = true;
           // string status = String.Empty;
            string status = "";
            if (loggedIn)
                status = "Online";
            else
                status = "Offline";
            Console.WriteLine("User is " + status); // Print
        }

        public void Conditional4()
        {
            Console.WriteLine("Conditional4");

            int number = 3;
            string value = String.Empty;
            if (number % 2 == 0)
                value = "Even";
            else
                value = "Odd";
            Console.WriteLine("number is " + value);
        }

        public void Strings()
        {
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";

            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing the
            // reference to the original object.
            s1 += s2;

            System.Console.WriteLine(s1);
            // Output: A string is more than the sum of its chars.
        }
    }
}
