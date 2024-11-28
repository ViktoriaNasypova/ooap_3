using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_ooap
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            double basePrice = 10000;

            CarFactory factory = new FullPaymentFactory();
            Client client = factory.CreateClient();

            Console.WriteLine("Final price: " + client.GetFinalPrice(basePrice));
            Console.WriteLine("Insurance scheme: " + client.GetInsuranceScheme());
            Console.WriteLine("Warranty service: " + client.GetWarrantyService());

            factory = new CreditFactory();
            client = factory.CreateClient();

            Console.WriteLine("\nCredit client:");
            Console.WriteLine("Final price: " + client.GetFinalPrice(basePrice));
            Console.WriteLine("Insurance scheme: " + client.GetInsuranceScheme());
            Console.WriteLine("Warranty service: " + client.GetWarrantyService());
        }
    }
}
