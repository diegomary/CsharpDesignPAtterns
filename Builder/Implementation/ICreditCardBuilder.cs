using System;

namespace Builder
{
 public interface ICreditCardBuilder
    {
        CreditCard GetCreditCard();
        void SetExpirationDate(DateTime expDate);
        void SetId(string id);
        void SetNameOnCArd(string name);
        void SetType();
    }
}