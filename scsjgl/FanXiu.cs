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
    public partial class FanXiu : Form
    {
        TestCBLL cBLL = new TestCBLL();
        FanXiuBLL fxBLL = new FanXiuBLL();
        public FanXiu()
        {
            InitializeComponent();
        }


        private void FanXiu_Load(object sender, EventArgs e)
        {
            this.textBox8.Visible = false;
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
            DialogResult dr = MessageBox.Show("确定吗？？？","提示",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool result1 = fxBLL.Exists(this.textBox1.Text);
                if (result1 == true)
                {
                    var f = fxBLL.SelectAllXlh(this.textBox1.Text);
                    if (f.出时间 ==null)
                    {
                        MessageBox.Show("未完成，请继续下一步", "提示");
                    }
                    else
                    {
                        tsuhan_scgl_fx fxmodel = new tsuhan_scgl_fx();
                        if (this.textBox8.Visible == true)
                        {
                            //this.textBox8.Visible = true;
                            fxmodel.关联码 = this.textBox8.Text;
                        }
                        else
                        {
                            fxmodel.关联码 = "";
                        }
                        fxmodel.序列号 = this.textBox1.Text; ;
                        fxmodel.客户 = this.textBox2.Text;
                        fxmodel.型号 = this.textBox3.Text;
                        fxmodel.成品编码 = this.textBox4.Text;
                        fxmodel.次数 = Convert.ToInt32(this.textBox5.Text);
                        fxmodel.进时间 =Convert.ToDateTime(DateTime.Now.ToString("yyyy-M-d HH:mm"));
                        var dh = this.textBox6.Text;
                        var str = dh.Substring(0, 1);
                        if (str == "1")
                        {
                            fxmodel.工位 = "包装";
                            if (comboBox1.Text == "110其他")
                            {
                                fxmodel.不良现象 = this.textBox7.Text;
                            }
                            else
                            {
                                fxmodel.不良现象 = this.comboBox1.Text;
                            }
                        }
                        else if (str == "2")
                        {
                            fxmodel.工位 = "LD";
                            if (comboBox2.Text == "210其他")
                            {
                                fxmodel.不良现象 = this.textBox7.Text;
                            }
                            else
                            {
                                fxmodel.不良现象 = this.comboBox2.Text;
                            }
                        }
                        else if (str == "3")
                        {
                            fxmodel.工位 = "PT";
                            if (comboBox3.Text == "310其他")
                            {
                                fxmodel.不良现象 = this.textBox7.Text;
                            }
                            else
                            {
                                fxmodel.不良现象 = this.comboBox3.Text;
                            }
                        }
                        else if (str == "4")
                        {
                            fxmodel.工位 = "测试";
                            if (comboBox4.Text == "409其他")
                            {
                                fxmodel.不良现象 = this.textBox7.Text;
                            }
                            else
                            {
                                fxmodel.不良现象 = this.comboBox4.Text;
                            }
                        }
                        else if (str == "5")
                        {
                            fxmodel.工位 = "清洗";
                            if (comboBox5.Text == "502其他")
                            {
                                fxmodel.不良现象 = this.textBox7.Text;
                            }
                            else
                            {
                                fxmodel.不良现象 = this.comboBox5.Text;
                            }
                        }
                        else
                        {
                            MessageBox.Show("不良现象选择错误！！！", "提示");
                            return;
                        }
                        bool result = false;
                        result = fxBLL.Add(fxmodel);
                        if (result == true)
                        {
                            MessageBox.Show("提交成功", "提示");
                        }
                        else
                        {
                            MessageBox.Show("提交失败", "提示");
                        }
                    }
                }
                else
                {

                    tsuhan_scgl_fx fxmodel = new tsuhan_scgl_fx();
                    if (this.textBox8.Visible == true)
                    {
                        fxmodel.关联码 = this.textBox8.Text;
                    }
                    else
                    {
                        fxmodel.关联码 = "";
                    }
                    fxmodel.序列号 = this.textBox1.Text; ;
                    fxmodel.客户 = this.textBox2.Text;
                    fxmodel.型号 = this.textBox3.Text;
                    fxmodel.成品编码 = this.textBox4.Text;
                    fxmodel.次数 = Convert.ToInt32(this.textBox5.Text);
                    fxmodel.进时间 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-M-d HH:mm"));
                    var dh = this.textBox6.Text;
                    var str = dh.Substring(0, 1);
                    if (str == "1")
                    {
                        fxmodel.工位 = "包装";
                        if (comboBox1.Text == "110其他")
                        {
                            fxmodel.不良现象 = this.textBox7.Text;
                        }
                        else
                        {
                            fxmodel.不良现象 = this.comboBox1.Text;
                        }
                    }
                    else if (str == "2")
                    {
                        fxmodel.工位 = "LD";
                        if (comboBox2.Text == "210其他")
                        {
                            fxmodel.不良现象 = this.textBox7.Text;
                        }
                        else
                        {
                            fxmodel.不良现象 = this.comboBox2.Text;
                        }
                    }
                    else if (str == "3")
                    {
                        fxmodel.工位 = "PT";
                        if (comboBox3.Text == "310其他")
                        {
                            fxmodel.不良现象 = this.textBox7.Text;
                        }
                        else
                        {
                            fxmodel.不良现象 = this.comboBox3.Text;
                        }
                    }
                    else if (str == "4")
                    {
                        fxmodel.工位 = "测试";
                        if (comboBox4.Text == "409其他")
                        {
                            fxmodel.不良现象 = this.textBox7.Text;
                        }
                        else
                        {
                            fxmodel.不良现象 = this.comboBox4.Text;
                        }
                    }
                    else if (str == "5")
                    {
                        fxmodel.工位 = "清洗";
                        if (comboBox5.Text == "502其他")
                        {
                            fxmodel.不良现象 = this.textBox7.Text;
                        }
                        else
                        {
                            fxmodel.不良现象 = this.comboBox5.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("不良现象选择错误！！！", "提示");
                        return;
                    }
                    //000000T435382421
                    bool result = false;
                    result = fxBLL.Add(fxmodel);
                    if (result == true)
                    {
                        MessageBox.Show("提交成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("提交失败", "提示");
                    }
                }
            }
        }

        private void textBox6_MouseUp(object sender, MouseEventArgs e)
        {
            var dh = this.textBox6.Text;
            var str = dh.Substring(0,3);
            if (str == "1")
            {
                this.comboBox1.DroppedDown = true;
            }
            else if (str == "2")
            {
                this.comboBox2.DroppedDown = true;
            }
            else if (str == "3")
            {
                this.comboBox3.DroppedDown = true;
            }
            else if (str == "4")
            {
                this.comboBox4.DroppedDown = true;
            }
            else if (str == "5")
            {
                this.comboBox5.DroppedDown = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var st = this.textBox6.Text;
            if (st == "1" ||st=="10")
            {
                this.comboBox1.DroppedDown = true;
                this.textBox7.Enabled = false;
            }
            else if (st == "101")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 0;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "102")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 1;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "103")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 2;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "104")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 3;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "105")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 4;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "106")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 5;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "107")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 6;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "108")
            {
                this.comboBox1.DroppedDown = true;
                this.comboBox1.SelectedIndex = 9;
                this.textBox7.Enabled = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }

            if (st == "2" || st=="20")
            {
                this.comboBox2.DroppedDown = true;
                this.textBox7.Enabled = false;
            }
            else if (st == "201")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 0;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "202")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 1;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "203")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 2;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "204")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 3;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "205")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 4;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "206")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 5;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "207")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 6;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "208")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 7;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "209")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 8;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "210")
            {
                this.comboBox2.DroppedDown = true;
                this.comboBox2.SelectedIndex = 9;
                this.textBox7.Enabled = true;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = true;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            if (st == "3" ||　st=="30")
            {
                this.comboBox3.DroppedDown = true;
                this.textBox7.Enabled = false;
            }
            else if (st == "301")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 0;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "302")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 1;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "303")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 2;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "304")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 3;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "305")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 4;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "306")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 5;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "307")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 6;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "308")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 7;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "309")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 8;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "310")
            {
                this.comboBox3.DroppedDown = true;
                this.comboBox3.SelectedIndex = 9;
                this.textBox7.Enabled = true;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
                this.comboBox5.Text = "";
            }

            if (st == "4" || st=="40")
            {
                this.comboBox4.DroppedDown = true;
                this.textBox7.Enabled = false;
            }
            else if (st == "401")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 0;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "402")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 1;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "403")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 2;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "404")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 3;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "405")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 4;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "406")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 5;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "407")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 6;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "408")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 7;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }
            else if (st == "409")
            {
                this.comboBox4.DroppedDown = true;
                this.comboBox4.SelectedIndex = 8;
                this.textBox7.Enabled = true;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = false;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox5.Text = "";
            }

            if (st == "5" || st=="50")
            {
                this.comboBox5.DroppedDown = true;
                this.textBox7.Enabled = false;
            }
            else if (st == "501")
            {
                this.comboBox5.DroppedDown = true;
                this.comboBox5.SelectedIndex = 0;
                this.textBox7.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = true;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
            }
            else if (st == "502")
            {
                this.comboBox5.DroppedDown = true;
                this.comboBox5.SelectedIndex = 1;
                this.textBox7.Enabled = true;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = true;
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.comboBox4.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string xlh = this.textBox1.Text;

                //根据序列号查询
                bool result1 = cBLL.Exists(xlh);
                if (result1==true)
                {
                    var lis = cBLL.SelectC(xlh);
                    this.textBox2.Text = lis.客户;
                    this.textBox3.Text = lis.型号;
                    this.textBox4.Text = lis.成品编码;
                    bool result = fxBLL.Exists(xlh);
                    if (result == true)
                    {
                        var f = fxBLL.SelectAllXlh(xlh);
                        if (f.出时间!=null)
                        {
                            this.textBox8.Visible = true;
                            this.textBox8.Enabled = false;
                            this.checkBox1.Enabled = false;
                            this.textBox8.Text = f.关联码;

                        }
                        else
                        {
                            this.textBox8.Visible = false;
                            this.checkBox1.Enabled = true;
                        }
                        if (f.次数 == 0)
                        {
                            this.textBox5.Text = "0";
                        }
                        else
                        {
                            this.textBox5.Text = Convert.ToString(f.次数);
                        }
                    }
                    else
                    {
                        this.textBox5.Text = "0";
                    }
                    //000000T435382421
                    this.button1.Enabled = true;
                    textBox1.Focus(); ;
                }
                else
                {

                    this.button1.Enabled = false;
                    return;
                }
               
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.textBox8.Visible = true;
            }
            else
            {
                this.textBox8.Visible = false;
            }
        }
    }
}
