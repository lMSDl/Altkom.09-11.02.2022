using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseHandler<IDiscountHandler>, IDiscountHandler
    {
        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler handler) : base(handler)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public string Name { get; set; }
        public float MaxDiscount { get; }

        public float MinPrice { get; }

        public bool Discount(float value, float price)
        {
            if(MaxDiscount >= value && price >= MinPrice)
            {
                Console.WriteLine($"Rabat przyznany przez {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}
