namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblName = new Label();
            TxtName = new TextBox();
            BtnView = new Button();
            LblID = new Label();
            TxtID = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(56, 48);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Name:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(129, 48);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(169, 23);
            TxtName.TabIndex = 1;
            // 
            // BtnView
            // 
            BtnView.Location = new Point(129, 144);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(169, 47);
            BtnView.TabIndex = 2;
            BtnView.Text = "View";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Location = new Point(59, 95);
            LblID.Name = "LblID";
            LblID.Size = new Size(21, 15);
            LblID.TabIndex = 3;
            LblID.Text = "ID:";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(129, 92);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(169, 23);
            TxtID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 210);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TxtID);
            Controls.Add(LblID);
            Controls.Add(BtnView);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Button BtnView;
        private Label LblID;
        private TextBox TxtID;
        private Label label1;
        private TextBox textBox1;
    }
}
