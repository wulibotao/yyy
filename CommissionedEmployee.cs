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
    public partial class CommissionedEmployee : Form
    {
        public CommissionedEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            string name = textname.Text;
            string address = textaddress.Text;
            float baserate = float.Parse(textbaseRate.Text);
            float commissionrate = float.Parse(textcommissionRate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            AddCommissionedEmployee emp = new AddCommissionedEmployee(id, name, address, baserate, commissionrate, pd);
            emp.Execute();
        }

        private void CommissionedEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
