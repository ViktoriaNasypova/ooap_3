using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class FullPaymentFactory : CarFactory
    {
        private static FullPaymentFactory instance;

        private FullPaymentFactory() { }

        public static FullPaymentFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FullPaymentFactory();
                }
                return instance;
            }
        }

        public override Client CreateClient()
        {
            return new FullPaymentClient();
        }
    }

}
