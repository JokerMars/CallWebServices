using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWebServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceSoapClient wwc = new ServiceReference1.ServiceSoapClient();
            MessageBox.Show(wwc.HelloWorld());
            MessageBox.Show(wwc.Add(3, 4).ToString());
        }
    }
}
