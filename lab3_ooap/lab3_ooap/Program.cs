using System;
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

            // Получаем Singleton экземпляр FullPaymentFactory
            CarFactory factory = FullPaymentFactory.Instance;
            Client client = factory.CreateClient();

            Console.WriteLine("Full Payment Client:");
            Console.WriteLine("Final price: " + client.GetFinalPrice(basePrice));
            Console.WriteLine("Insurance scheme: " + client.GetInsuranceScheme());
            Console.WriteLine("Warranty service: " + client.GetWarrantyService());

            // Получаем Singleton экземпляр CreditFactory
            factory = CreditFactory.Instance;
            client = factory.CreateClient();

            Console.WriteLine("\nCredit Client:");
            Console.WriteLine("Final price: " + client.GetFinalPrice(basePrice));
            Console.WriteLine("Insurance scheme: " + client.GetInsuranceScheme());
            Console.WriteLine("Warranty service: " + client.GetWarrantyService());
        }
    }
}
