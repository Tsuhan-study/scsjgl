using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maticsoft.Model;
using Maticsoft.BLL;

namespace scsjgl
{
    public partial class Select : Form
    {
       Maticsoft.BLL.tsuhan_test_c c=new Maticsoft.BLL.tsuhan_test_c();
        public Select()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //取消自动添加行
            this.dgvShow.AutoGenerateColumns = false;
            var cbm1 = this.comboBox1.Text.Trim();
            //var cbm2 = this.tbBhdh.Text.Trim();
            DataSet ds = c.QuerySelect(cbm1);
            this.dgvShow.DataSource = ds.Tables[0];
        }
    }
}
