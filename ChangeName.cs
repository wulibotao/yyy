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
    public partial class ChangeName : Form
    {
        public ChangeName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            string name = textname.Text;
            PayrollDatabase pd = new sytpayrolldatabase();
            ChangeNameTransaction emp = new ChangeNameTransaction(id,name,pd);
            emp.Execute();
        }
    }
}
