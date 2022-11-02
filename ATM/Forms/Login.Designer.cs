namespace ATM
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Card_LB = new System.Windows.Forms.ListBox();
            this.EnterCard_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Card_LB
            // 
            this.Card_LB.ItemHeight = 15;
            this.Card_LB.Location = new System.Drawing.Point(12, 12);
            this.Card_LB.Name = "Card_LB";
            this.Card_LB.Size = new System.Drawing.Size(312, 169);
            this.Card_LB.TabIndex = 6;
            // 
            // EnterCard_B
            // 
            this.EnterCard_B.Location = new System.Drawing.Point(12, 203);
            this.EnterCard_B.Name = "EnterCard_B";
            this.EnterCard_B.Size = new System.Drawing.Size(312, 60);
            this.EnterCard_B.TabIndex = 7;
            this.EnterCard_B.Text = "Enter Card";
            this.EnterCard_B.UseVisualStyleBackColor = true;
            this.EnterCard_B.Click += new System.EventHandler(this.EnterCard_B_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 275);
            this.Controls.Add(this.EnterCard_B);
            this.Controls.Add(this.Card_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox Card_LB;
        private Button EnterCard_B;
    }
}