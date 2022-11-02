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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Withdraw_B = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Withdraw and Deposit into your Account";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(264, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Go Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GoBack_Click);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(178, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 81);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // WithdrawDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Withdraw_B);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawDeposit";
            this.VisibleChanged += new System.EventHandler(this.WithdrawDeposit_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button5;
        private Button Withdraw_B;
        private Button button2;
    }
}