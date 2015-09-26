using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop;

using EXCEL = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

using BLL;
using Maticsoft.Model;
using System.IO;
using System.Text.RegularExpressions;

namespace scsjgl
{
    public partial class DaoGLM : Form
    {
        public DaoGLM()
        {
            InitializeComponent();
        }
        FanXiuBLL fxBLL = new FanXiuBLL();

        EXCEL.Application excel = null;
        private void DaoGLM_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.AutoGenerateColumns = false;
            //DataSet ds = fxBLL.GetFXtable();
            //this.dataGridView1.DataSource = ds.Tables[0];
            this.textBox1.Text = DateTime.Now.ToString("yyyy-M-d HH:mm");
            this.textBox2.Text = DateTime.Now.ToString("yyyy-M-d HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                //没有数据的话就不往下执行
                if (dataGridView1.Rows.Count == 0)
                    return;
                // Excel.ApplicationClass oExcel = new Excel.ApplicationClass();
                excel = new EXCEL.Application();
                //让后台执行设置为不可见，为true的话会看到打开一个Excel，然后数据在往里写  
                excel.Visible = false;
                Workbook wbook = excel.Workbooks.Add(true);
                //Worksheet wsheet = wbook.Worksheets[1] as Worksheet;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dataGridView1[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                        }
                    }
                }
                string filepath = @"e:\FanXiu_EXCEL.xls";
                if (System.IO.File.Exists(filepath))
                {
                    var d = MessageBox.Show("FanXiu_EXCEL工作薄已存在,是否覆盖????", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        File.Delete(@"e:\FanXiu_EXCEL.xls");
                        excel.DisplayAlerts = false;
                        excel.AlertBeforeOverwriting = false;

                        //保存工作簿   
                        excel.Application.Workbooks.Add(true).Save();
                        //保存excel文件   
                        wbook.SaveCopyAs("e:" + "\\FanXiu_EXCEL.xls");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    //设置禁止弹出保存和覆盖的询问提示框 
                    excel.DisplayAlerts = false;
                    excel.AlertBeforeOverwriting = false;

                    //保存工作簿   
                    excel.Application.Workbooks.Add(true).Save();
                    wbook.SaveCopyAs("e:" + "\\FanXiu_EXCEL.xls");
                }




                //确保Excel进程关闭   
                excel.Quit();
                excel = null;
                MessageBox.Show("导出成功", "提示");
            }
            catch
            {

                MessageBox.Show("导出失败", "错误提示");
            }

            #endregion
        }
        
        /// <summary>
        /// 根据日期查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var time1 = this.textBox1.Text;
            var time2 = this.textBox2.Text;
            //时间正则表达式
            string reg = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d$";
            Match m = Regex.Match(time1, reg);
            Match m1 = Regex.Match(time2, reg);
            if (m.Success == false)
            {
                MessageBox.Show("时间格式输入错误.如[2015-05-15 00:00]", "提示");
                return;
            }
            if (m1.Success == false)
            {
                MessageBox.Show("时间格式输入错误.如[2015-05-15 00:00]", "提示");
                return;
            }
            time1 = Convert.ToDateTime(time1).ToString("yyyy-M-d HH:mm");
            time2 = Convert.ToDateTime(time2).ToString("yyyy-M-d HH:mm");
            this.dataGridView1.AutoGenerateColumns = false;
            if (time1 != null && time2 != null)
            {
                DataSet ds = fxBLL.GetSelectTime(time1, time2);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                DataSet ds = fxBLL.GetFXtable();
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            
        }
    }
}
