using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppHELLO
{
    class Customer
    {

        public string Name { get; set; }

        public string City { get; set; }
    }

    class Distributor
    {
        public string Name { get; set; }    

        public string City { get; set; }
    }

    class LinqBasicOperationsEx
    {
        public void LinqOp() {
            #region
            List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "James", City = "London"},
            new Customer { Name = "Ashwin", City = "Bristol"},
            new Customer { Name = "Bond", City = "London"},
            new Customer { Name = "Southee", City = "Bristol"},
            new Customer { Name = "Mike", City = "Birmingham"},


        };

            List<Distributor> distributors = new List<Distributor>
        {
            new Distributor { Name = "ABC", City = "London"},
            new Distributor { Name = "ABB", City = "Bristol"},
            new Distributor { Name = "ANN", City = "Bristol"},

        };
            #endregion

            #region step 2 - get london customers and step 3 display london customers
            var queryLondonNameCustomers = from cust in customers
                                           where cust.City == "London" && cust.Name == "James"
                                           select cust.Name;

            // 3. Query Execution
            Console.WriteLine();
            #endregion

        }


    }

}