using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsr2.CalculatorSoapClient proxy = new wsr2.CalculatorSoapClient();

            int nr1 = Int32.Parse(textBox1.Text);
            int nr2 = Int32.Parse(textBox2.Text);
            int r = proxy.Add(nr1, nr2);

            label2.Text = "Rezultati:" + r.ToString();
        }
    }
}
