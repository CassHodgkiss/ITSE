namespace ATM
{
    partial class MainOptions
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
            this.ViewAccount_B = new System.Windows.Forms.Button();
            this.Logout_B = new System.Windows.Forms.Button();
            this.WithdrawDeposit_B = new System.Windows.Forms.Button();
            this.Transfer_B = new System.Windows.Forms.Button();
            this.ViewStatement_B = new System.Windows.Forms.Button();
            this.Prompt_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewAccount_B
            // 
            this.ViewAccount_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAccount_B.Location = new System.Drawing.Point(15, 114);
            this.ViewAccount_B.Name = "ViewAccount_B";
            this.ViewAccount_B.Size = new System.Drawing.Size(157, 81);
            this.ViewAccount_B.TabIndex = 0;
            this.ViewAccount_B.Text = "View Account";
            this.ViewAccount_B.UseVisualStyleBackColor = true;
            this.ViewAccount_B.Click += new System.EventHandler(this.ViewAccount_Click);
            // 
            // Logout_B
            // 
            this.Logout_B.Location = new System.Drawing.Point(264, 12);
            this.Logout_B.Name = "Logout_B";
            this.Logout_B.Size = new System.Drawing.Size(75, 23);
            this.Logout_B.TabIndex = 4;
            this.Logout_B.Text = "Log Out";
            this.Logout_B.UseVisualStyleBackColor = true;
            this.Logout_B.Click += new System.EventHandler(this.Logout_Click);
            // 
            // WithdrawDeposit_B
            // 
            this.WithdrawDeposit_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawDeposit_B.Location = new System.Drawing.Point(178, 114);
            this.WithdrawDeposit_B.Name = "WithdrawDeposit_B";
            this.WithdrawDeposit_B.Size = new System.Drawing.Size(157, 81);
            this.WithdrawDeposit_B.TabIndex = 5;
            this.WithdrawDeposit_B.Text = "Withdraw Deposit";
            this.WithdrawDeposit_B.UseVisualStyleBackColor = true;
            this.WithdrawDeposit_B.Click += new System.EventHandler(this.WithdrawDeposit_Click);
            // 
            // Transfer_B
            // 
            this.Transfer_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transfer_B.Location = new System.Drawing.Point(15, 201);
            this.Transfer_B.Name = "Transfer_B";
            this.Transfer_B.Size = new System.Drawing.Size(157, 81);
            this.Transfer_B.TabIndex = 6;
            this.Transfer_B.Text = "Transfer";
            this.Transfer_B.UseVisualStyleBackColor = true;
            this.Transfer_B.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // ViewStatement_B
            // 
            this.ViewStatement_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewStatement_B.Location = new System.Drawing.Point(178, 201);
            this.ViewStatement_B.Name = "ViewStatement_B";
            this.ViewStatement_B.Size = new System.Drawing.Size(157, 81);
            this.ViewStatement_B.TabIndex = 7;
            this.ViewStatement_B.Text = "View Statement";
            this.ViewStatement_B.UseVisualStyleBackColor = true;
            this.ViewStatement_B.Click += new System.EventHandler(this.ViewStatement_Click);
            // 
            // Prompt_L
            // 
            this.Prompt_L.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompt_L.Location = new System.Drawing.Point(12, 9);
            this.Prompt_L.Name = "Prompt_L";
            this.Prompt_L.Size = new System.Drawing.Size(216, 58);
            this.Prompt_L.TabIndex = 10;
            this.Prompt_L.Text = "Select an Option";
            this.Prompt_L.VisibleChanged += new System.EventHandler(this.label1_VisibleChanged);
            // 
            // MainOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 297);
            this.Controls.Add(this.Prompt_L);
            this.Controls.Add(this.ViewStatement_B);
            this.Controls.Add(this.Transfer_B);
            this.Controls.Add(this.WithdrawDeposit_B);
            this.Controls.Add(this.Logout_B);
            this.Controls.Add(this.ViewAccount_B);
            this.Name = "MainOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ViewAccount_B;
        private Button Logout_B;
        private Button WithdrawDeposit_B;
        private Button Transfer_B;
        private Button ViewStatement_B;
        private Label Prompt_L;
    }
}