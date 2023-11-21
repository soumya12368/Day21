using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_Part2
{
    internal class HerbalProduct:Product
    {
        string herbsUsed;
        DateTime mfDate;
        DateTime expDate;
        public HerbalProduct()
        {
            Console.WriteLine("Herbal Constructor");
            herbsUsed = "no herbs";
            mfDate = DateTime.MinValue;
            expDate = DateTime.MinValue;
        }

        public override void Set()
        {
            base.Set();
            Console.WriteLine("Enter Herbs Used");
            herbsUsed = Console.ReadLine();
            Console.WriteLine("Enter Mfg Date");
            mfDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Exp Date");
            expDate = DateTime.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Herbs Used: " + herbsUsed);
            Console.WriteLine("Manufacturing Date: " + mfDate.ToShortDateString());
            Console.WriteLine("Expiry Date: " + expDate.ToShortDateString());
        }
    }
}
