using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class Automat_2132
    {
        private int totalMoney = 0;
        private Dictionary<string, int> products = new Dictionary<string, int>
        {
            { "Kola", 2 },
            { "Su", 1 },
            { "Cikolata", 3 },
            { "Cips", 4 },
            { "Meyve Suyu", 5 },
            { "Sakız",6 },
            { "Şeker",7 },
            { "Soda" , 8 },
            { "Soğuk Kahve", 9 },
            { "Kek" , 10 } ,

        };

        private Dictionary<string, string> specialCampaigns = new Dictionary<string, string>();
        private Refund_2132 moneyRefund = new Refund_2132();
        private ProductStock_2132 productStock = new ProductStock_2132();
        private ProductCancel_2132 productCancel = new ProductCancel_2132();
        private SpecialCampaign_2132 specialCampaign = new SpecialCampaign_2132();
        private MoneyDeposit_2132 depositMoney = new MoneyDeposit_2132();

        public void AddMoney(int money)
        {
            totalMoney += money;
            Console.WriteLine($"Eklendi: {money} TL. Toplam: {totalMoney} TL");
        }

        public void SelectProduct(string product)
        {
            int price = GetPrice(product);

            if (price == -1)
            {
                Console.WriteLine($"{product} ürünü mevcut değil.");
                return;
            }

            if (totalMoney < price)
            {
                Console.WriteLine($"{product} ürününü almak için yeterli para yok. Daha fazla para ekle.");
                return;
            }

            if (!productStock.AretheyinStock(product))
            {
                Console.WriteLine($"{product} ürünü stokta yok.");
                return;
            }

            totalMoney -= price;
            Console.WriteLine($"{product} ürünü satın alındı. Kalan para: {totalMoney} TL");
            productStock.DropProduct(product); 

            if (specialCampaigns.ContainsKey(product))
            {
                string bedavaUrun = specialCampaigns[product];
                Console.WriteLine($"Özel kampanya: {bedavaUrun} ürünü bedava!");
            }
        }

        public void CancelProduct(string product)
        {
            productCancel.CancelProduct(product, productStock);
            Console.WriteLine($"{product} ürünü iptal edildi.");
        }

        private int GetPrice(string product)
        {
            if (products.ContainsKey(product))
            {
                return products[product];
            }
            return -1; // Ürün mevcut değil
        }

        public void ApplySpecialCampaign(string productPurchased, string freeProduct)
        {
            specialCampaign.ApplyCampaign(productPurchased, freeProduct, specialCampaigns);
        }

        public void MakeaRefund()
        {
            moneyRefund.RefundMoney(totalMoney);
            totalMoney = 0;
        }

        public void MoneyDeposit(int amount)
        {
            depositMoney.MoneyDeposit(amount, totalMoney);
            totalMoney += amount;
        }
    }
}
    
