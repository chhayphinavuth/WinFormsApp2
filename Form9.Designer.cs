namespace WinFormsApp2
{
    partial class Form9
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
            LblProductName = new Label();
            TxtProductName = new TextBox();
            listView1 = new ListView();
            BtnAddItems = new Button();
            BtnViewItems = new Button();
            TxtUnitPrice = new TextBox();
            LblUnitPrice = new Label();
            TxtQty = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Location = new Point(30, 28);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(107, 20);
            LblProductName.TabIndex = 0;
            LblProductName.Text = "Product Name:";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(152, 28);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(312, 27);
            TxtProductName.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(152, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(541, 240);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnAddItems
            // 
            BtnAddItems.Location = new Point(152, 162);
            BtnAddItems.Name = "BtnAddItems";
            BtnAddItems.Size = new Size(116, 48);
            BtnAddItems.TabIndex = 3;
            BtnAddItems.Text = "&Add Items";
            BtnAddItems.UseVisualStyleBackColor = true;
            // 
            // BtnViewItems
            // 
            BtnViewItems.Location = new Point(274, 162);
            BtnViewItems.Name = "BtnViewItems";
            BtnViewItems.Size = new Size(190, 48);
            BtnViewItems.TabIndex = 4;
            BtnViewItems.Text = "&View Items";
            BtnViewItems.UseVisualStyleBackColor = true;
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.Location = new Point(152, 71);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(312, 27);
            TxtUnitPrice.TabIndex = 6;
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Location = new Point(30, 71);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(75, 20);
            LblUnitPrice.TabIndex = 5;
            LblUnitPrice.Text = "Unit Price:";
            // 
            // TxtQty
            // 
            TxtQty.Location = new Point(152, 118);
            TxtQty.Name = "TxtQty";
            TxtQty.Size = new Size(312, 27);
            TxtQty.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 118);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "QTY:";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 505);
            Controls.Add(TxtQty);
            Controls.Add(label1);
            Controls.Add(TxtUnitPrice);
            Controls.Add(LblUnitPrice);
            Controls.Add(BtnViewItems);
            Controls.Add(BtnAddItems);
            Controls.Add(listView1);
            Controls.Add(TxtProductName);
            Controls.Add(LblProductName);
            Name = "Form9";
            Text = "Using Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblProductName;
        private TextBox TxtProductName;
        private ListView listView1;
        private Button BtnAddItems;
        private Button BtnViewItems;
        private TextBox TxtUnitPrice;
        private Label LblUnitPrice;
        private TextBox TxtQty;
        private Label label1;
    }
}