using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class CreditClient : Client
    {
        public override double GetFinalPrice(double basePrice)
        {
            return basePrice;
        }

        public override string GetInsuranceScheme()
        {
            return "Partial insurance for 2 years";
        }

        public override string GetWarrantyService()
        {
            return "2 years limited warranty";
        }
    }
}
