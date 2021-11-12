using _1029.Entities;
using _1029.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1029
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        { 
            InitializeComponent();
            WebCall();
            dataGridView1.DataSource = Rates;
        }

        void WebCall()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }

        void useXML()
        {

        }
    }
}
