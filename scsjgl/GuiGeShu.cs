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
    public partial class GuiGeShu : Form
    {
        SpecBLL specBll = new SpecBLL();
        YhBLL yhbll = new YhBLL();
        string gh = Login.name;
        //Login fr;

        public GuiGeShu()
        {
            //fr = loge;
            InitializeComponent();
        }

        private void GuiGeShu_Load(object sender, EventArgs e)
        {
            var gt = yhbll.GetModel(Convert.ToInt32(gh));
            if (gt.职务 == "系统管理员")
            {
                this.button2.Enabled = true;
                this.button2.BackColor = Color.LightGray;
            }
            else
            {
                this.button2.Enabled = false;
                this.button2.BackColor = Color.Gray;
            }
            this.textBox8.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 0;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox7.SelectedIndex = 0;
            this.comboBox8.SelectedIndex = 0;
            this.comboBox9.SelectedIndex = 0;
            this.comboBox10.SelectedIndex = 0;

            this.button3.Enabled = false;
            this.button3.BackColor = Color.Gray;
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox3.SelectedIndex==0)
            {
                this.textBox7.Text ="20";
            }
            else if (this.comboBox3.SelectedIndex == 1)
            {
                this.textBox7.Text = "70";
            }
            else if (this.comboBox3.SelectedIndex == 2)
            {
                this.textBox7.Text = "-40";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex==0)
            {
                this.textBox5.Enabled = false;
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                this.textBox5.Enabled = false;
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.textBox5.Enabled = true;
            }
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox5.SelectedIndex==0)
            {
                this.comboBox8.Enabled = false;
                this.textBox9.Enabled = true;
                this.textBox10.Enabled = true;
            }
            else if (this.comboBox5.SelectedIndex == 1)
            {
                this.textBox9.Enabled = false;
                this.textBox10.Enabled = false;
                this.comboBox8.Enabled = true;

            }
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox4.SelectedIndex == 0)
            {
                this.comboBox10.Enabled = false;
            }
            else if (this.comboBox4.SelectedIndex == 1)
            {
                this.comboBox10.Enabled = true;

            }
        }

        /// <summary>
        /// 添加规格书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定要添加吗？？？","提示",MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 tsuhan_spec spec = new tsuhan_spec();
                 SpecM(spec);
                 bool result = false;

                 result = specBll.Add(spec);

                 if (result == true)
                 {
                     MessageBox.Show("添加成功", "提示");
                 }
                 else
                 {
                     MessageBox.Show("添加失败", "提示");
                 }

             }
        }
       
        private void SpecM(tsuhan_spec spec)
        {
            spec.规格书 = this.textBox1.Text;
            spec.客户代码 = this.textBox4.Text;
            spec.产品型号 = this.textBox2.Text;
            spec.成品编码 = this.textBox3.Text;
            spec.LD方法 = this.comboBox1.Text;
            spec.LDλc = this.comboBox2.Text;
            if (this.textBox5.Text=="")
            {
                this.textBox5.Text = "0";
            }
            spec.Po = Convert.ToDecimal(this.textBox5.Text);
            if (this.textBox6.Text=="")
            {
                this.textBox6.Text = "0";
            }
            spec.Ifc = Convert.ToDecimal(this.textBox6.Text);
            if (this.comboBox3.SelectedIndex == 0)
            {
                spec.Tc_c = Convert.ToDecimal(this.textBox7.Text);
            }
            else if (this.comboBox3.SelectedIndex == 1)
            {
                spec.Tc_h = Convert.ToDecimal(this.textBox7.Text);
            }
            else if (this.comboBox3.SelectedIndex == 2)
            {
                spec.Tc_d = Convert.ToDecimal(this.textBox7.Text);
            }
            spec.上传时间 = Convert.ToDateTime(this.textBox8.Text);
            spec.PT方法 = this.comboBox5.Text;
            spec.APT_PT = this.comboBox4.Text;
            spec.码型 = this.comboBox6.Text;
            if (this.textBox9.Text == "")
            {
                this.textBox9.Text = "0";
            }
            spec.通时间 = Convert.ToInt32(this.textBox9.Text);
            if (this.textBox10.Text == "")
            {
                this.textBox10.Text = "0";
            }
            spec.Sen = Convert.ToDecimal(this.textBox10.Text);
            spec.误码率 = this.comboBox8.Text;
            spec.速率 = this.comboBox7.Text;
            spec.PTλc = this.comboBox9.Text;
            spec.Vbr34 = this.comboBox10.Text;

            if (this.textBox42.Text == "")
            {
                this.textBox42.Text = "0";
            }
            spec.Pomax = Convert.ToDecimal(this.textBox42.Text);
            if (this.textBox11.Text == "")
            {
                this.textBox11.Text = "0";
            }
            spec.Pomin = Convert.ToDecimal(this.textBox11.Text);
            if (this.textBox56.Text == "")
            {
                this.textBox56.Text = "0";
            }
            spec.PomaxBFB = Convert.ToInt32(this.textBox56.Text);
            if (this.textBox55.Text == "")
            {
                this.textBox55.Text = "0";
            }
            spec.PominBFB = Convert.ToInt32(this.textBox55.Text);
            if (this.textBox41.Text == "")
            {
                this.textBox41.Text = "0";
            }
            spec.Ithmax = Convert.ToDecimal(this.textBox41.Text);
            if (this.textBox12.Text == "")
            {
                this.textBox12.Text = "0";
            }
            spec.Ithmin = Convert.ToDecimal(this.textBox12.Text);
            if (this.textBox40.Text == "")
            {
                this.textBox40.Text = "0";
            }
            spec.Vfmax = Convert.ToDecimal(this.textBox40.Text);
            if (this.textBox13.Text == "")
            {
                this.textBox13.Text = "0";
            }
            spec.Vfmin = Convert.ToDecimal(this.textBox13.Text);
            if (this.textBox39.Text == "")
            {
                this.textBox39.Text = "0";
            }
            spec.Imomax = Convert.ToInt32(this.textBox39.Text);
            if (this.textBox14.Text == "")
            {
                this.textBox14.Text = "0";
            }
            spec.Imomin = Convert.ToInt32(this.textBox14.Text);
            if (this.textBox57.Text == "")
            {
                this.textBox57.Text = "0";
            }
            spec.ImomaxBFB = Convert.ToInt32(this.textBox57.Text);
            if (this.textBox58.Text == "")
            {
                this.textBox58.Text = "0";
            }
            spec.ImominBFB = Convert.ToInt32(this.textBox58.Text);
            if (this.textBox38.Text == "")
            {
                this.textBox38.Text = "0";
            }
            spec.Esmax = Convert.ToDecimal(this.textBox38.Text);
            if (this.textBox18.Text == "")
            {
                this.textBox18.Text = "0";
            }
            spec.Esmin = Convert.ToDecimal(this.textBox18.Text);
            if (this.textBox60.Text == "")
            {
                this.textBox60.Text = "0";
            }
            spec.EsmaxBFB = Convert.ToInt32(this.textBox60.Text);
            if (this.textBox59.Text == "")
            {
                this.textBox59.Text = "0";
            }
            spec.EsminBFB = Convert.ToInt32(this.textBox59.Text);
            if (this.textBox37.Text == "")
            {
                this.textBox37.Text = "0";
            }
            spec.Rsmax = Convert.ToDecimal(this.textBox37.Text);
            if (this.textBox17.Text == "")
            {
                this.textBox17.Text = "0";
            }
            spec.Rsmin = Convert.ToDecimal(this.textBox17.Text);
            if (this.textBox36.Text == "")
            {
                this.textBox36.Text = "0";
            }
            spec.Pkinkmax = Convert.ToInt32(this.textBox36.Text);//LD
            if (this.textBox16.Text == "")
            {
                this.textBox16.Text = "0";
            }
            spec.Pkinkmin = Convert.ToInt32(this.textBox16.Text);
            if (this.textBox66.Text == "")
            {
                this.textBox66.Text = "0";
            }
            spec.Kimomax = Convert.ToInt32(this.textBox66.Text);//PT
            if (this.textBox67.Text == "")
            {
                this.textBox67.Text = "0";
            }
            spec.Kimomin = Convert.ToInt32(this.textBox67.Text);
            if (this.textBox35.Text == "")
            {
                this.textBox35.Text = "0";
            }
            spec.LDλcmax = Convert.ToDecimal(this.textBox35.Text);
            if (this.textBox15.Text == "")
            {
                this.textBox15.Text = "0";
            }
            spec.LDλcmin = Convert.ToDecimal(this.textBox15.Text);
            if (this.textBox34.Text == "")
            {
                this.textBox34.Text = "0";
            }
            spec.LDλmax = Convert.ToDecimal(this.textBox34.Text);
            if (this.textBox26.Text == "")
            {
                this.textBox26.Text = "0";
            }
            spec.LDλmin = Convert.ToDecimal(this.textBox26.Text);
            if (this.textBox33.Text == "")
            {
                this.textBox33.Text = "0";
            }
            spec.Srmsmax = Convert.ToDecimal(this.textBox33.Text);
            if (this.textBox25.Text == "")
            {
                this.textBox25.Text = "0";
            }
            spec.Srmsmin = Convert.ToDecimal(this.textBox25.Text);
            if (this.textBox32.Text == "")
            {
                this.textBox32.Text = "0";
            }
            spec.TEdmax = Convert.ToDecimal(this.textBox32.Text);
            if (this.textBox24.Text == "")
            {
                this.textBox24.Text = "0";
            }
            spec.TEdmin = Convert.ToDecimal(this.textBox24.Text);
            if (this.textBox31.Text == "")
            {
                this.textBox31.Text = "0";
            }
            spec.ImoKinkmax = Convert.ToInt32(this.textBox31.Text);
            if (this.textBox23.Text == "")
            {
                this.textBox23.Text = "0";
            }
            spec.ImoKinkmin = Convert.ToInt32(this.textBox23.Text);
            if (this.textBox30.Text == "")
            {
                this.textBox30.Text = "0";
            }
            spec.Idarkmax = Convert.ToInt32(this.textBox30.Text);
            if (this.textBox22.Text == "")
            {
                this.textBox22.Text = "0";
            }
            spec.Idarkmin = Convert.ToInt32(this.textBox22.Text);
            if (this.textBox29.Text == "")
            {
                this.textBox29.Text = "0";
            }
            spec.Ifmax = Convert.ToDecimal(this.textBox29.Text);
            if (this.textBox21.Text == "")
            {
                this.textBox21.Text = "0";
            }
            spec.Ifmin = Convert.ToDecimal(this.textBox21.Text);
            if (this.textBox28.Text == "")
            {
                this.textBox28.Text = "0";
            }
            spec.老化前max = Convert.ToDecimal(this.textBox28.Text);
            if (this.textBox20.Text == "")
            {
                this.textBox20.Text = "0";
            }
            spec.老化前min = Convert.ToDecimal(this.textBox20.Text);
            if (this.textBox62.Text == "")
            {
                this.textBox62.Text = "0";
            }
            spec.老化前maxBFB = Convert.ToInt32(this.textBox62.Text);
            if (this.textBox61.Text == "")
            {
                this.textBox61.Text = "0";
            }
            spec.老化前minBFB = Convert.ToInt32(this.textBox61.Text);
            if (this.textBox27.Text == "")
            {
                this.textBox27.Text = "0";
            }
            spec.前后对比max = Convert.ToDecimal(this.textBox27.Text);
            if (this.textBox19.Text == "")
            {
                this.textBox19.Text = "0";
            }
            spec.前后对比min = Convert.ToDecimal(this.textBox19.Text);

            if (this.textBox54.Text == "")
            {
                this.textBox54.Text = "0";
            }
            spec.Vbrmax = Convert.ToDecimal(this.textBox54.Text);
            if (this.textBox48.Text == "")
            {
                this.textBox48.Text = "0";
            }
            spec.Vbrmin = Convert.ToDecimal(this.textBox48.Text);
            if (this.textBox53.Text == "")
            {
                this.textBox53.Text = "0";
            }
            spec.Iopmax = Convert.ToDecimal(this.textBox53.Text);
            if (this.textBox47.Text == "")
            {
                this.textBox47.Text = "0";
            }
            spec.Iopmin = Convert.ToDecimal(this.textBox47.Text);
            if (this.textBox63.Text == "")
            {
                this.textBox63.Text = "0";
            }
            spec.IopminBFB = Convert.ToInt32(this.textBox63.Text);
            if (this.textBox52.Text == "")
            {
                this.textBox52.Text = "0";
            }
            spec.Iomax = Convert.ToDecimal(this.textBox52.Text);
            if (this.textBox46.Text == "")
            {
                this.textBox46.Text = "0";
            }
            spec.Iomin = Convert.ToDecimal(this.textBox46.Text);
            if (this.textBox65.Text == "")
            {
                this.textBox65.Text = "0";
            }
            spec.IominBFB = Convert.ToInt32(this.textBox65.Text);

            if (this.textBox51.Text == "")
            {
                this.textBox51.Text = "0";
            }
            spec.Idmax = Convert.ToDecimal(this.textBox51.Text);
            if (this.textBox45.Text == "")
            {
                this.textBox45.Text = "0";
            }
            spec.Idmin = Convert.ToDecimal(this.textBox45.Text);
            if (this.textBox50.Text == "")
            {
                this.textBox50.Text = "0";
            }
            spec.Iccmax = Convert.ToDecimal(this.textBox50.Text);
            if (this.textBox44.Text == "")
            {
                this.textBox44.Text = "0";
            }
            spec.Iccmin = Convert.ToDecimal(this.textBox44.Text);
            if (this.textBox49.Text == "")
            {
                this.textBox49.Text = "0";
            }
            spec.Senmax = Convert.ToDecimal(this.textBox49.Text);
            if (this.textBox43.Text == "")
            {
                this.textBox43.Text = "0";
            }
            spec.Senmin = Convert.ToDecimal(this.textBox43.Text);
            if (this.textBox64.Text == "")
            {
                this.textBox64.Text = "0";
            }
            spec.SenmaxdB = Convert.ToDecimal(this.textBox64.Text);
            spec.备注 = this.richTextBox1.Text;
        }


        /// <summary>
        /// 根据规格书查询信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            #region 查询
            var ggs = this.textBox1.Text;
             bool result = specBll.Exists(ggs);
              
             if (result == true)
             {
                 tsuhan_spec spec = specBll.GetModel(ggs);
                 this.textBox1.Text = spec.规格书;
                 this.textBox4.Text = spec.客户代码;

                 this.textBox2.Text = spec.产品型号;
                 this.textBox3.Text = spec.成品编码;
                 this.comboBox1.Text = spec.LD方法;
                 this.comboBox2.Text = spec.LDλc;
                 if (spec.Po == null)
                 {
                     this.textBox5.Text = "0";
                 }
                 else
                 {
                     this.textBox5.Text = Convert.ToString(spec.Po);
                 }
                 if (spec.Ifc == null)
                 {
                     this.textBox6.Text = "0";
                 }
                 else
                 {
                     this.textBox6.Text = Convert.ToString(spec.Ifc);
                 }
                 this.textBox8.Text = Convert.ToString(spec.上传时间);

                 if (spec.PT方法 == null)
                 {
                     this.comboBox5.Text = "0";
                 }
                 else
                 {
                     this.comboBox5.Text = Convert.ToString(spec.PT方法);
                 }
                 if (spec.APT_PT == null)
                 {
                     this.comboBox4.Text = "0";
                 }
                 else
                 {
                     this.comboBox4.Text = Convert.ToString(spec.APT_PT);
                 }
                 if (spec.码型 == null)
                 {
                     this.comboBox6.Text = "0";
                 }
                 else
                 {
                     this.comboBox6.Text = Convert.ToString(spec.码型);
                 }
                 if (spec.Po == null)
                 {
                     this.textBox9.Text = "0";
                 }
                 else
                 {
                     this.textBox9.Text = Convert.ToString(spec.通时间);
                 }
                 if (spec.Sen == null)
                 {
                     this.textBox10.Text = "0";
                 }
                 else
                 {
                     this.textBox10.Text = Convert.ToString(spec.Sen);
                 }
                 if (spec.误码率 == null)
                 {
                     this.comboBox8.Text = "0";
                 }
                 else
                 {
                     this.comboBox8.Text = Convert.ToString(spec.误码率);
                 }
                 if (spec.速率 == null)
                 {
                     this.comboBox7.Text = "0";
                 }
                 else
                 {
                     this.comboBox7.Text = Convert.ToString(spec.速率);
                 }
                 if (spec.PTλc == null)
                 {
                     this.comboBox9.Text = "0";
                 }
                 else
                 {
                     this.comboBox9.Text = Convert.ToString(spec.PTλc);
                 }
                 if (spec.Vbr34== null)
                 {
                     this.comboBox10.Text = "0";
                 }
                 else
                 {
                     this.comboBox10.Text = Convert.ToString(spec.Vbr34);
                 }
                 if (spec.Pomax == null)
                 {
                     this.textBox42.Text = "0";
                 }
                 else
                 {
                     this.textBox42.Text = Convert.ToString(spec.Pomax);
                 }
                 if (spec.Pomin == null)
                 {
                     this.textBox11.Text = "0";
                 }
                 else
                 {
                     this.textBox11.Text = Convert.ToString(spec.Pomin);
                 }
                 if (spec.PomaxBFB == null)
                 {
                     this.textBox56.Text = "0";
                 }
                 else
                 {
                     this.textBox56.Text = Convert.ToString(spec.PomaxBFB);
                 }
                 if (spec.PominBFB == null)
                 {
                     this.textBox55.Text = "0";
                 }
                 else
                 {
                     this.textBox55.Text = Convert.ToString(spec.PominBFB);
                 }
                 if (spec.Ithmax == null)
                 {
                     this.textBox41.Text = "0";
                 }
                 else
                 {
                     this.textBox41.Text = Convert.ToString(spec.Ithmax);
                 }
                 if (spec.Ithmin == null)
                 {
                     this.textBox12.Text = "0";
                 }
                 else
                 {
                     this.textBox12.Text = Convert.ToString(spec.Ithmin);
                 }
                 if (spec.Vfmax == null)
                 {
                     this.textBox40.Text = "0";
                 }
                 else
                 {
                     this.textBox40.Text = Convert.ToString(spec.Vfmax);
                 }
                 if (spec.Vfmin== null)
                 {
                     this.textBox13.Text = "0";
                 }
                 else
                 {
                     this.textBox13.Text = Convert.ToString(spec.Vfmin);
                 }
                 if (spec.Iomax == null)
                 {
                     this.textBox39.Text = "0";
                 }
                 else
                 {
                     this.textBox39.Text = Convert.ToString(spec.Imomax);
                 }
                 if (spec.Imomin == null)
                 {
                     this.textBox14.Text = "0";
                 }
                 else
                 {
                     this.textBox14.Text = Convert.ToString(spec.Imomin);
                 }
                 if (spec.ImomaxBFB == null)
                 {
                     this.textBox57.Text = "0";
                 }
                 else
                 {
                     this.textBox57.Text = Convert.ToString(spec.ImomaxBFB);
                 }
                 if (spec.ImominBFB == null)
                 {
                     this.textBox58.Text = "0";
                 }
                 else
                 {
                     this.textBox58.Text = Convert.ToString(spec.ImominBFB);
                 }
                 if (spec.Esmax == null)
                 {
                     this.textBox38.Text = "0";
                 }
                 else
                 {
                     this.textBox38.Text = Convert.ToString(spec.Esmax);
                 }
                 if (spec.Esmin == null)
                 {
                     this.textBox18.Text = "0";
                 }
                 else
                 {
                     this.textBox18.Text = Convert.ToString(spec.Esmin);
                 }
                 if (spec.EsmaxBFB == null)
                 {
                     this.textBox60.Text = "0";
                 }
                 else
                 {
                     this.textBox60.Text = Convert.ToString(spec.EsmaxBFB);
                 }
                 if (spec.EsminBFB == null)
                 {
                     this.textBox59.Text = "0";
                 }
                 else
                 {
                     this.textBox59.Text = Convert.ToString(spec.EsminBFB);
                 }
                 if (spec.Rsmax == null)
                 {
                     this.textBox37.Text = "0";
                 }
                 else
                 {
                     this.textBox37.Text = Convert.ToString(spec.Rsmax);
                 }
                 if (spec.Rsmin == null)
                 {
                     this.textBox17.Text = "0";
                 }
                 else
                 {
                     this.textBox17.Text = Convert.ToString(spec.Rsmin);
                 }
                 if (spec.Pkinkmax == null)
                 {
                     this.textBox36.Text = "0";
                 }
                 else
                 {
                     this.textBox36.Text = Convert.ToString(spec.Pkinkmax);
                 }
                 if (spec.Pkinkmin == null)
                 {
                     this.textBox16.Text = "0";
                 }
                 else
                 {
                     this.textBox16.Text = Convert.ToString(spec.Pkinkmin);
                 }
                 if (spec.Kimomax == null)
                 {
                     this.textBox66.Text = "0";
                 }
                 else
                 {
                     this.textBox66.Text = Convert.ToString(spec.Kimomax);//PT
                 }
                 if (spec.Kimomin == null)
                 {
                     this.textBox67.Text = "0";
                 }
                 else
                 {
                 this.textBox67.Text=Convert.ToString(spec.Kimomin);
                 }
                   
                   
                 if (spec.LDλcmax == null)
                 {
                     this.textBox35.Text = "0";
                 }
                 else
                 {
                     this.textBox35.Text = Convert.ToString(spec.LDλcmax);
                 }
                 if (spec.LDλcmin == null)
                 {
                     this.textBox15.Text = "0";
                 }
                 else
                 {
                     this.textBox15.Text = Convert.ToString(spec.LDλcmin);
                 }
                 if (spec.LDλmax == null)
                 {
                     this.textBox34.Text = "0";
                 }
                 else
                 {
                     this.textBox34.Text = Convert.ToString(spec.LDλmax);
                 }
                 if (spec.LDλmin == null)
                 {
                     this.textBox26.Text = "0";
                 }
                 else
                 {
                     this.textBox26.Text = Convert.ToString(spec.LDλmin);
                 }
                 if (spec.Srmsmax == null)
                 {
                     this.textBox33.Text = "0";
                 }
                 else
                 {
                     this.textBox33.Text = Convert.ToString(spec.Srmsmax);
                 }
                 if (spec.Srmsmin == null)
                 {
                     this.textBox25.Text = "0";
                 }
                 else
                 {
                     this.textBox25.Text = Convert.ToString(spec.Srmsmin);
                 }
                 if (spec.TEdmax == null)
                 {
                     this.textBox32.Text = "0";
                 }
                 else
                 {
                     this.textBox32.Text = Convert.ToString(spec.TEdmax);
                 }
                 if (spec.TEdmin == null)
                 {
                     this.textBox24.Text = "0";
                 }
                 else
                 {
                     this.textBox24.Text = Convert.ToString(spec.TEdmin);
                 }
                 if (spec.ImoKinkmax == null)
                 {
                     this.textBox31.Text = "0";
                 }
                 else
                 {
                     this.textBox31.Text = Convert.ToString(spec.ImoKinkmax);
                 }
                 if (spec.ImoKinkmin == null)
                 {
                     this.textBox23.Text = "0";
                 }
                 else
                 {
                     this.textBox23.Text = Convert.ToString(spec.ImoKinkmin);
                 }
                 if (spec.Idarkmax == null)
                 {
                     this.textBox30.Text = "0";
                 }
                 else
                 {
                     this.textBox30.Text = Convert.ToString(spec.Idarkmax);
                 }
                 if (spec.Idarkmin == null)
                 {
                     this.textBox22.Text = "0";
                 }
                 else
                 {
                     this.textBox22.Text = Convert.ToString(spec.Idarkmin);
                 }
                 if (spec.Ifmax == null)
                 {
                     this.textBox29.Text = "0";
                 }
                 else
                 {
                     this.textBox29.Text = Convert.ToString(spec.Ifmax);
                 }
                 if (spec.Ifmin == null)
                 {
                     this.textBox21.Text = "0";
                 }
                 else
                 {
                     this.textBox21.Text = Convert.ToString(spec.Ifmin);
                 }
                 if (spec.老化前max == null)
                 {
                     this.textBox28.Text = "0";
                 }
                 else
                 {
                     this.textBox28.Text = Convert.ToString(spec.老化前max);
                 }
                 if (spec.老化前min == null)
                 {
                     this.textBox20.Text = "0";
                 }
                 else
                 {
                     this.textBox20.Text = Convert.ToString(spec.老化前min);
                 }
                 if (spec.老化前maxBFB == null)
                 {
                     this.textBox62.Text = "0";
                 }
                 else
                 {
                     this.textBox62.Text = Convert.ToString(spec.老化前maxBFB);
                 }
                 if (spec.老化前minBFB == null)
                 {
                     this.textBox61.Text = "0";
                 }
                 else
                 {
                     this.textBox61.Text = Convert.ToString(spec.老化前minBFB);
                 }
                 if (spec.前后对比max == null)
                 {
                     this.textBox27.Text = "0";
                 }
                 else
                 {
                     this.textBox27.Text = Convert.ToString(spec.前后对比max);
                 }
                 if (spec.前后对比min == null)
                 {
                     this.textBox19.Text = "0";
                 }
                 else
                 {
                     this.textBox19.Text = Convert.ToString(spec.前后对比min);
                 }

                 if (spec.Vbrmax == null)
                 {
                     this.textBox54.Text = "0";
                 }
                 else
                 {
                     this.textBox54.Text = Convert.ToString(spec.Vbrmax);
                 }
                 if (spec.Vbrmin== null)
                 {
                     this.textBox48.Text = "0";
                 }
                 else
                 {
                     this.textBox48.Text = Convert.ToString(spec.Vbrmin);
                 }
                 if (spec.Iopmax == null)
                 {
                     this.textBox53.Text = "0";
                 }
                 else
                 {
                     this.textBox53.Text = Convert.ToString(spec.Iopmax);
                 }
                 if (spec.Iopmin == null)
                 {
                     this.textBox47.Text = "0";
                 }
                 else
                 {
                     this.textBox47.Text = Convert.ToString(spec.Iopmin);
                 }
                 if (spec.IopminBFB == null)
                 {
                     this.textBox63.Text = "0";
                 }
                 else
                 {
                     this.textBox63.Text = Convert.ToString(spec.IopminBFB);
                 }
                 if (spec.Iopmax == null)
                 {
                     this.textBox52.Text = "0";
                 }
                 else
                 {
                     this.textBox52.Text = Convert.ToString(spec.Iomax);
                 }
                 if (spec.Iopmin== null)
                 {
                     this.textBox46.Text = "0";
                 }
                 else
                 {
                     this.textBox46.Text = Convert.ToString(spec.Iomin);
                 }
                 if (spec.IopminBFB == null)
                 {
                     this.textBox65.Text = "0";
                 }
                 else
                 {
                     this.textBox65.Text = Convert.ToString(spec.IominBFB);
                 }
                 if (spec.Idmax == null)
                 {
                     this.textBox51.Text = "0";
                 }
                 else
                 {
                     this.textBox51.Text = Convert.ToString(spec.Idmax);
                 }
                 if (spec.Idmin == null)
                 {
                     this.textBox45.Text = "0";
                 }
                 else
                 {
                     this.textBox45.Text = Convert.ToString(spec.Idmin);
                 }
                 if (spec.Iccmax == null)
                 {
                     this.textBox50.Text = "0";
                 }
                 else
                 {
                     this.textBox50.Text = Convert.ToString(spec.Iccmax);
                 }
                 if (spec.Iccmin == null)
                 {
                     this.textBox44.Text = "0";
                 }
                 else
                 {
                     this.textBox44.Text = Convert.ToString(spec.Iccmin);
                 }
                 if (spec.Senmax == null)
                 {
                     this.textBox49.Text = "0";
                 }
                 else
                 {
                     this.textBox49.Text = Convert.ToString(spec.Senmax);
                 }
                 if (spec.Senmin == null)
                 {
                     this.textBox43.Text = "0";
                 }
                 else
                 {
                     this.textBox43.Text = Convert.ToString(spec.Senmin);
                 }
                 if (spec.SenmaxdB == null)
                 {
                     this.textBox64.Text = "0";
                 }
                 else
                 {
                     this.textBox64.Text = Convert.ToString(spec.SenmaxdB);
                 }
                 if (spec.Tc_c!=null&&spec.Tc_d==null&&spec.Tc_h==null)
                 {
                     this.comboBox3.Text ="常温测试";
                     this.textBox7.Text =Convert.ToString(spec.Tc_c);
                 }
                 else if (spec.Tc_c == null && spec.Tc_d != null && spec.Tc_h == null)
                 {
                     this.comboBox3.Text = "低温测试";
                     this.textBox7.Text = Convert.ToString(spec.Tc_d);
                 }
                 else if (spec.Tc_c == null && spec.Tc_d == null && spec.Tc_h != null)
                 {
                     this.comboBox3.Text = "高温测试";
                     this.textBox7.Text = Convert.ToString(spec.Tc_h);
                 }
                 this.richTextBox1.Text = spec.备注;
             }
             else
             {
                 MessageBox.Show("此规格书不存在！", "提示");
             }
            #endregion
        }


        /// <summary>
        /// 判断是否审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var ggs = this.textBox1.Text;
            tsuhan_spec spe = specBll.GetModel(ggs);
            if (spe.审核时间==null)
            {
                tsuhan_spec spec = new tsuhan_spec();
                SpecM(spec);
                spec.审核时间 = DateTime.Now;
                bool result = specBll.Update(spec);
                if (result == true)
                {
                    MessageBox.Show("审核成功", "提示");
                }
                else
                {
                    MessageBox.Show("审核失败","提示");
                }
            }
            else
            {

                MessageBox.Show("此规格书已经审核完成,审核时间：" + spe.审核时间 + "", "提示");
            }
        }

        /// <summary>
        /// 判断是否输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
            }

            //输入为负号时，只能输入一次且只能输入一次 

            if (e.KeyChar == 45 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.IndexOf("-") >= 0))
            {
                e.Handled = true;
            }

            //输入为小数点时，只能输入一次且只能输入一次 

            if (e.KeyChar == 46 && ((TextBox)sender).Text.IndexOf(".") >= 0)
            {
                e.Handled = true;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            SelectSpec sp = new SelectSpec();
            sp.ShowDialog();
        }

        /// <summary>
        /// 修改规格书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定要修改吗？？？","提示",MessageBoxButtons.YesNo);

             if (dr == DialogResult.Yes)
             {
                 var ggs = this.textBox1.Text;
                 if (ggs!="")
                 {
                     tsuhan_spec spec = new tsuhan_spec();
                     SpecM(spec);
                     bool result = false;

                     result = specBll.Update(spec);

                     if (result == true)
                     {
                         MessageBox.Show("添加成功", "提示");
                         this.button3.Enabled=false;
                     }
                     else
                     {
                         MessageBox.Show("添加失败", "提示");
                     }
                 }
             }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 判断规格书是否存在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            var ggs = this.textBox1.Text;

            bool result = specBll.Exists(ggs);
            if (result == true)
            {
                MessageBox.Show("此规格书已经存在！", "提示");
                this.button3.Enabled = false;
                this.button3.BackColor = Color.Gray;
                this.btnUpdate.Enabled = true;
            }
            else
            {
                this.button3.Enabled = true;
                this.button3.BackColor = Color.LightGray;
                this.btnUpdate.Enabled = false;
            }
        }
    }







}
