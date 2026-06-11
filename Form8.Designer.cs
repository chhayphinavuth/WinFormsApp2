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
            LblUserID = new Label();
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
            LblServer.Location = new Point(74, 85);
            LblServer.Name = "LblServer";
            LblServer.Size = new Size(53, 20);
            LblServer.TabIndex = 0;
            LblServer.Text = "Server:";
            // 
            // CboServer
            // 
            CboServer.FormattingEnabled = true;
            CboServer.Location = new Point(191, 85);
            CboServer.Margin = new Padding(3, 4, 3, 4);
            CboServer.Name = "CboServer";
            CboServer.Size = new Size(225, 28);
            CboServer.TabIndex = 2;
            // 
            // LblDatabase
            // 
            LblDatabase.AutoSize = true;
            LblDatabase.Location = new Point(74, 141);
            LblDatabase.Name = "LblDatabase";
            LblDatabase.Size = new Size(75, 20);
            LblDatabase.TabIndex = 3;
            LblDatabase.Text = "Database:";
            // 
            // CboDatabase
            // 
            CboDatabase.FormattingEnabled = true;
            CboDatabase.Location = new Point(191, 141);
            CboDatabase.Margin = new Padding(3, 4, 3, 4);
            CboDatabase.Name = "CboDatabase";
            CboDatabase.Size = new Size(225, 28);
            CboDatabase.TabIndex = 3;
            // 
            // LblUserID
            // 
            LblUserID.AutoSize = true;
            LblUserID.Location = new Point(74, 212);
            LblUserID.Name = "LblUserID";
            LblUserID.Size = new Size(60, 20);
            LblUserID.TabIndex = 5;
            LblUserID.Text = "User ID:";
            // 
            // TxtUserID
            // 
            TxtUserID.Location = new Point(191, 208);
            TxtUserID.Margin = new Padding(3, 4, 3, 4);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(225, 27);
            TxtUserID.TabIndex = 4;
            // 
            // TxtPwd
            // 
            TxtPwd.Location = new Point(191, 271);
            TxtPwd.Margin = new Padding(3, 4, 3, 4);
            TxtPwd.Name = "TxtPwd";
            TxtPwd.Size = new Size(225, 27);
            TxtPwd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 275);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // ButCheckConnection
            // 
            ButCheckConnection.Location = new Point(191, 325);
            ButCheckConnection.Margin = new Padding(3, 4, 3, 4);
            ButCheckConnection.Name = "ButCheckConnection";
            ButCheckConnection.Size = new Size(225, 56);
            ButCheckConnection.TabIndex = 6;
            ButCheckConnection.Text = "&Check Connection";
            ButCheckConnection.UseVisualStyleBackColor = true;
            ButCheckConnection.Click += ButCheckConnection_Click;
            // 
            // CboAuthentication
            // 
            CboAuthentication.FormattingEnabled = true;
            CboAuthentication.Location = new Point(191, 31);
            CboAuthentication.Margin = new Padding(3, 4, 3, 4);
            CboAuthentication.Name = "CboAuthentication";
            CboAuthentication.Size = new Size(225, 28);
            CboAuthentication.TabIndex = 1;
            CboAuthentication.SelectedIndexChanged += CboAuthentication_SelectedIndexChanged;
            CboAuthentication.Leave += CboAuthentication_Leave;
            // 
            // LblAuthentication
            // 
            LblAuthentication.AutoSize = true;
            LblAuthentication.Location = new Point(74, 35);
            LblAuthentication.Name = "LblAuthentication";
            LblAuthentication.Size = new Size(109, 20);
            LblAuthentication.TabIndex = 10;
            LblAuthentication.Text = "Authentication:";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 416);
            Controls.Add(CboAuthentication);
            Controls.Add(LblAuthentication);
            Controls.Add(ButCheckConnection);
            Controls.Add(TxtPwd);
            Controls.Add(label2);
            Controls.Add(TxtUserID);
            Controls.Add(LblUserID);
            Controls.Add(CboDatabase);
            Controls.Add(LblDatabase);
            Controls.Add(CboServer);
            Controls.Add(LblServer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8";
            Text = "Connect Sql Database";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblServer;
        private ComboBox CboServer;
        private Label LblDatabase;
        private ComboBox CboDatabase;
        private Label LblUserID;
        private TextBox TxtUserID;
        private TextBox TxtPwd;
        private Label label2;
        private Button ButCheckConnection;
        private ComboBox CboAuthentication;
        private Label LblAuthentication;
    }
}