using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    public abstract class Client
    {
        public abstract double GetFinalPrice(double basePrice);
        public abstract string GetInsuranceScheme();
        public abstract string GetWarrantyService();
    }
}
