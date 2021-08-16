using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_2.Services
{
    class PaypalService : IPaymentService
    {
        private const double PercentageFee = 0.02;
        private const double MonthlyFee = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyFee * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * PercentageFee;
        }
    }
}
