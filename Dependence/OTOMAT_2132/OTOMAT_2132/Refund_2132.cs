using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class Refund_2132
    {
        public void RefundMoney(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Para iadesi yapılıyor: {amount} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye.Para iadesi yapılamaz.");
            }
        }
    }
}
