using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class FullPaymentFactory : CarFactory
    {
        public override Client CreateClient()
        {
            return new FullPaymentClient();
        }
    }
}
