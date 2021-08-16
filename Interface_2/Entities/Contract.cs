﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }
    }
}
