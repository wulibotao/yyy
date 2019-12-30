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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int memberid = int.Parse(textid.Text);
            double dues = double.Parse(textdues.Text);
            DateTime date = Convert.ToDateTime(textdate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            ServiceChargeTransaction emp = new ServiceChargeTransaction(memberid, date,dues, pd);
            emp.Execute();
        }
    }
}
