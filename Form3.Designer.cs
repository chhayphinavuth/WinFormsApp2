namespace WinFormsApp2
{
    partial class Form3
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
            CboOption = new ComboBox();
            TxtInput1 = new TextBox();
            LblOption = new Label();
            LblInput1 = new Label();
            TxtInput2 = new TextBox();
            label3 = new Label();
            TxtInput3 = new TextBox();
            TxtView = new TextBox();
            LblIput3 = new Label();
            ButView = new Button();
            ButViewSwitch = new Button();
            SuspendLayout();
            // 
            // CboOption
            // 
            CboOption.FormattingEnabled = true;
            CboOption.Location = new Point(143, 37);
            CboOption.Name = "CboOption";
            CboOption.Size = new Size(210, 23);
            CboOption.TabIndex = 0;
            // 
            // TxtInput1
            // 
            TxtInput1.Location = new Point(143, 75);
            TxtInput1.Name = "TxtInput1";
            TxtInput1.Size = new Size(210, 23);
            TxtInput1.TabIndex = 1;
            TxtInput1.TextChanged += TxtInput1_TextChanged;
            TxtInput1.Validating += TxtInput1_Validating;
            TxtInput1.Validated += TxtInput1_Validated;
            // 
            // LblOption
            // 
            LblOption.AutoSize = true;
            LblOption.Location = new Point(43, 37);
            LblOption.Name = "LblOption";
            LblOption.Size = new Size(47, 15);
            LblOption.TabIndex = 2;
            LblOption.Text = "Option:";
            // 
            // LblInput1
            // 
            LblInput1.AutoSize = true;
            LblInput1.Location = new Point(43, 78);
            LblInput1.Name = "LblInput1";
            LblInput1.Size = new Size(47, 15);
            LblInput1.TabIndex = 3;
            LblInput1.Text = "Input 1:";
            // 
            // TxtInput2
            // 
            TxtInput2.Location = new Point(143, 118);
            TxtInput2.Name = "TxtInput2";
            TxtInput2.Size = new Size(210, 23);
            TxtInput2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 118);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Input 2:";
            // 
            // TxtInput3
            // 
            TxtInput3.Location = new Point(143, 159);
            TxtInput3.Name = "TxtInput3";
            TxtInput3.Size = new Size(210, 23);
            TxtInput3.TabIndex = 6;
            // 
            // TxtView
            // 
            TxtView.Location = new Point(143, 199);
            TxtView.Name = "TxtView";
            TxtView.Size = new Size(210, 23);
            TxtView.TabIndex = 7;
            // 
            // LblIput3
            // 
            LblIput3.AutoSize = true;
            LblIput3.Location = new Point(43, 159);
            LblIput3.Name = "LblIput3";
            LblIput3.Size = new Size(47, 15);
            LblIput3.TabIndex = 8;
            LblIput3.Text = "Input 3:";
            // 
            // ButView
            // 
            ButView.Location = new Point(143, 238);
            ButView.Name = "ButView";
            ButView.Size = new Size(103, 35);
            ButView.TabIndex = 9;
            ButView.Text = "View";
            ButView.UseVisualStyleBackColor = true;
            ButView.Click += ButView_Click;
            // 
            // ButViewSwitch
            // 
            ButViewSwitch.Location = new Point(252, 238);
            ButViewSwitch.Name = "ButViewSwitch";
            ButViewSwitch.Size = new Size(101, 35);
            ButViewSwitch.TabIndex = 10;
            ButViewSwitch.Text = "View Switch";
            ButViewSwitch.UseVisualStyleBackColor = true;
            ButViewSwitch.Click += ButViewSwitch_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 315);
            Controls.Add(ButViewSwitch);
            Controls.Add(ButView);
            Controls.Add(LblIput3);
            Controls.Add(TxtView);
            Controls.Add(TxtInput3);
            Controls.Add(label3);
            Controls.Add(TxtInput2);
            Controls.Add(LblInput1);
            Controls.Add(LblOption);
            Controls.Add(TxtInput1);
            Controls.Add(CboOption);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboOption;
        private TextBox TxtInput1;
        private Label LblOption;
        private Label LblInput1;
        private TextBox TxtInput2;
        private Label label3;
        private TextBox TxtInput3;
        private TextBox TxtView;
        private Label LblIput3;
        private Button ButView;
        private Button ButViewSwitch;
    }
}