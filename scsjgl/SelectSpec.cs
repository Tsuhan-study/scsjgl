using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Maticsoft.Model;

namespace scsjgl
{
    public partial class SelectSpec : Form
    {

        SpecBLL specBll = new SpecBLL();
        public SelectSpec()
        {
            InitializeComponent();
        }

        private void SelectSpec_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = true;
            DataSet ds = specBll.Query();
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
