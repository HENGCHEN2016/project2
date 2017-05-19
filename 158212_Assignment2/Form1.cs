using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fromCurrency = "";
        string toCurrency = "";
        double amount = 0;
        bool isConverted = true;
         double ConvertMoney(double amount, string fromCurrency, string toCurrency)
        {
            double tempUSD = 0;
            double result = 0;
            // Convert to USD no matter what currency is
            switch (fromCurrency)
            {
                case "AUD":
                    tempUSD = amount / 1.31;
                    break;

                case "NZD":
                    tempUSD = amount / 1.36;
                    break;

                case "CAD":
                    tempUSD = amount / 1.28;
                    break;

                case "EUR":
                    tempUSD = amount / 0.95;
                    break;

                case "GBP":
                    tempUSD = amount / 0.68;
                    break;

                case "USD":
                    tempUSD = amount;
                    break;
            }
            switch (toCurrency)
            {
                case "AUD":
                    result = tempUSD * 1.31;
                    break;

                case "NZD":
                    result = tempUSD * 1.36;
                    break;

                case "CAD":
                    result = tempUSD * 1.28;
                    break;

                case "EUR":
                    result = tempUSD * 0.95;
                    break;

                case "GBP":
                    result = tempUSD * 0.68;
                    break;

                case "USD":
                    result = tempUSD;
                    break;
            }
            return result;
        }
        private void CF_NZD_button_Click(object sender, EventArgs e)
        {    
            fromCurrency = "NZD";
            DisplayFrom_label.Text = "NZD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CF_AUD_button_Click(object sender, EventArgs e)
        {
            fromCurrency = "AUD";
            DisplayFrom_label.Text = "AUD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }
        }

        private void CF_EUR_button_Click(object sender, EventArgs e)
        {
            fromCurrency = "EUR";
            DisplayFrom_label.Text = "EUR";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }
        }

        private void CF_CAD_button_Click(object sender, EventArgs e)
        {
            fromCurrency = "CAD";
            DisplayFrom_label.Text = "CAD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CF_GBP_button_Click(object sender, EventArgs e)
        {
            fromCurrency = "GBP";
            DisplayFrom_label.Text = "GBP";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CF_USD_button_Click(object sender, EventArgs e)
        {
            fromCurrency = "USD";
            DisplayFrom_label.Text = "USD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_NZD_button_Click(object sender, EventArgs e)
        {
            toCurrency = "NZD";
            DisplayTo_label.Text = "NZD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_AUD_button_Click(object sender, EventArgs e)
        {
            toCurrency = "AUD";
            DisplayTo_label.Text = "AUD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_EUR_button_Click(object sender, EventArgs e)
        {
            toCurrency = "EUR";
            DisplayTo_label.Text = "EUR";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_CAD_button_Click(object sender, EventArgs e)
        {
            toCurrency = "CAD";
            DisplayTo_label.Text = "CAD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_GBP_button_Click(object sender, EventArgs e)
        {
            toCurrency = "GBP";
            DisplayTo_label.Text = "GBP";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void CT_USD_button_Click(object sender, EventArgs e)
        {
            toCurrency = "USD";
            DisplayTo_label.Text = "USD";
            if (Amount_textbox.Text != "" && DisplayFrom_label.Text != "" && DisplayTo_label.Text != "" && Display_label.Text != "")
            {
                string num = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
                Display_label.Text = num;
            }

        }

        private void Amount_textbox_TextChanged(object sender, EventArgs e)
        {
            isConverted = double.TryParse(Amount_textbox.Text, out amount);
            if (!isConverted)
            {
                Convert_button.Enabled = false;
            } else
            {
                Convert_button.Enabled = true;
            }
        }
        private void Convert_button_Click(object sender, EventArgs e)
        {
            Display_label.Text = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
        }
        private void Reset_button_Click(object sender, EventArgs e)
        {
            Amount_textbox.Text=null;
            DisplayFrom_label.Text="________";
            DisplayTo_label.Text  ="________";
            Display_label.Text    ="________";
        }

        private void DisplayFrom_label_Click(object sender, EventArgs e)
        {
            Display_label.Text = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
        }

        private void DisplayTo_label_Click(object sender, EventArgs e)
        {
            Display_label.Text = Convert.ToString(ConvertMoney(amount, fromCurrency, toCurrency));
        }
    }
}
