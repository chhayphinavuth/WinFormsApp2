namespace WinFormsApp2
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            MenuItemPic1 = new ToolStripMenuItem();
            MenuItemPic2 = new ToolStripMenuItem();
            MenuItemPic3 = new ToolStripMenuItem();
            MenuItemPic4 = new ToolStripMenuItem();
            MenuItemClearPictures = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            PbPic1 = new PictureBox();
            PbPic2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PbPic4 = new PictureBox();
            PbPic3 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbPic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPic2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbPic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPic3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { MenuItemPic1, MenuItemPic2, MenuItemPic3, MenuItemPic4, MenuItemClearPictures, toolStripSeparator1, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "&File";
            // 
            // MenuItemPic1
            // 
            MenuItemPic1.Name = "MenuItemPic1";
            MenuItemPic1.ShortcutKeys = Keys.Control | Keys.D1;
            MenuItemPic1.Size = new Size(203, 22);
            MenuItemPic1.Text = "Open Pic 1";
            MenuItemPic1.Click += MenuItemPic1_Click;
            // 
            // MenuItemPic2
            // 
            MenuItemPic2.Name = "MenuItemPic2";
            MenuItemPic2.ShortcutKeys = Keys.Control | Keys.D2;
            MenuItemPic2.Size = new Size(203, 22);
            MenuItemPic2.Text = "Open Pic 2";
            MenuItemPic2.Click += MenuItemPic2_Click;
            // 
            // MenuItemPic3
            // 
            MenuItemPic3.Name = "MenuItemPic3";
            MenuItemPic3.ShortcutKeys = Keys.Control | Keys.D3;
            MenuItemPic3.Size = new Size(203, 22);
            MenuItemPic3.Text = "Open Pic 3";
            MenuItemPic3.Click += MenuItemPic3_Click;
            // 
            // MenuItemPic4
            // 
            MenuItemPic4.Name = "MenuItemPic4";
            MenuItemPic4.ShortcutKeys = Keys.Control | Keys.D4;
            MenuItemPic4.Size = new Size(203, 22);
            MenuItemPic4.Text = "Open Pic 4";
            MenuItemPic4.Click += MenuItemPic4_Click;
            // 
            // MenuItemClearPictures
            // 
            MenuItemClearPictures.Name = "MenuItemClearPictures";
            MenuItemClearPictures.ShortcutKeys = Keys.Control | Keys.D0;
            MenuItemClearPictures.Size = new Size(203, 22);
            MenuItemClearPictures.Text = "Clear All Pictures";
            MenuItemClearPictures.Click += MenuItemClearPictures_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(203, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // PbPic1
            // 
            PbPic1.Dock = DockStyle.Fill;
            PbPic1.Location = new Point(3, 3);
            PbPic1.Name = "PbPic1";
            PbPic1.Size = new Size(394, 207);
            PbPic1.TabIndex = 1;
            PbPic1.TabStop = false;
            // 
            // PbPic2
            // 
            PbPic2.Dock = DockStyle.Fill;
            PbPic2.Location = new Point(403, 3);
            PbPic2.Name = "PbPic2";
            PbPic2.Size = new Size(394, 207);
            PbPic2.TabIndex = 2;
            PbPic2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PbPic4, 1, 1);
            tableLayoutPanel1.Controls.Add(PbPic3, 0, 1);
            tableLayoutPanel1.Controls.Add(PbPic1, 0, 0);
            tableLayoutPanel1.Controls.Add(PbPic2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 426);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // PbPic4
            // 
            PbPic4.Dock = DockStyle.Fill;
            PbPic4.Location = new Point(403, 216);
            PbPic4.Name = "PbPic4";
            PbPic4.Size = new Size(394, 207);
            PbPic4.TabIndex = 4;
            PbPic4.TabStop = false;
            // 
            // PbPic3
            // 
            PbPic3.Dock = DockStyle.Fill;
            PbPic3.Location = new Point(3, 216);
            PbPic3.Name = "PbPic3";
            PbPic3.Size = new Size(394, 207);
            PbPic3.TabIndex = 3;
            PbPic3.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbPic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPic2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbPic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPic3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem MenuItemPic1;
        private ToolStripMenuItem MenuItemPic2;
        private PictureBox PbPic1;
        private PictureBox PbPic2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox PbPic4;
        private PictureBox PbPic3;
        private ToolStripMenuItem MenuItemPic3;
        private ToolStripMenuItem MenuItemPic4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem MenuItemClearPictures;
    }
}