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
    public partial class CHourlyemployee : Form
    {
        public CHourlyemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            double rate = double.Parse(textrate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            ChangeHourlyTransaction emp = new ChangeHourlyTransaction(id, rate, pd);
            emp.Execute();
        }
    }
}
