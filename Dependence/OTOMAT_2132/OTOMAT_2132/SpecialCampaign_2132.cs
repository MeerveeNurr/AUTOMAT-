using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class SpecialCampaign_2132
    {
        public void ApplyCampaign(string productPurchased, string freeProduct, Dictionary<string, string> specialCampaigns)
        {
            specialCampaigns[productPurchased] = freeProduct;
            Console.WriteLine($"Özel kampanya uygulandı: {productPurchased} alana {freeProduct} bedava.");
        }
    }
}
