using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void MenuItemPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog();
            OPD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (OPD.ShowDialog() == DialogResult.OK)
            {
                PbPic1.Image = Image.FromFile(OPD.FileName);
                PbPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MenuItemPic2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog OPD = new OpenFileDialog();    //sample 1
            OpenFileDialog OPD = new ();
            
            
            OPD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (OPD.ShowDialog() == DialogResult.OK)
            {
                PbPic2.Image = Image.FromFile(OPD.FileName);
                PbPic2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void MenuItemClearPictures_Click(object sender, EventArgs e)
        {
            //PbPic1.Dispose();

            //Using Basic
            /*
             
            PbPic1.Image = null;
            PbPic2.Image = null;
            PbPic3.Image = null;
            PbPic4.Image = null;
            */

            //Using Professional code
            
            foreach (Control ctrl in tableLayoutPanel1.Controls) {

                if (ctrl is PictureBox pb && pb.Image != null) {

                    //pb.Image.Dispose();
                    pb.Image = null;
                
                }
            }
            

        }

        private void MenuItemPic3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog();
            OPD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (OPD.ShowDialog() == DialogResult.OK)
            {
                PbPic3.Image = Image.FromFile(OPD.FileName);
                PbPic3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void MenuItemPic4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog();
            OPD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (OPD.ShowDialog() == DialogResult.OK)
            {
                PbPic4.Image = Image.FromFile(OPD.FileName);
                PbPic4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
