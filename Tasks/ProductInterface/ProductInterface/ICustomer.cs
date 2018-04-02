using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    interface ICustomer
    {
        string SearchCustomer(Customer ctm);

        void CalBonus();
    }
}
