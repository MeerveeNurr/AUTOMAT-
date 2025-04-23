using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class ProductCancel_2132
    {
        public void CancelProduct(string product, ProductStock_2132 productStock)
        {
            productStock.AddProduct(product);
        }
    }
}
