using System;
using System.Collections.Generic;
using System.Text;

namespace bill_Inheritance
{
    class TippableBill : Bill
    {
        //Properties
        public double Tip { get; set; }

        //Constructors
        public TippableBill()
        {

        }
        public TippableBill(double SubTotal, double TaxRate, double Tip) :base(SubTotal, TaxRate)
        {
            this.Tip = Tip;
        }

        public override double CalcTotal()
        {
            //double tippedBill = Tip + base.CalcTotal();
            //return tippedBill;
            return base.CalcTotal() + Tip;
        }
    }
}
