using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Salesreceipt : Form
    {
        public Salesreceipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            double saleAmount = double.Parse(textsaleAmount.Text);
            DateTime time = Convert.ToDateTime(textdate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            SalesReceiptTransaction emp = new SalesReceiptTransaction(time, saleAmount, id, pd);
            emp.Execute();
        }
    }
}
