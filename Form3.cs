using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Input value to combobox

            CboOption.Items.Clear();
            CboOption.Items.Add("+");   //Index =0
            CboOption.Items.Add("-");   //Index =1
            CboOption.Items.Add("*");   //Index =2
            CboOption.Items.Add("/");   //Index =3

            //Auto select when form load
            string v = CboOption.Items[0].ToString();
            CboOption.Text = v;

            //Input value to textbox
            TxtInput1.Text = "0.00";
            TxtInput2.Text = "0.00";
            TxtInput3.Text = "0.00";
            TxtView.Text = "0.00";
            TxtView.Enabled = false;

        }

        private void TxtInput1_TextChanged(object sender, EventArgs e)
        {

            //if(TxtInput1.Text is null)
            //{
            //    TxtInput1.Text = "0";
            //}

            // double Input1 = double.Parse (TxtInput1.Text);
            // //double Input2 = double.Parse(TxtInput2.Text.ToString());
            // //double Input3 = double.Parse(this.TxtInput3.Text);

            // double views = Input1;
            //TxtView.Text = views.ToString();

        }

        private void ButView_Click(object sender, EventArgs e)
        {
            string tmp_str = CboOption.Text;
            double value1 = double.Parse(TxtInput1.Text.ToString());
            double value2 = double.Parse(TxtInput2.Text.ToString());
            double value3 = double.Parse(TxtInput3.Text.ToString());
            double tmp_view = 0;

            

            if (tmp_str == "+")
            {
                //........
                tmp_view = value1 + value2 + value3;
                TxtView.Text = tmp_view.ToString();
                return;
            }

            if (tmp_str == "-")
            {
                //........
                return;
            }

            if (tmp_str == "*")
            {
                //........
                return;
            }

            if (tmp_str == "/")
            {
                return;
            }           
           

        }

        private void TxtInput1_Validated(object sender, EventArgs e)
        {

        }

        private void TxtInput1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ButViewSwitch_Click(object sender, EventArgs e)
        {
            string tmp_str = CboOption.Text;
            double value1 = double.Parse(TxtInput1.Text.ToString());
            double value2 = double.Parse(TxtInput2.Text.ToString());
            double value3 = double.Parse(TxtInput3.Text.ToString());
            double tmp_view = 0;

            switch (tmp_str)
            {
                case "+":
                    tmp_view = value1 + value2 + value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "-":
                    tmp_view = value1 - value2 - value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "*":
                    tmp_view = value1 * value2 * value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "/":
                    //tmp_view = value1 + value2 + value3;
                    //TxtView.Text = tmp_view.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
