using System;
using System.Collections.Generic;
using System.Text;

namespace bill_Inheritance
{
    class Bill
    {
        //Properties
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        //default constructor
        public Bill()
        {

        }

        public Bill(double SubTotal, double TaxRate)
        {
            this.Subtotal = SubTotal;
            this.TaxRate = TaxRate;
        }

        //virtual method
        public virtual double CalcTotal()
        {
            double totalBill = (Subtotal * (1 + TaxRate));
            return totalBill;
        }
    }
}
