namespace ATM
{
    partial class ViewAccount
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
            this.AccountType_L = new System.Windows.Forms.Label();
            this.GoBack_B = new System.Windows.Forms.Button();
            this.Balance_L = new System.Windows.Forms.Label();
            this.CustomerDetails_L = new System.Windows.Forms.Label();
            this.CustomerAddress_L = new System.Windows.Forms.Label();
            this.AnnualSalary_L = new System.Windows.Forms.Label();
            this.Age_L = new System.Windows.Forms.Label();
            this.AccountId_L = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountType_L
            // 
            this.AccountType_L.AutoSize = true;
            this.AccountType_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountType_L.Location = new System.Drawing.Point(12, 9);
            this.AccountType_L.Name = "AccountType_L";
            this.AccountType_L.Size = new System.Drawing.Size(167, 30);
            this.AccountType_L.TabIndex = 0;
            this.AccountType_L.Text = "<account type>";
            // 
            // GoBack_B
            // 
            this.GoBack_B.Location = new System.Drawing.Point(272, 12);
            this.GoBack_B.Name = "GoBack_B";
            this.GoBack_B.Size = new System.Drawing.Size(75, 23);
            this.GoBack_B.TabIndex = 7;
            this.GoBack_B.Text = "Go Back";
            this.GoBack_B.UseVisualStyleBackColor = true;
            this.GoBack_B.Click += new System.EventHandler(this.GoBack_B_Click);
            // 
            // Balance_L
            // 
            this.Balance_L.AutoSize = true;
            this.Balance_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Balance_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Balance_L.Location = new System.Drawing.Point(3, 60);
            this.Balance_L.Name = "Balance_L";
            this.Balance_L.Size = new System.Drawing.Size(117, 30);
            this.Balance_L.TabIndex = 8;
            this.Balance_L.Text = "<balance>";
            // 
            // CustomerDetails_L
            // 
            this.CustomerDetails_L.AutoSize = true;
            this.CustomerDetails_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerDetails_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerDetails_L.Location = new System.Drawing.Point(3, 99);
            this.CustomerDetails_L.Name = "CustomerDetails_L";
            this.CustomerDetails_L.Size = new System.Drawing.Size(195, 30);
            this.CustomerDetails_L.TabIndex = 9;
            this.CustomerDetails_L.Text = "<customerdetails>";
            // 
            // CustomerAddress_L
            // 
            this.CustomerAddress_L.AutoSize = true;
            this.CustomerAddress_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerAddress_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerAddress_L.Location = new System.Drawing.Point(6, 159);
            this.CustomerAddress_L.Name = "CustomerAddress_L";
            this.CustomerAddress_L.Size = new System.Drawing.Size(208, 30);
            this.CustomerAddress_L.TabIndex = 10;
            this.CustomerAddress_L.Text = "<customeraddress>";
            // 
            // AnnualSalary_L
            // 
            this.AnnualSalary_L.AutoSize = true;
            this.AnnualSalary_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AnnualSalary_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnualSalary_L.Location = new System.Drawing.Point(6, 30);
            this.AnnualSalary_L.Name = "AnnualSalary_L";
            this.AnnualSalary_L.Size = new System.Drawing.Size(161, 30);
            this.AnnualSalary_L.TabIndex = 11;
            this.AnnualSalary_L.Text = "<annualsalary>";
            // 
            // Age_L
            // 
            this.Age_L.AutoSize = true;
            this.Age_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Age_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Age_L.Location = new System.Drawing.Point(3, 129);
            this.Age_L.Name = "Age_L";
            this.Age_L.Size = new System.Drawing.Size(169, 30);
            this.Age_L.TabIndex = 12;
            this.Age_L.Text = "<customerage>";
            // 
            // AccountId_L
            // 
            this.AccountId_L.AutoSize = true;
            this.AccountId_L.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountId_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountId_L.Location = new System.Drawing.Point(6, 0);
            this.AccountId_L.Name = "AccountId_L";
            this.AccountId_L.Size = new System.Drawing.Size(137, 30);
            this.AccountId_L.TabIndex = 13;
            this.AccountId_L.Text = "<accountId>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.CustomerAddress_L);
            this.panel1.Controls.Add(this.Age_L);
            this.panel1.Controls.Add(this.AccountId_L);
            this.panel1.Controls.Add(this.AnnualSalary_L);
            this.panel1.Controls.Add(this.CustomerDetails_L);
            this.panel1.Controls.Add(this.Balance_L);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 197);
            this.panel1.TabIndex = 14;
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 271);
            this.Controls.Add(this.GoBack_B);
            this.Controls.Add(this.AccountType_L);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAccount";
            this.VisibleChanged += new System.EventHandler(this.ViewAccount_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AccountType_L;
        private Button GoBack_B;
        private Label Balance_L;
        private Label CustomerDetails_L;
        private Label CustomerAddress_L;
        private Label AnnualSalary_L;
        private Label Age_L;
        private Label AccountId_L;
        private Panel panel1;
    }
}