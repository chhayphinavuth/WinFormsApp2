namespace WinFormsApp2
{
    partial class Form2
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
            LblValue1 = new Label();
            LblValue2 = new Label();
            LblResult = new Label();
            TxtValue1 = new TextBox();
            TxtValue2 = new TextBox();
            TxtResult = new TextBox();
            BtnAdition = new Button();
            BtnSub = new Button();
            BtnMultiple = new Button();
            BtnDivide = new Button();
            BtnModulus = new Button();
            TxtValue3 = new TextBox();
            LblValue3 = new Label();
            SuspendLayout();
            // 
            // LblValue1
            // 
            LblValue1.AutoSize = true;
            LblValue1.Location = new Point(29, 27);
            LblValue1.Name = "LblValue1";
            LblValue1.Size = new Size(48, 15);
            LblValue1.TabIndex = 0;
            LblValue1.Text = "Value 1:";
            // 
            // LblValue2
            // 
            LblValue2.AutoSize = true;
            LblValue2.Location = new Point(29, 61);
            LblValue2.Name = "LblValue2";
            LblValue2.Size = new Size(48, 15);
            LblValue2.TabIndex = 1;
            LblValue2.Text = "Value 2:";
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(29, 137);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(42, 15);
            LblResult.TabIndex = 2;
            LblResult.Text = "Result:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location = new Point(129, 22);
            TxtValue1.Name = "TxtValue1";
            TxtValue1.Size = new Size(150, 23);
            TxtValue1.TabIndex = 3;
            // 
            // TxtValue2
            // 
            TxtValue2.Location = new Point(129, 58);
            TxtValue2.Name = "TxtValue2";
            TxtValue2.Size = new Size(150, 23);
            TxtValue2.TabIndex = 4;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(129, 137);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(150, 23);
            TxtResult.TabIndex = 5;
            // 
            // BtnAdition
            // 
            BtnAdition.Location = new Point(294, 22);
            BtnAdition.Name = "BtnAdition";
            BtnAdition.Size = new Size(75, 42);
            BtnAdition.TabIndex = 6;
            BtnAdition.Text = "+";
            BtnAdition.UseVisualStyleBackColor = true;
            // 
            // BtnSub
            // 
            BtnSub.Location = new Point(375, 22);
            BtnSub.Name = "BtnSub";
            BtnSub.Size = new Size(72, 42);
            BtnSub.TabIndex = 7;
            BtnSub.Text = "-";
            BtnSub.UseVisualStyleBackColor = true;
            // 
            // BtnMultiple
            // 
            BtnMultiple.Location = new Point(294, 70);
            BtnMultiple.Name = "BtnMultiple";
            BtnMultiple.Size = new Size(75, 42);
            BtnMultiple.TabIndex = 8;
            BtnMultiple.Text = "*";
            BtnMultiple.UseVisualStyleBackColor = true;
            // 
            // BtnDivide
            // 
            BtnDivide.Location = new Point(375, 70);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(72, 42);
            BtnDivide.TabIndex = 9;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            // 
            // BtnModulus
            // 
            BtnModulus.Location = new Point(297, 118);
            BtnModulus.Name = "BtnModulus";
            BtnModulus.Size = new Size(150, 42);
            BtnModulus.TabIndex = 10;
            BtnModulus.Text = "%";
            BtnModulus.UseVisualStyleBackColor = true;
            // 
            // TxtValue3
            // 
            TxtValue3.Location = new Point(129, 102);
            TxtValue3.Name = "TxtValue3";
            TxtValue3.Size = new Size(150, 23);
            TxtValue3.TabIndex = 12;
            // 
            // LblValue3
            // 
            LblValue3.AutoSize = true;
            LblValue3.Location = new Point(29, 102);
            LblValue3.Name = "LblValue3";
            LblValue3.Size = new Size(48, 15);
            LblValue3.TabIndex = 11;
            LblValue3.Text = "Value 3:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 211);
            Controls.Add(TxtValue3);
            Controls.Add(LblValue3);
            Controls.Add(BtnModulus);
            Controls.Add(BtnDivide);
            Controls.Add(BtnMultiple);
            Controls.Add(BtnSub);
            Controls.Add(BtnAdition);
            Controls.Add(TxtResult);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(LblResult);
            Controls.Add(LblValue2);
            Controls.Add(LblValue1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValue1;
        private Label LblValue2;
        private Label LblResult;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private TextBox TxtResult;
        private Button BtnAdition;
        private Button BtnSub;
        private Button BtnMultiple;
        private Button BtnDivide;
        private Button BtnModulus;
        private TextBox TxtValue3;
        private Label LblValue3;
    }
}