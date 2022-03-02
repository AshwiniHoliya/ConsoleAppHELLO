using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
    class AccessModifier
    {
        //Public method
        public int PublicA = 10;
        private int PrivateA = 20;
        protected int ProtectedA = 30;
        internal int InternalA = 40;
        protected internal int PInternalA = 50;

        public void MethodPublic()
        {
            //definition of MethodPublic
            Console.WriteLine(PublicA);
            Console.WriteLine(PrivateA);
            Console.WriteLine(ProtectedA);
            Console.WriteLine(InternalA);
            Console.WriteLine(PInternalA);
            
        }
    }
}
