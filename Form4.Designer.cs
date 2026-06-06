namespace WinFormsApp2
{
    partial class Form4
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
            BtnView1 = new Button();
            listBoxView = new ListBox();
            LblStartValue = new Label();
            TxtStartValue = new TextBox();
            TxtEndValue = new TextBox();
            LblEndValue = new Label();
            BtnWhil = new Button();
            BtnDo = new Button();
            SuspendLayout();
            // 
            // BtnView1
            // 
            BtnView1.Location = new Point(79, 241);
            BtnView1.Name = "BtnView1";
            BtnView1.Size = new Size(189, 69);
            BtnView1.TabIndex = 4;
            BtnView1.Text = "For (Loop)";
            BtnView1.UseVisualStyleBackColor = true;
            BtnView1.Click += BtnView1_Click;
            // 
            // listBoxView
            // 
            listBoxView.FormattingEnabled = true;
            listBoxView.Location = new Point(79, 96);
            listBoxView.Name = "listBoxView";
            listBoxView.Size = new Size(545, 139);
            listBoxView.TabIndex = 3;
            // 
            // LblStartValue
            // 
            LblStartValue.AutoSize = true;
            LblStartValue.Location = new Point(17, 14);
            LblStartValue.Name = "LblStartValue";
            LblStartValue.Size = new Size(34, 15);
            LblStartValue.TabIndex = 4;
            LblStartValue.Text = "Start:";
            // 
            // TxtStartValue
            // 
            TxtStartValue.Location = new Point(79, 14);
            TxtStartValue.Name = "TxtStartValue";
            TxtStartValue.Size = new Size(119, 23);
            TxtStartValue.TabIndex = 1;
            // 
            // TxtEndValue
            // 
            TxtEndValue.Location = new Point(79, 53);
            TxtEndValue.Name = "TxtEndValue";
            TxtEndValue.Size = new Size(119, 23);
            TxtEndValue.TabIndex = 2;
            // 
            // LblEndValue
            // 
            LblEndValue.AutoSize = true;
            LblEndValue.Location = new Point(17, 53);
            LblEndValue.Name = "LblEndValue";
            LblEndValue.Size = new Size(30, 15);
            LblEndValue.TabIndex = 6;
            LblEndValue.Text = "End:";
            // 
            // BtnWhil
            // 
            BtnWhil.Location = new Point(274, 241);
            BtnWhil.Name = "BtnWhil";
            BtnWhil.Size = new Size(173, 69);
            BtnWhil.TabIndex = 7;
            BtnWhil.Text = "While (Loop)";
            BtnWhil.UseVisualStyleBackColor = true;
            BtnWhil.Click += BtnWhil_Click;
            // 
            // BtnDo
            // 
            BtnDo.Location = new Point(453, 241);
            BtnDo.Name = "BtnDo";
            BtnDo.Size = new Size(171, 69);
            BtnDo.TabIndex = 8;
            BtnDo.Text = "Do (loop)";
            BtnDo.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 338);
            Controls.Add(BtnDo);
            Controls.Add(BtnWhil);
            Controls.Add(TxtEndValue);
            Controls.Add(LblEndValue);
            Controls.Add(TxtStartValue);
            Controls.Add(LblStartValue);
            Controls.Add(listBoxView);
            Controls.Add(BtnView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnView1;
        private ListBox listBoxView;
        private Label LblStartValue;
        private TextBox TxtStartValue;
        private TextBox TxtEndValue;
        private Label LblEndValue;
        private Button BtnWhil;
        private Button BtnDo;
    }
}