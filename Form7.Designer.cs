namespace WinFormsApp2
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            imageList1 = new ImageList(components);
            BtnCheck1 = new Button();
            BtnCheck2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            checkBoxOpt2 = new CheckBox();
            checkBoxOpt1 = new CheckBox();
            groupBox2 = new GroupBox();
            radioButtonOpt2 = new RadioButton();
            radioButtonOpt1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Add Bookmark.ico");
            imageList1.Images.SetKeyName(1, "Bookmark.ico");
            // 
            // BtnCheck1
            // 
            BtnCheck1.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck1.ImageKey = "Add Bookmark.ico";
            BtnCheck1.ImageList = imageList1;
            BtnCheck1.Location = new Point(33, 172);
            BtnCheck1.Name = "BtnCheck1";
            BtnCheck1.Size = new Size(211, 43);
            BtnCheck1.TabIndex = 0;
            BtnCheck1.Text = "Check 1";
            BtnCheck1.UseVisualStyleBackColor = true;
            // 
            // BtnCheck2
            // 
            BtnCheck2.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck2.ImageKey = "Bookmark.ico";
            BtnCheck2.ImageList = imageList1;
            BtnCheck2.Location = new Point(33, 221);
            BtnCheck2.Name = "BtnCheck2";
            BtnCheck2.Size = new Size(211, 44);
            BtnCheck2.TabIndex = 1;
            BtnCheck2.Text = "Check 2";
            BtnCheck2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxOpt2);
            groupBox1.Controls.Add(checkBoxOpt1);
            groupBox1.Location = new Point(33, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check Group";
            // 
            // checkBoxOpt2
            // 
            checkBoxOpt2.AutoSize = true;
            checkBoxOpt2.Location = new Point(17, 57);
            checkBoxOpt2.Name = "checkBoxOpt2";
            checkBoxOpt2.Size = new Size(68, 19);
            checkBoxOpt2.TabIndex = 1;
            checkBoxOpt2.Text = "Check 2";
            checkBoxOpt2.UseVisualStyleBackColor = true;
            checkBoxOpt2.CheckedChanged += checkBoxOpt2_CheckedChanged;
            // 
            // checkBoxOpt1
            // 
            checkBoxOpt1.AutoSize = true;
            checkBoxOpt1.Location = new Point(17, 32);
            checkBoxOpt1.Name = "checkBoxOpt1";
            checkBoxOpt1.Size = new Size(68, 19);
            checkBoxOpt1.TabIndex = 0;
            checkBoxOpt1.Text = "Check 1";
            checkBoxOpt1.UseVisualStyleBackColor = true;
            checkBoxOpt1.CheckedChanged += checkBoxOpt1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonOpt2);
            groupBox2.Controls.Add(radioButtonOpt1);
            groupBox2.Location = new Point(262, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Radio Group";
            // 
            // radioButtonOpt2
            // 
            radioButtonOpt2.AutoSize = true;
            radioButtonOpt2.Location = new Point(6, 47);
            radioButtonOpt2.Name = "radioButtonOpt2";
            radioButtonOpt2.Size = new Size(64, 19);
            radioButtonOpt2.TabIndex = 1;
            radioButtonOpt2.TabStop = true;
            radioButtonOpt2.Text = "Radio 2";
            radioButtonOpt2.UseVisualStyleBackColor = true;
            radioButtonOpt2.CheckedChanged += radioButtonOpt2_CheckedChanged;
            // 
            // radioButtonOpt1
            // 
            radioButtonOpt1.AutoSize = true;
            radioButtonOpt1.Location = new Point(6, 22);
            radioButtonOpt1.Name = "radioButtonOpt1";
            radioButtonOpt1.Size = new Size(64, 19);
            radioButtonOpt1.TabIndex = 0;
            radioButtonOpt1.TabStop = true;
            radioButtonOpt1.Text = "Radio 1";
            radioButtonOpt1.UseVisualStyleBackColor = true;
            radioButtonOpt1.CheckedChanged += radioButtonOpt1_CheckedChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(BtnCheck2);
            Controls.Add(BtnCheck1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button BtnCheck1;
        private Button BtnCheck2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBoxOpt2;
        private CheckBox checkBoxOpt1;
        private RadioButton radioButtonOpt1;
        private RadioButton radioButtonOpt2;
    }
}