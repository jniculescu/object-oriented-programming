using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    interface IProducts
    {
        void AddProduct(Product[] products);

        void PrintProducts();
    }
}
