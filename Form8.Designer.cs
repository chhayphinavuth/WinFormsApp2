namespace WinFormsApp2
{
    partial class Form8
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
            LblServer = new Label();
            CboServer = new ComboBox();
            LblDatabase = new Label();
            CboDatabase = new ComboBox();
            label1 = new Label();
            TxtUserID = new TextBox();
            TxtPwd = new TextBox();
            label2 = new Label();
            ButCheckConnection = new Button();
            CboAuthentication = new ComboBox();
            LblAuthentication = new Label();
            SuspendLayout();
            // 
            // LblServer
            // 
            LblServer.AutoSize = true;
            LblServer.Location = new Point(65, 64);
            LblServer.Name = "LblServer";
            LblServer.Size = new Size(42, 15);
            LblServer.TabIndex = 0;
            LblServer.Text = "Server:";
            // 
            // CboServer
            // 
            CboServer.FormattingEnabled = true;
            CboServer.Location = new Point(167, 64);
            CboServer.Name = "CboServer";
            CboServer.Size = new Size(197, 23);
            CboServer.TabIndex = 2;
            // 
            // LblDatabase
            // 
            LblDatabase.AutoSize = true;
            LblDatabase.Location = new Point(65, 106);
            LblDatabase.Name = "LblDatabase";
            LblDatabase.Size = new Size(58, 15);
            LblDatabase.TabIndex = 3;
            LblDatabase.Text = "Database:";
            // 
            // CboDatabase
            // 
            CboDatabase.FormattingEnabled = true;
            CboDatabase.Location = new Point(167, 106);
            CboDatabase.Name = "CboDatabase";
            CboDatabase.Size = new Size(197, 23);
            CboDatabase.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 159);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "User ID:";
            // 
            // TxtUserID
            // 
            TxtUserID.Location = new Point(167, 156);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(197, 23);
            TxtUserID.TabIndex = 4;
            // 
            // TxtPwd
            // 
            TxtPwd.Location = new Point(167, 203);
            TxtPwd.Name = "TxtPwd";
            TxtPwd.Size = new Size(197, 23);
            TxtPwd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 206);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // ButCheckConnection
            // 
            ButCheckConnection.Location = new Point(167, 244);
            ButCheckConnection.Name = "ButCheckConnection";
            ButCheckConnection.Size = new Size(197, 42);
            ButCheckConnection.TabIndex = 6;
            ButCheckConnection.Text = "&Check Connection";
            ButCheckConnection.UseVisualStyleBackColor = true;
            ButCheckConnection.Click += ButCheckConnection_Click;
            // 
            // CboAuthentication
            // 
            CboAuthentication.FormattingEnabled = true;
            CboAuthentication.Location = new Point(167, 23);
            CboAuthentication.Name = "CboAuthentication";
            CboAuthentication.Size = new Size(197, 23);
            CboAuthentication.TabIndex = 1;
            CboAuthentication.SelectedIndexChanged += CboAuthentication_SelectedIndexChanged;
            CboAuthentication.Leave += CboAuthentication_Leave;
            // 
            // LblAuthentication
            // 
            LblAuthentication.AutoSize = true;
            LblAuthentication.Location = new Point(65, 26);
            LblAuthentication.Name = "LblAuthentication";
            LblAuthentication.Size = new Size(89, 15);
            LblAuthentication.TabIndex = 10;
            LblAuthentication.Text = "Authentication:";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 312);
            Controls.Add(CboAuthentication);
            Controls.Add(LblAuthentication);
            Controls.Add(ButCheckConnection);
            Controls.Add(TxtPwd);
            Controls.Add(label2);
            Controls.Add(TxtUserID);
            Controls.Add(label1);
            Controls.Add(CboDatabase);
            Controls.Add(LblDatabase);
            Controls.Add(CboServer);
            Controls.Add(LblServer);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblServer;
        private ComboBox CboServer;
        private Label LblDatabase;
        private ComboBox CboDatabase;
        private Label label1;
        private TextBox TxtUserID;
        private TextBox TxtPwd;
        private Label label2;
        private Button ButCheckConnection;
        private ComboBox CboAuthentication;
        private Label LblAuthentication;
    }
}