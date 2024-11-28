using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_ooap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Зчитуємо базову ціну
            double basePrice;
            if (!double.TryParse(txtBasePrice.Text, out basePrice))
            {
                MessageBox.Show("Будь ласка, введіть коректну базову ціну.");
                return;
            }

            // Визначаємо тип клієнта за вибором радіо-кнопок
            CarFactory factory = null;

            if (rbtnFullPayment.Checked)
            {
                factory = new FullPaymentFactory();
            }
            else if (rbtnCredit.Checked)
            {
                factory = new CreditFactory();
            }
            else if (rbtnInstallment.Checked)
            {
                factory = new InstallmentFactory();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть варіант оплати.");
                return;
            }

            // Створюємо клієнта через фабрику
            Client client = factory.CreateClient();

            // Отримуємо кінцеву ціну, страхову схему та гарантійне обслуговування
            double finalPrice = client.GetFinalPrice(basePrice);
            string insuranceScheme = client.GetInsuranceScheme();
            string warrantyService = client.GetWarrantyService();

            // Виводимо результати у відповідні текстові поля
            txtFinalPrice.Text = finalPrice.ToString("F2");  // Відображення з двома десятковими знаками
            txtInsurance.Text = insuranceScheme;
            txtWarranty.Text = warrantyService;
        }
    }
}
