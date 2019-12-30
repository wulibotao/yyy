using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
namespace WindowsFormsApplication1
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlCeDataAdapter dapt;
        private void DataBind()
        {
            string connString = @"Data Source=E:\微信\WeChat Files\wxid_g4badj1jvdlg21\FileStorage\File\2019-12\Payroll\Payroll\Database1.sdf";
            SqlCeConnection connection = new System.Data.SqlServerCe.SqlCeConnection(connString);
            connection.Open();
            string sqlStr = " select * from payemployee";
            SqlCeCommand cmd = new SqlCeCommand(sqlStr, connection);
            dapt = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            dapt.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void bill_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
