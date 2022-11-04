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
            this.label2 = new System.Windows.Forms.Label();
            this.Language_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prompt_L = new System.Windows.Forms.Label();
            this.EnterCard_B = new System.Windows.Forms.Button();
            this.Card_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Language";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Language_CB
            // 
            this.Language_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language_CB.FormattingEnabled = true;
            this.Language_CB.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.Language_CB.Location = new System.Drawing.Point(334, 28);
            this.Language_CB.Name = "Language_CB";
            this.Language_CB.Size = new System.Drawing.Size(67, 23);
            this.Language_CB.TabIndex = 16;
            this.Language_CB.SelectedIndexChanged += new System.EventHandler(this.Language_CB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lloyds Bank ATM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prompt_L
            // 
            this.Prompt_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompt_L.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Prompt_L.Location = new System.Drawing.Point(12, 51);
            this.Prompt_L.Name = "Prompt_L";
            this.Prompt_L.Size = new System.Drawing.Size(312, 40);
            this.Prompt_L.TabIndex = 14;
            this.Prompt_L.Text = "Waiting For CreditCard";
            this.Prompt_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterCard_B
            // 
            this.EnterCard_B.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EnterCard_B.Location = new System.Drawing.Point(12, 299);
            this.EnterCard_B.Name = "EnterCard_B";
            this.EnterCard_B.Size = new System.Drawing.Size(312, 60);
            this.EnterCard_B.TabIndex = 13;
            this.EnterCard_B.Text = "Enter Card";
            this.EnterCard_B.UseVisualStyleBackColor = true;
            this.EnterCard_B.Click += new System.EventHandler(this.EnterCard_B_Click);
            // 
            // Card_LB
            // 
            this.Card_LB.ItemHeight = 15;
            this.Card_LB.Location = new System.Drawing.Point(12, 107);
            this.Card_LB.Name = "Card_LB";
            this.Card_LB.Size = new System.Drawing.Size(312, 169);
            this.Card_LB.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Language_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prompt_L);
            this.Controls.Add(this.EnterCard_B);
            this.Controls.Add(this.Card_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox Language_CB;
        private Label label1;
        private Label Prompt_L;
        private Button EnterCard_B;
        private ListBox Card_LB;
    }
}