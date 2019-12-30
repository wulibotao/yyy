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
    public partial class CSalariedemployee : Form
    {
        public CSalariedemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            double salary = double.Parse(textsalary.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            ChangeSalariedTransaction emp = new ChangeSalariedTransaction(id, salary, pd);
            emp.Execute();
        }
    }
}
