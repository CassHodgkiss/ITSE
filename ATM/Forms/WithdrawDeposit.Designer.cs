namespace ATM
{
    partial class WithdrawDeposit
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
            this.Prompt_L = new System.Windows.Forms.Label();
            this.GoBack_B = new System.Windows.Forms.Button();
            this.Withdraw_B = new System.Windows.Forms.Button();
            this.Deposit_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prompt_L
            // 
            this.Prompt_L.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompt_L.Location = new System.Drawing.Point(12, 12);
            this.Prompt_L.Name = "Prompt_L";
            this.Prompt_L.Size = new System.Drawing.Size(247, 58);
            this.Prompt_L.TabIndex = 0;
            this.Prompt_L.Text = "Withdraw and Deposit into your Account";
            // 
            // GoBack_B
            // 
            this.GoBack_B.Location = new System.Drawing.Point(264, 12);
            this.GoBack_B.Name = "GoBack_B";
            this.GoBack_B.Size = new System.Drawing.Size(75, 23);
            this.GoBack_B.TabIndex = 5;
            this.GoBack_B.Text = "Go Back";
            this.GoBack_B.UseVisualStyleBackColor = true;
            this.GoBack_B.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Withdraw_B
            // 
            this.Withdraw_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Withdraw_B.Location = new System.Drawing.Point(15, 114);
            this.Withdraw_B.Name = "Withdraw_B";
            this.Withdraw_B.Size = new System.Drawing.Size(157, 81);
            this.Withdraw_B.TabIndex = 6;
            this.Withdraw_B.Text = "Withdraw";
            this.Withdraw_B.UseVisualStyleBackColor = true;
            this.Withdraw_B.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Deposit_B
            // 
            this.Deposit_B.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deposit_B.Location = new System.Drawing.Point(178, 114);
            this.Deposit_B.Name = "Deposit_B";
            this.Deposit_B.Size = new System.Drawing.Size(157, 81);
            this.Deposit_B.TabIndex = 7;
            this.Deposit_B.Text = "Deposit";
            this.Deposit_B.UseVisualStyleBackColor = true;
            this.Deposit_B.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // WithdrawDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.Deposit_B);
            this.Controls.Add(this.Withdraw_B);
            this.Controls.Add(this.GoBack_B);
            this.Controls.Add(this.Prompt_L);
            this.Name = "WithdrawDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawDeposit";
            this.VisibleChanged += new System.EventHandler(this.WithdrawDeposit_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Prompt_L;
        private Button GoBack_B;
        private Button Withdraw_B;
        private Button Deposit_B;
    }
}