using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Maticsoft.Model;
using System.Configuration;
using System.Text.RegularExpressions;
using BLL;

using Microsoft.Office.Interop;

using EXCEL = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;



namespace scsjgl
{
    public partial class Rk : Form
    {
       // private EXCEL.Application excel;
        RkBLL rkbll = new RkBLL();
        EXCEL.Application excel = null;

        public Rk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(Form1_Closing);
            tbTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbtime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btnExSel.Enabled = false;
            btnDao.Enabled = false;

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //取消自动添加行
            this.dgvShow.AutoGenerateColumns = false;
            this.tbAllNum.Enabled = false;
            var danhao = this.tbBhdh.Text.Trim().ToString();
            var time = this.tbTime.Text;
            var time1 = this.tbtime2.Text;
            //时间正则表达式
            string reg = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$";
            if (time == "" && danhao == "" && time1 == "")
            {
                MessageBox.Show("请选择一个条件输入", "提示");
                return;
            }
            else
            {


                Match m = Regex.Match(tbTime.Text, reg);
                Match m1 = Regex.Match(tbtime2.Text, reg);
               
                if (time == "" && time1 == "")
                {
                    time = string.Empty;
                    time1 = string.Empty;
                }
                else if (time != "" && time1 == "")
                {
                    if (m.Success == false)
                    {
                        MessageBox.Show("时间格式输入错误.如[2015-5-5]", "提示");
                        return;
                    }
                    time1 = string.Empty;
                    time = Convert.ToDateTime(this.tbTime.Text).ToString("yyyy-M-d");
                }
                else if (time == "" && time1 != "")
                {
                       
                    if (m1.Success == false)
                    {
                        MessageBox.Show("时间格式输入错误.如[2015-05-05]", "提示");
                        return;
                    }
                    time = string.Empty;
                    time1 = Convert.ToDateTime(this.tbtime2.Text).ToString("yyyy-M-d");
                }
                else if (time != "" && time1 != "")
                {
                    if (m1.Success == false || m.Success == false)
                    {
                        MessageBox.Show("时间格式输入错误.如[2015-05-05]", "提示");
                        return;
                    }
                    //string tb = modelgt.表格编号;
                    //string[] tbbgbh = tb.Split(new char[1] { '-' });
                    string t1 = this.tbTime.Text;
                    string[] tim1=t1.Split(new char[2]{'-','-'});
                    string t2 = this.tbtime2.Text;
                    string[] tim2 = t2.Split(new char[2] { '-', '-' });
                    if (Convert.ToInt32(tim1[2]) <= Convert.ToInt32(tim2[2]))
                    {
                        time = Convert.ToDateTime(this.tbTime.Text).ToString("yyyy-M-d");
                        time1 = Convert.ToDateTime(this.tbtime2.Text).ToString("yyyy-M-d");
                    }
                    else
                    {
                        MessageBox.Show("前一个日期大于后一个日期","提示");
                    }
                }
                
            }
            DataSet ds = rkbll.QueryRks(danhao, time,time1);
            //求和
            this.dgvShow.DataSource =ds.Tables[0];
            int allnum=0;
            for (int i = 0; i < dgvShow.RowCount; i++)
            {
                if (!dgvShow.Rows[i].IsNewRow)
                {
                    allnum = allnum + int.Parse(dgvShow[2, i].Value.ToString());
                }
                this.tbAllNum.Text = Convert.ToString(allnum);
            }
           
            btnDao.Enabled = true;
        }

        /// <summary>
        /// Excel数据导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDao_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                //没有数据的话就不往下执行
                if (dgvShow.Rows.Count == 0)
                    return;
               // Excel.ApplicationClass oExcel = new Excel.ApplicationClass();
                excel = new EXCEL.Application();
                //让后台执行设置为不可见，为true的话会看到打开一个Excel，然后数据在往里写  
                excel.Visible = false;
                Workbook wbook = excel.Workbooks.Add(true);
                //Worksheet wsheet = wbook.Worksheets[1] as Worksheet;
                for (int i = 0; i < dgvShow.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dgvShow.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvShow.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvShow.Columns.Count; j++)
                    {
                        if (dgvShow[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dgvShow[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dgvShow[j, i].Value.ToString();
                        }
                    }
                }
                string filepath = @"e:\RK_EXCEL.xls";
                if (System.IO.File.Exists(filepath))
                {
                   var d= MessageBox.Show("RK_EXCEL工作薄已存在,是否覆盖????","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                   if (d == DialogResult.Yes)
                   {
                       File.Delete(@"e:\RK_EXCEL.xls");
                       excel.DisplayAlerts = false;
                       excel.AlertBeforeOverwriting = false;

                       //保存工作簿   
                       excel.Application.Workbooks.Add(true).Save();
                       //保存excel文件   
                       wbook.SaveCopyAs("e:" + "\\RK_EXCEL.xls");
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
                    //excel.Save("e:" + "\\RK_EXCEL.xls");
                    //保存excel文件   
                    wbook.SaveCopyAs("e:" + "\\RK_EXCEL.xls");
                } 
                
               
               
                
                //确保Excel进程关闭   
                excel.Quit();
                excel = null;
                MessageBox.Show("导出成功", "提示");
                btnExSel.Enabled = true;
                //bsaveexl = true;
            }
            catch
            {

                MessageBox.Show("导出失败", "错误提示");
            }

            #endregion
        }

        /// <summary>
        /// 查看EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExSel_Click(object sender, EventArgs e)
        {
          
            System.Diagnostics.Process.Start("e:\\RK_EXCEL.xls"); 
          
        }

    }
}
