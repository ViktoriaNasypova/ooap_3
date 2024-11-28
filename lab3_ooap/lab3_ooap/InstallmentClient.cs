using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class InstallmentClient : Client
    {
        public override double GetFinalPrice(double basePrice)
        {
            return basePrice * 1.05; // 5% націнка
        }

        public override string GetInsuranceScheme()
        {
            return "Basic insurance for 3 years";
        }

        public override string GetWarrantyService()
        {
            return "1 year limited warranty";
        }
    }
}
