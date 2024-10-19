using DesignPattern.BehavioralPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.StrategyPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        // The context allows setting the strategy dynamically
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Use the strategy to process payment
        public void ProcessPayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }

            _paymentStrategy.MakePayment(amount);
        }
    }
}
