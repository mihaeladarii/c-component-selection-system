using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        double finalPrice;
        int buildPrice;

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            buildPrice = OrderForm.finalPrice;
            unitPriceLabel.Text = "Price per Unit: £"+buildPrice.ToString("0.##");

            double priceWithVat = buildPrice * 1.2;
            FinalPriceLabel.Text = "Final Price: £" + priceWithVat.ToString("0.##");
            vatLabel.Text = "VAT(20%): £" + (buildPrice * 0.2).ToString("0.##");
            DepositLabel.Text = "Deposit 10%: £" + (buildPrice * 0.1).ToString("0.##");
            remLabel.Text = "Remaining: £" + (priceWithVat - (buildPrice * 0.2)).ToString("0.##");
        }

        private void unitNoText_TextChanged(object sender, EventArgs e)
        {
            double quantity, quantityWithPrice, vat;

            if (!double.TryParse(unitNoText.Text, out quantity))
            {
                MessageBox.Show("Please only enter numbers!!!!");
            }

            quantityWithPrice = buildPrice* quantity;
            vat = quantityWithPrice * 0.2;
         

            vatLabel.Text = "VAT(20%): £" + vat.ToString("0.##");
            finalPrice = vat + quantityWithPrice;
            DepositLabel.Text = "Deposit 10%: £" + (finalPrice * 0.1).ToString("0.##") ;
            FinalPriceLabel.Text = "Final Price: £" + finalPrice.ToString("0.##") ;
            remLabel.Text = "Remaining: £" + (finalPrice - (finalPrice * 0.1)).ToString("0.##");

        }

        private void changeBuildBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm.finalPrice = 0;

            OrderForm back = new OrderForm();   
            back.Show();
        }
    }
}
