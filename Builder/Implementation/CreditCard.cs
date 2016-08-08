using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CreditCard
    {
        public string Id { get; set; }
        public string NameOnCard { get; set; }
        public CreditCardTypes CardType { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
