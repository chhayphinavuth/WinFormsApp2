namespace WinFormsApp2
{
    partial class Form5
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
            LblNumberList = new Label();
            CboNumberList = new ComboBox();
            BtnAdd = new Button();
            BtnRemove = new Button();
            BtnClear = new Button();
            BtnSearch = new Button();
            LblSearchValue = new Label();
            TxtSearchValue = new TextBox();
            SuspendLayout();
            // 
            // LblNumberList
            // 
            LblNumberList.AutoSize = true;
            LblNumberList.Location = new Point(28, 40);
            LblNumberList.Name = "LblNumberList";
            LblNumberList.Size = new Size(75, 15);
            LblNumberList.TabIndex = 0;
            LblNumberList.Text = "Number List:";
            // 
            // CboNumberList
            // 
            CboNumberList.FormattingEnabled = true;
            CboNumberList.Location = new Point(109, 40);
            CboNumberList.Name = "CboNumberList";
            CboNumberList.Size = new Size(351, 23);
            CboNumberList.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(109, 91);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(113, 36);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add (+)";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(228, 91);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(113, 36);
            BtnRemove.TabIndex = 3;
            BtnRemove.Text = "Remove (-)";
            BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(347, 91);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(113, 36);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(109, 206);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(351, 48);
            BtnSearch.TabIndex = 5;
            BtnSearch.Text = "Search...";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // LblSearchValue
            // 
            LblSearchValue.AutoSize = true;
            LblSearchValue.Location = new Point(28, 180);
            LblSearchValue.Name = "LblSearchValue";
            LblSearchValue.Size = new Size(77, 15);
            LblSearchValue.TabIndex = 6;
            LblSearchValue.Text = "Search Value:";
            // 
            // TxtSearchValue
            // 
            TxtSearchValue.Location = new Point(109, 177);
            TxtSearchValue.Name = "TxtSearchValue";
            TxtSearchValue.Size = new Size(351, 23);
            TxtSearchValue.TabIndex = 7;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 276);
            Controls.Add(TxtSearchValue);
            Controls.Add(LblSearchValue);
            Controls.Add(BtnSearch);
            Controls.Add(BtnClear);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAdd);
            Controls.Add(CboNumberList);
            Controls.Add(LblNumberList);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNumberList;
        private ComboBox CboNumberList;
        private Button BtnAdd;
        private Button BtnRemove;
        private Button BtnClear;
        private Button BtnSearch;
        private Label LblSearchValue;
        private TextBox TxtSearchValue;
    }
}