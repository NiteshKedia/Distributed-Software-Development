using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSODWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //function to load webpage on button click
        private void button1_Click(object sender, EventArgs e)
        {
            String WebAddress = textURL.Text.Trim();
            webBrowser1.Navigate(WebAddress);
        }

        //function to load web page on press of enter
        private void textURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                String WebAddress = textURL.Text.Trim();
                webBrowser1.Navigate(WebAddress);
            }
        }

        //function to load stock symbol on button click
        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
            String sym = StockSymbol.Text;
            if (sym != "")
            {
                String SymResult = sc.getStockquote(sym);
                if (Convert.ToDouble(SymResult) == 0.00)
                    label2.Text = "Please Enter a Valid Symbol";
                else
                    label2.Text = SymResult;
            }
            else
                label2.Text = "Please Enter a Symbol";
            
        }

        //function to load stock symbol on Enter
        private void StockSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
                String sym = StockSymbol.Text;
                if (sym != "")
                {
                    String SymResult = sc.getStockquote(sym);
                    if (Convert.ToDouble(SymResult) == 0.00)
                        label2.Text = "Please Enter a Valid Symbol";
                    else
                        label2.Text = SymResult;
                }
                else
                    label2.Text = "Please Enter a Symbol";
            }

        }

        //function for currency conversion obn button click
        private void button3_Click(object sender, EventArgs e)
        {
            String fromcur = textBox1.Text;
            String tocur =  textBox2.Text;

            try
            {
                ServiceReference3.Currency fromCurrency = (ServiceReference3.Currency)Enum.Parse(typeof(ServiceReference3.Currency), fromcur);
                ServiceReference3.Currency toCurrency = (ServiceReference3.Currency)Enum.Parse(typeof(ServiceReference3.Currency), tocur);
                ServiceReference3.CurrencyConvertorSoapClient sc = new ServiceReference3.CurrencyConvertorSoapClient("CurrencyConvertorSoap");
                double conversionRate = sc.ConversionRate(fromCurrency, toCurrency);
                label5.Text = conversionRate.ToString();
            }
            catch (Exception ex)
            {
                label5.Text = "Please Enter a Valid Currency Symbol";
                Console.WriteLine(ex.Message);
            }
            
            
        }

        

      
       
    }
}
