using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TxtValue1.Text = "0.00";
            TxtValue2.Text = "0.00";
            TxtValue3.Text = "0.00";
            TxtResult.Text = "0.00";
            
            //TextAlignment
            TxtValue1.TextAlign = HorizontalAlignment.Center;
            TxtValue2.TextAlign = HorizontalAlignment.Center;
            TxtValue3.TextAlign = HorizontalAlignment.Center;
            TxtResult.TextAlign = HorizontalAlignment.Center;

            //change font name and size
            //TxtValue1.Font = new Font("Kh Battambang", 14);

        }
    }
}
