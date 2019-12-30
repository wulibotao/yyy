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
    public partial class SalariedEmployee : Form
    {
        public SalariedEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            string name = textname.Text;
            string address = textaddress.Text;
            float salary = float.Parse(textsalary.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            AddSalariedEmployee emp = new AddSalariedEmployee(id, name, address, salary, pd);
            emp.Execute();
        }

        private void SalariedEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
