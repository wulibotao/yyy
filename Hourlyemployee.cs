using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Payroll;
namespace Payroll
{
    public partial class Hourlyemployee : Form
    {
        public Hourlyemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            string name = textname.Text;
            string address = textaddress.Text;
            float rate = float.Parse(textrate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            AddHourlyEmployee emp = new AddHourlyEmployee(id, name, address, rate, pd);
            emp.Execute();
        }

        private void Hourlyemployee_Load(object sender, EventArgs e)
        {

        }
    }
}
