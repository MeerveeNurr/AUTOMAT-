using System;
using System.Collections.Generic;

namespace AUOTOMAT_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat_2132 automat = new Automat_2132();
            automat.AddMoney(50);


            automat.SelectProduct("Kola");
            for (int i = 0; i < 6; i++)
            {
                automat.SelectProduct("Kek"); 
            }
            automat.CancelProduct("Kola"); 
            automat.SelectProduct("Kola"); 
            automat.SelectProduct("Çay");

            
            automat.ApplySpecialCampaign("Kola", "Su");

            automat.AddMoney(1); 
            automat.SelectProduct("Su"); 

            automat.AddMoney(20);
            automat.SelectProduct("Soğuk Kahve");
            automat.MakeaRefund();
            automat.SelectProduct("Sakız");
        }
    }
}