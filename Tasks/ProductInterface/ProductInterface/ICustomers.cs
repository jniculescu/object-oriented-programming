using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    interface ICustomers
    {
        void AddCustomer(Customer[] customers);

        void PrintCustomer();
    }
}
