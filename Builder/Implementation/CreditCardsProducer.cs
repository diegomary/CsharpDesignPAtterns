using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class CreditCardsProducer
    {
        public CreditCard CreditCardMaker(ICreditCardBuilder ib)
        {
            ib.SetId("Prepaid");
            ib.SetNameOnCArd("Diego");
            ib.SetType();
            ib.SetExpirationDate(System.DateTime.Now.AddYears(5));
            return ib.GetCreditCard();

        }

    }
}
