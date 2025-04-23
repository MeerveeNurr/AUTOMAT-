using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUOTOMAT_2132
{
    internal class Customer_2132
    {
      
        public string cardnumber;
        public string password;
        public int remainder = 0;
        public Customer_2132( String password, string cardnumber)
        {
           
            this.password = password;
            this.cardnumber = cardnumber;
        }

    }
}

