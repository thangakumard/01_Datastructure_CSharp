using DesignPattern.BehavioralPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.StrategyPattern
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
