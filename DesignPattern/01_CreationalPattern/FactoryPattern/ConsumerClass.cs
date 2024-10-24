using DatastructureMSTest.DesignPattern.CreationalPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.DesignPattern._01_CreationalPattern.FactoryPattern
{
    [TestClass]
    public class ConsumerClass
    {
        [TestMethod]
        public void pay()
        {
            // Client decides which card type to create at runtime
            Console.WriteLine("Enter the type of card (gold/platinum): ");
            string cardType = Console.ReadLine();

            // Get the appropriate card using the factory
            ICreditCard card = CreditCardFactory.GetCreditCard(cardType);

            Console.WriteLine($"Card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit Limit: {card.GetCreditLimit()}");
            Console.WriteLine($"Annual Charge: {card.GetAnnualCharge()}");
        }
    }
}
