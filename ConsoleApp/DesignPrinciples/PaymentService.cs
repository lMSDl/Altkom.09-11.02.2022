using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPrinciples
{
    public class PaymentService
    {
        private CustomersService _service;

        public PaymentService(CustomersService service)
        {
            _service = service;
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = _service.GetCustomerById(customerId);
            return customer?.PaymentAccount.Charge(amount) ?? false;
        }


        public void Fund(int customerId, float amount)
        {
            var customer = _service.GetCustomerById(customerId);
            customer?.PaymentAccount.Fund(amount);
        }
    }
}
