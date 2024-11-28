using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class FullPaymentClient : Client
    {
        public override double GetFinalPrice(double basePrice)
        {
            return basePrice * 0.95; // 5% знижка
        }

        public override string GetInsuranceScheme()
        {
            return "Full insurance for 1 year";
        }

        public override string GetWarrantyService()
        {
            return "3 years full warranty";
        }
    }
}