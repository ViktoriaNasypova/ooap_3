using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class CreditFactory : CarFactory
    {
        private static CreditFactory instance;

        private CreditFactory() { }

        public static CreditFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreditFactory();
                }
                return instance;
            }
        }

        public override Client CreateClient()
        {
            return new CreditClient();
        }
    }
}
