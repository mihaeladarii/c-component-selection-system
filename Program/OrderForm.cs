using Program.Properties;

namespace Program
{
    public partial class OrderForm : Form
    {

        Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            {"Desktop", 35 },
            {"Tower", 30 },
            {"Gaming", 110 },
            {"Intel", 550 },
            {"AMD", 440 },
            {"4GB", 14 },
            {"8GB", 20 },
            {"16GB", 40 },
            {"1TB", 33 },
            {"2TB", 45 },
            {"4TB", 75 },
            {"256GB", 35 },
            {"512GB", 60 },
            {"400W", 40 },
            {"600W", 55 },
            {"800W", 80 }
        };

        Dictionary<string, string> groupBoxCurrentSelected = new Dictionary<string, string>()
        {
            {"CaseGroupBox", "" },
            {"MBGroupBox", "" },
            {"RAMGroupBox", "" },
            {"HDDGroupBox", "" },
            {"PSUGroupBox", "" },
            {"SSDGroupBox", "" }
        };

        static public int finalPrice = 0;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void DesktopRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Desktop", DesktopRadio);
            CasesPictureBox.Image = Resources.Desktop;
            CaseCost.Text = "£" + prices["Desktop"];

        }

        private void TowerRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Tower", TowerRadio);
            CasesPictureBox.Image = Resources.Tower;
            CaseCost.Text = "£" + prices["Tower"];
        }

        private void GamingRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Gaming", GamingRadio);
            CasesPictureBox.Image = Resources.Gaming;
            CaseCost.Text = "£" + prices["Gaming"];
        }

        private void AMDRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("AMD", AMDRadio);
            MBPictureBox.Image = Resources.AMD;
            MBCost.Text = "£" + prices["AMD"];
        }

        private void IntelRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Intel", IntelRadio);
            MBPictureBox.Image = Resources.Intel;
            MBCost.Text = "£" + prices["Intel"];
        }

        private void Radio4GB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("4GB", Radio4GB);
            RAMPictureBox.Image = Resources._4GB;
            RAMCost.Text = "£" + prices["4GB"];
        }

        private void Radio8GB_CheckedChanged(object sender, EventArgs e)
        {
            RAMPictureBox.Image = Resources._8GB;
            updatePrice("8GB", Radio8GB);
            RAMCost.Text = "£" + prices["8GB"];
        }

        private void Radio16GB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("16GB", Radio16GB);
            RAMPictureBox.Image = Resources._16GB;
            RAMCost.Text = "£" + prices["16GB"];
        }

        private void Radio1TB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("1TB", Radio1TB);
            HDDpictureBox.Image = Resources._1TB;
            HDDCost.Text = "£" + prices["1TB"];
        }

        private void Radio2TB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("2TB", Radio2TB);
            HDDpictureBox.Image = Resources._2TB;
            HDDCost.Text = "£" + prices["2TB"];
        }

        private void Radio4TB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("4TB", Radio4TB);
            HDDpictureBox.Image = Resources._4TB;
            HDDCost.Text = "£" + prices["4TB"];
        }

        private void Radio400W_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("400W", Radio400W);
            PSUpictureBox.Image = Resources._400W;
            PSUCost.Text = "£" + prices["400W"];
        }

        private void Radio600W_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("600W", Radio600W);
            PSUpictureBox.Image = Resources._600W;
            PSUCost.Text = "£" + prices["600W"];
        }

        private void Radio800W_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("800W", Radio800W);
            PSUpictureBox.Image = Resources._850W;
            PSUCost.Text = "£" + prices["800W"];
        }

        private void Radio256GB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("256GB", Radio256GB);
            SSDpictureBox.Image = Resources._256GB;
            SSDCost.Text = "£" + prices["256GB"];
        }

        private void Radio512GB_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("512GB", Radio512GB);
            SSDpictureBox.Image = Resources._512GB;
            SSDCost.Text = "£" + prices["512GB"];
        }




        void updatePrice(string name, RadioButton button)
        {
            //Get the groupBox from the button
            GroupBox groupBox = button.Parent as GroupBox;
            //Get the groupBox name
            string groupName = groupBox.Name;

            //Set groupBox selected from dictinoary
            string currentSelection = groupBoxCurrentSelected[groupName];

            if (button.Checked)
            {
                if (currentSelection != name)
                {
                    finalPrice += prices[$"{name}"];
                }
                groupBoxCurrentSelected[groupName] = name;
            }
            else
            {
                if (currentSelection == name)
                {
                    finalPrice -= prices[$"{name}"];
                }
                groupBoxCurrentSelected[groupName] = "";
            }

            FinalPriceLabel.Text = "£" + finalPrice.ToString();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();
            //create object form from invoice form
            LogIn login = new LogIn();
            //show the new object form
            login.Show();
        }
    }
}