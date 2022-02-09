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
            if (customer == null)
                return false;
            return Charge(customer.PaymentAccount, amount);
        }

        public void Fund(int customerId, float amount)
        {
            var customer = _service.GetCustomerById(customerId);
            if (customer != null)
                Fund(customer.PaymentAccount, amount);
        }

        public bool Charge(PaymentAccount paymentAccount, float amount)
        {
            return paymentAccount.Charge(amount);
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            paymentAccount.Fund(amount);
        }
    }
}
