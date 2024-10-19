﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.Strategy
{
    public interface IPaymentStrategy
    {
        void MakePayment(decimal amount);
    }
}
