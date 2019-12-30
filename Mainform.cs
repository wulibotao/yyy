using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
namespace Payroll
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void 钟点工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hourlyemployee f = new Hourlyemployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 正常雇员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalariedEmployee f = new SalariedEmployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 带薪雇员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommissionedEmployee f = new CommissionedEmployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }
               
        private void 删除雇员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee f = new DeleteEmployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e) //显示员工信息
        {
            string connString = @"Data Source=E:\微信\WeChat Files\wxid_g4badj1jvdlg21\FileStorage\File\2019-12\Payroll\Payroll\Database1.sdf";
            SqlCeConnection connection = new SqlCeConnection(connString);
            connection.Open();

            string sqlStr = "select * from CommissionedEmployee";
            DataSet dataSet = new DataSet();
            SqlCeDataAdapter sqldata = new SqlCeDataAdapter(sqlStr, connString);
            sqldata.Fill(dataSet, "CommissionedEmployee");
            DataView dataView = new DataView(dataSet.Tables["CommissionedEmployee"]);
            dataGridView1.DataSource = dataView;

            string sqlStr2 = "select * from Hourlyemployee";
            DataSet dataSet2 = new DataSet();
            SqlCeDataAdapter sqldata2 = new SqlCeDataAdapter(sqlStr2, connString);
            sqldata2.Fill(dataSet2, "Hourlyemployee");
            DataView dataView2 = new DataView(dataSet2.Tables["Hourlyemployee"]);
            dataGridView2.DataSource = dataView2;

            string sqlStr3 = "select * from SalariedEmployee";
            DataSet dataSet3 = new DataSet();
            SqlCeDataAdapter sqldata3 = new SqlCeDataAdapter(sqlStr3, connString);
            sqldata3.Fill(dataSet3, "SalariedEmployee");
            DataView dataView3 = new DataView(dataSet3.Tables["SalariedEmployee"]);
            dataGridView3.DataSource = dataView3;

            string sqlStr4 = "select * from TimeCardtable";
            DataSet dataSet4 = new DataSet();
            SqlCeDataAdapter sqldata4 = new SqlCeDataAdapter(sqlStr4, connString);
            sqldata4.Fill(dataSet4, "TimeCardtable");
            DataView dataView4 = new DataView(dataSet4.Tables["TimeCardtable"]);
            dataGridView4.DataSource = dataView4;

            string sqlStr5 = "select * from SalesReceipttable";
            DataSet dataSet5 = new DataSet();
            SqlCeDataAdapter sqldata5 = new SqlCeDataAdapter(sqlStr5, connString);
            sqldata5.Fill(dataSet5, "SalesReceipttable");
            DataView dataView5 = new DataView(dataSet5.Tables["SalesReceipttable"]);
            dataGridView5.DataSource = dataView5;
            connection.Close();

            connection.Close();
        }

        private void 人员查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timecard f = new Timecard();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salesreceipt f = new Salesreceipt();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 正常员工ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CSalariedemployee f = new CSalariedemployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 带薪员工ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CCommissionedEmployee f = new CCommissionedEmployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
        private void 更改姓名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeName f = new ChangeName();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 钟点工ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHourlyemployee f = new CHourlyemployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 正常员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSalariedemployee f = new CSalariedemployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 带薪员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCommissionedEmployee f = new CCommissionedEmployee();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
