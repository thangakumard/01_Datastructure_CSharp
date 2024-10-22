using DesignPattern.BehavioralPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.StrategyPattern
{
    /**
     * Strategy (Interface): Declares a method (or methods) that all concrete strategies must implement.
        Concrete Strategies: Implement the algorithm defined in the strategy interface.
        Context: The class that uses a strategy object, and the strategy can be changed at runtime.
     */
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
