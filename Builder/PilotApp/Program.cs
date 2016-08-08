using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Builder;

namespace PilotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardsProducer cp = new CreditCardsProducer();
            CreditCard resultCard=   cp.CreditCardMaker(new PrepaidWithIbanCreditCardBuilder());          

        }
    }
}
