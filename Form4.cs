using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnView1_Click(object sender, EventArgs e)
        {

            // 1-9
            listBoxView.Items.Clear();      //Clear Items in Listbox
            //listBoxView.Items.Add("AB:");
            int start_value = int.Parse(TxtStartValue.Text);
            int End_value = int.Parse(TxtEndValue.Text);

            for (int i = start_value; i <= End_value; ++i)
            {
                string str_tmp = string.Empty;
                for (int j = start_value; j <= End_value; ++j)
                {
                    str_tmp += j.ToString();
                    //Display text
                }

                //step1: J=1; str_tmp=1
                //step2: J=2; str_tmp=12
                //step3: J=3; str_tmp=123
                //..step9

                //Basic
                //listBoxView.Items.Add("Line" + i + ": "+ str_tmp);

                //Professional
                listBoxView.Items.Add($"Line {i}: {str_tmp}");
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TxtStartValue.Text = "0";
            TxtStartValue.TextAlign = HorizontalAlignment.Center;

            TxtEndValue.Text = "0";
            TxtEndValue.TextAlign = HorizontalAlignment.Center;
        }

        private void BtnWhil_Click(object sender, EventArgs e)
        {
            
        }
    }
}
