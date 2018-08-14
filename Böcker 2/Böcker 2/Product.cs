using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_2
{
    class Product
    {
        int productID = 1233;

        internal void SetProductID()
        {
            productID++;
        }
        internal object GetProductID()
        {
            return productID;
        }
 
    }
}
