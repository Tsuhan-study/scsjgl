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
    public partial class FanXiuC : Form
    {
        //TestCBLL cBLL = new TestCBLL();
        FanXiuBLL fxBLL = new FanXiuBLL();
        public FanXiuC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定吗？？？","提示",MessageBoxButtons.YesNo);

             if (dr == DialogResult.Yes)
             {
                 tsuhan_scgl_fx fx = new tsuhan_scgl_fx();
                 var s = fxBLL.SelectAllXlh(this.textBox1.Text);
                 fx.id = s.id;
                 fx.原因 = this.comboBox6.Text;
                 fx.不良现象 = s.不良现象;
                 fx.成品编码 = s.成品编码;
                 fx.次数 =s.次数 + 1;
                 fx.工位 = s.工位;
                 fx.客户 = s.客户;
                 fx.型号 = s.型号;
                 fx.序列号 = s.序列号;
                 fx.关联码 = s.关联码;
                 fx.进时间 = s.进时间;
                 fx.出时间 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-M-d HH:mm"));
                 fx.处理方式 = this.comboBox7.Text;
                 bool result = fxBLL.Update(fx);
                 if (result==true)
                 {
                     MessageBox.Show("提交成功！","提示");
                 }
                 else
                 {
                     MessageBox.Show("提交失败！", "提示");
                 }
             }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var xlh = this.textBox1.Text;
                bool result = fxBLL.Exists(xlh);
                if (result == true)
                {
                    tsuhan_scgl_fx fx = fxBLL.SelectAllXlh(xlh);
                    this.textBox2.Text = fx.客户;
                    this.textBox3.Text = fx.型号;
                    this.textBox4.Text = fx.成品编码;
                    this.textBox6.Text = fx.关联码;

                    this.textBox5.Text = Convert.ToString(fx.次数);
                    if (fx.工位 == "包装")
                    {
                        this.textBox7.Text = fx.不良现象;
                    }
                    else if (fx.工位 == "LD")
                    {
                        this.textBox8.Text = fx.不良现象;
                    }
                    else if (fx.工位 == "PT")
                    {
                        this.textBox9.Text = fx.不良现象;
                    }
                    else if (fx.工位 == "测试")
                    {
                        this.textBox10.Text = fx.不良现象;
                    }
                    else if (fx.工位 == "清洗")
                    {
                        this.textBox11.Text = fx.不良现象;
                    }
                    this.button1.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = false;
                    return;
                }
            }
            this.textBox1.Focus();
        }
        //001002001003
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var gl = this.textBox6.Text;
                bool result = fxBLL.Exist(gl);
                if (result==true)
                {
                   this.textBox6.Enabled = true;
                   tsuhan_scgl_fx fx = fxBLL.SelectGLM(gl);
                   this.textBox1.Text = fx.序列号;
                   this.textBox2.Text = fx.客户;
                   this.textBox3.Text = fx.型号;
                   this.textBox4.Text = fx.成品编码;
                   this.textBox5.Text =Convert.ToString(fx.次数);
                   if (fx.工位 == "包装")
                   {
                       this.textBox7.Text = fx.不良现象;
                   }
                   else if (fx.工位 == "LD")
                   {
                       this.textBox8.Text = fx.不良现象;
                   }
                   else if (fx.工位 == "PT")
                   {
                       this.textBox9.Text = fx.不良现象;
                   }
                   else if (fx.工位 == "测试")
                   {
                       this.textBox10.Text = fx.不良现象;
                   }
                   else if (fx.工位 == "清洗")
                   {
                       this.textBox11.Text = fx.不良现象;
                   }
                   this.textBox6.Focus();
                }
                else
                {
                    this.textBox6.Enabled = false;
                    return;
                }
            }
        }

       
    }
}
