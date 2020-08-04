using System;

namespace bill_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill regBill = new Bill(15.80, 0.06);
            Pay(regBill);

            TippableBill tipBill = new TippableBill(8.50, 0.06, 2.00);
            Pay(tipBill);

        }

        public static void Pay(Bill myBill)
        {
            Console.WriteLine("$" + myBill.CalcTotal());
        }
    }
}
