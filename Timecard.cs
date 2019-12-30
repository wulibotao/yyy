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
    public partial class Timecard : Form
    {
        public Timecard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textid.Text);
            float hours = float.Parse(texthours.Text);
            DateTime time = Convert.ToDateTime(textdate.Text);
            PayrollDatabase pd = new sytpayrolldatabase();
            TimeCardTransaction emp = new TimeCardTransaction(time, hours, id, pd);
            emp.Execute();
        }

        private void Timecard_Load(object sender, EventArgs e)
        {

        }
    }
}
