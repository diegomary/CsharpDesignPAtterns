using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public  class GiftCreditCardBuilder : ICreditCardBuilder
    {
        public readonly CreditCard _card = new CreditCard();
        public void SetId(string id)
        {
            _card.Id = id;
        }

        public void SetNameOnCArd(string name)
        {
            _card.NameOnCard = name;
        }

        public void SetType()
        {
            _card.CardType = CreditCardTypes.GiftCard;
        }

        public void SetExpirationDate(DateTime expDate)
        {
            _card.ExpirationDate = expDate;
        }

        public CreditCard GetCreditCard()
        {
            return _card;
        }

    }

}
