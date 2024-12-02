using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ooap
{
    internal class InstallmentFactory : CarFactory
    {
        private static InstallmentFactory instance;

        private InstallmentFactory() { }

        public static InstallmentFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InstallmentFactory();
                }
                return instance;
            }
        }

        public override Client CreateClient()
        {
            return new InstallmentClient();
        }
    }

}
