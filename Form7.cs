using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            BtnCheck1.Enabled = false;
            BtnCheck2.Enabled = false;


        }

        private void checkBoxOpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpt1.Checked)
            {
                BtnCheck1.Enabled = true;
                //BtnCheck2.Enabled = false;
            }
            else
            {
                BtnCheck1.Enabled = false;
            }

        }

        private void checkBoxOpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpt2.Checked)
            {
                BtnCheck2.Enabled = true;
                //BtnCheck2.Enabled = false;
            }
            else
            {
                BtnCheck2.Enabled = false;
            }
        }

        private void radioButtonOpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpt1.Checked)
            {
                BtnCheck1.Enabled = true;
            }
            else
            {
                BtnCheck1.Enabled = false;
            }
        }

        private void radioButtonOpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpt2.Checked)
            {
                BtnCheck2.Enabled = true;
            }
            else
            {
                BtnCheck2.Enabled = false;
            }
        }
    }
}
