using DesignPattern.BehavioralPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.StrategyPattern
{
    [TestClass]
    public class CheckoutPage
    {
        [TestMethod]
        public void CheckoutSplitPayment()
        {
            PaymentContext paymentContext = new PaymentContext();

            paymentContext.SetPaymentStrategy(new CreditCardPayment());
            paymentContext.ProcessPayment(10.50m);

            paymentContext.SetPaymentStrategy(new PayPalPayment());
            paymentContext.ProcessPayment(10.50m);

            paymentContext.SetPaymentStrategy(new BitcoinPayment());
            paymentContext.ProcessPayment(10.50m);
        }
    }
}
