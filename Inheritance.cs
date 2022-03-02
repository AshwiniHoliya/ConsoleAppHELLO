using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHELLO
{
   public class Inheritance
    {
        private string name;
        private int id;

        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Employee : Inheritance
    {
        private string designation;

        public string Designation { get; set; }
        
    }
}
