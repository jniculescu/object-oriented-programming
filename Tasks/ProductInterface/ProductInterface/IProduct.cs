using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    interface IProduct
    {
        string GetProduct(Product prod);
        void Average();
    }
}
