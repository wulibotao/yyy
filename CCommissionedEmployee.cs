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
    public partial class CCommissionedEmployee : Form
    {
        public CCommissionedEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            double baseRate = double.Parse(textbaseRate.Text);
            double commissionRate = double.Parse(textcommissionRate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            ChangeCommissionedTransaction pt = new ChangeCommissionedTransaction(id, baseRate, commissionRate, pd);
            pt.Execute();
        }
    }
}
