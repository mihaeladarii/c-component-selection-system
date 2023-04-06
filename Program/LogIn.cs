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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = "a";
            string password = "a";

            if (username == userText.Text && password == passwordText.Text)
            {
                this.Hide();
                InvoiceForm invoice = new InvoiceForm();

                invoice.Show();
            }
            else
            {
                MessageBox.Show("Your username or/and password do not match with our records");
            }
        }
    }
}
