using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Incomes { get; set; }
        public float Outcomes { get; set; }
        public float AllowedDebit { get; set; }
        public bool HasDebit => Incomes - Outcomes < 0;
    }

    
}
