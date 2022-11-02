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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Transfer_B = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(264, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Logout_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(178, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 81);
            this.button2.TabIndex = 5;
            this.button2.Text = "Withdraw Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.WithdrawDeposit_Click);
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(178, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 81);
            this.button4.TabIndex = 7;
            this.button4.Text = "View Statement";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViewStatement_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 58);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select an Option";
            this.label1.VisibleChanged += new System.EventHandler(this.label1_VisibleChanged);
            // 
            // MainOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Transfer_B);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ViewAccount_B);
            this.Name = "MainOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ViewAccount_B;
        private Button button5;
        private Button button2;
        private Button Transfer_B;
        private Button button4;
        private Label label1;
    }
}