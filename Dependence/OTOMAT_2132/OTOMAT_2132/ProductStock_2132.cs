using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class ProductStock_2132
    {
        private Dictionary<string, int> stock = new Dictionary<string, int>
        {
            { "Kola", 10 },
            { "Su", 20 },
            { "Cikolata", 15 },
            { "Cips", 30 },
            { "Meyve Suyu", 25 },
            { "Sakız",18 },
            { "Şeker",33 },
            { "Soda" , 6 },
            { "Soğuk Kahve", 9 },
            { "Kek" , 11 } ,
        };

        public bool AretheyinStock(string product)
        {
            if (stock.ContainsKey(product) && stock[product] > 0)
            {
                return true;
            }
            return false;
        }

        public void DropProduct(string product)
        {
            if (stock.ContainsKey(product))
            {
                stock[product]--;
            }
        }

        public void AddProduct(string product)
        {
            if (stock.ContainsKey(product))
            {
                stock[product]++;
            }
        }
    }
}
