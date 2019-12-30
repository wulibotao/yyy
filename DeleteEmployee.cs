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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteCommissionedEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            DeleteEmployeeTransaction emp = new DeleteEmployeeTransaction(id, pd);
            emp.Execute();
        }
    }
}
