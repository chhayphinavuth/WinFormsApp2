using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CboNumberList.Items.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int tmp_value = CboNumberList.Items.Count + 1;
            CboNumberList.Items.Add(tmp_value.ToString());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult tmp_message =
                MessageBox.Show("Do you want to clear items", "Confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (tmp_message)
            {
                case DialogResult.Yes:
                    CboNumberList.Items.Clear();
                    break;
                default:
                    break;
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string str_search= TxtSearchValue.Text;
            
            //Method 1
            foreach (var item in CboNumberList.Items)
            {
                string str_items = item.ToString();
                if (str_search == str_items)
                {
                    //diplay message box

                }
                else
                {
                    //disk play message box
                }
            }

            //Method 2
            int Ind = CboNumberList.Items.Count;
            for (int i=0; i< Ind; i++)
            {
                string str_items = CboNumberList.Items[i].ToString();

            }

        }
    }
}
