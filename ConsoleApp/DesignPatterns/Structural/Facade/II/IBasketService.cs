using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.II
{
    public interface IBasketService
    {
        float GetPrice(int basketId);
        void AddProduct(int basketId, int productId, float price);
    }
}
