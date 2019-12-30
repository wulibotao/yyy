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
    public partial class PayHourlyemployee : Form
    {
        public PayHourlyemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            DateTime paydate = Convert.ToDateTime(textpaydate.Text);
            PayrollDatabase pd = new InMemoryPayrollDatabase();
            PaydayTransaction emp = new PaydayTransaction(paydate, pd);
            emp.Execute();
        }
    }
}
