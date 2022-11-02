namespace ATM
{
    partial class Transfer
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
            this.GoBack_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Account_B = new System.Windows.Forms.Button();
            this.Select_Amount_B = new System.Windows.Forms.Button();
            this.Transfer_B = new System.Windows.Forms.Button();
            this.Transfer_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoBack_B
            // 
            this.GoBack_B.Location = new System.Drawing.Point(272, 12);
            this.GoBack_B.Name = "GoBack_B";
            this.GoBack_B.Size = new System.Drawing.Size(75, 23);
            this.GoBack_B.TabIndex = 8;
            this.GoBack_B.Text = "Go Back";
            this.GoBack_B.UseVisualStyleBackColor = true;
            this.GoBack_B.Click += new System.EventHandler(this.GoBack_B_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transfer Balance to Another Account";
            // 
            // Select_Account_B
            // 
            this.Select_Account_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Select_Account_B.Location = new System.Drawing.Point(19, 108);
            this.Select_Account_B.Name = "Select_Account_B";
            this.Select_Account_B.Size = new System.Drawing.Size(157, 81);
            this.Select_Account_B.TabIndex = 10;
            this.Select_Account_B.Text = "Select Account";
            this.Select_Account_B.UseVisualStyleBackColor = true;
            this.Select_Account_B.Click += new System.EventHandler(this.Select_Account_B_Click);
            // 
            // Select_Amount_B
            // 
            this.Select_Amount_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Select_Amount_B.Location = new System.Drawing.Point(182, 108);
            this.Select_Amount_B.Name = "Select_Amount_B";
            this.Select_Amount_B.Size = new System.Drawing.Size(157, 81);
            this.Select_Amount_B.TabIndex = 11;
            this.Select_Amount_B.Text = "Select Amount";
            this.Select_Amount_B.UseVisualStyleBackColor = true;
            this.Select_Amount_B.Click += new System.EventHandler(this.Select_Amount_B_Click);
            // 
            // Transfer_B
            // 
            this.Transfer_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transfer_B.Location = new System.Drawing.Point(101, 227);
            this.Transfer_B.Name = "Transfer_B";
            this.Transfer_B.Size = new System.Drawing.Size(157, 81);
            this.Transfer_B.TabIndex = 12;
            this.Transfer_B.Text = "Transfer";
            this.Transfer_B.UseVisualStyleBackColor = true;
            this.Transfer_B.VisibleChanged += new System.EventHandler(this.Transfer_B_VisibleChanged);
            this.Transfer_B.Click += new System.EventHandler(this.Transfer_B_Click);
            // 
            // Transfer_L
            // 
            this.Transfer_L.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transfer_L.Location = new System.Drawing.Point(19, 192);
            this.Transfer_L.Name = "Transfer_L";
            this.Transfer_L.Size = new System.Drawing.Size(320, 34);
            this.Transfer_L.TabIndex = 13;
            this.Transfer_L.Text = "Transfer £<amount> to <accountid>";
            this.Transfer_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 331);
            this.Controls.Add(this.Transfer_L);
            this.Controls.Add(this.Transfer_B);
            this.Controls.Add(this.Select_Amount_B);
            this.Controls.Add(this.Select_Account_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBack_B);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button GoBack_B;
        private Label label1;
        private Button Select_Account_B;
        private Button Select_Amount_B;
        private Button Transfer_B;
        private Label Transfer_L;
    }
}