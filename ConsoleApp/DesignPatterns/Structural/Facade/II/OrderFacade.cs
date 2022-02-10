using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private IBasketService basketService;
        private IPaymentService paymentService;
        private IProductService productService;

        public OrderFacade(IBasketService basketService, IPaymentService paymentService, IProductService productService)
        {
            this.basketService = basketService;
            this.paymentService = paymentService;
            this.productService = productService;
        }

        public void Order(int basketId, IEnumerable<int> productIds)
        {
            foreach (var id in productIds)
            {
                var price = productService.GetPrice(id);
                basketService.AddProduct(basketId, id, price);
            }
            paymentService.Pay(basketId, basketService.GetPrice(basketId));
        }
    }
}
