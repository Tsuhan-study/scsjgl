using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maticsoft.BLL;
using BLL;


namespace scsjgl
{
    public partial class IQC : Form
    {
        tsuhan_scgl_iqc_cxl cxl = new tsuhan_scgl_iqc_cxl();
        tsuhan_scgl_iqc_glql glql = new tsuhan_scgl_iqc_glql();
        tsuhan_scgl_iqc_jkzjl jkzjl = new tsuhan_scgl_iqc_jkzjl();
        tsuhan_scgl_iqc_jsjl jsjl = new tsuhan_scgl_iqc_jsjl();
        tsuhan_scgl_iqc_ktl ktl = new tsuhan_scgl_iqc_ktl();
        tsuhan_scgl_iqc_lbpl lbpl = new tsuhan_scgl_iqc_lbpl();
        tsuhan_scgl_iqc_ldl ldl = new tsuhan_scgl_iqc_ldl();
        tsuhan_scgl_iqc_pdptl pdptl = new tsuhan_scgl_iqc_pdptl();
        tsuhan_scgl_iqc_wxl wxl = new tsuhan_scgl_iqc_wxl();
        YhBLL yhbll=new YhBLL();
        //
        string gh = Login.name;
        public IQC()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==2)
            {
                textBox1.Show();
            }
            else 
            {
                textBox1.Hide();
            }
        }

        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox58.SelectedIndex == 2)
            {
                textBox399.Show();
            }
            else
            {
                textBox399.Hide();
            }
        }

        private void comboBox106_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox106.SelectedIndex == 2)
            {
                textBox341.Show();
            }
            else
            {
                textBox341.Hide();
            }
        }

        private void comboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox80.SelectedIndex == 2)
            {
                textBox557.Show();
            }
            else
            {
                textBox557.Hide();
            }
        }

        private void comboBox91_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox91.SelectedIndex == 2)
            {
                textBox636.Show();
            }
            else
            {
                textBox636.Hide();
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox25.SelectedIndex == 2)
            {
                textBox162.Show();
            }
            else
            {
                textBox162.Hide();
            }
        }

        private void comboBox102_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox102.SelectedIndex == 2)
            {
                textBox715.Show();
            }
            else
            {
                textBox715.Hide();
            }
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox36.SelectedIndex == 2)
            {
                textBox241.Show();
            }
            else
            {
                textBox241.Hide();
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox47.SelectedIndex == 2)
            {
                textBox320.Show();
            }
            else
            {
                textBox320.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gt = yhbll.GetModel(gh);
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    //if(gt.职务)
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }

    }
}
