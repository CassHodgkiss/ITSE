namespace ATM
{
    partial class ViewStatement
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
            this.Statement_LB = new System.Windows.Forms.ListBox();
            this.GoBack_B = new System.Windows.Forms.Button();
            this.Prompt_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Statement_LB
            // 
            this.Statement_LB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Statement_LB.FormattingEnabled = true;
            this.Statement_LB.ItemHeight = 17;
            this.Statement_LB.Location = new System.Drawing.Point(18, 89);
            this.Statement_LB.Name = "Statement_LB";
            this.Statement_LB.Size = new System.Drawing.Size(323, 174);
            this.Statement_LB.TabIndex = 0;
            // 
            // GoBack_B
            // 
            this.GoBack_B.Location = new System.Drawing.Point(272, 12);
            this.GoBack_B.Name = "GoBack_B";
            this.GoBack_B.Size = new System.Drawing.Size(75, 23);
            this.GoBack_B.TabIndex = 6;
            this.GoBack_B.Text = "Go Back";
            this.GoBack_B.UseVisualStyleBackColor = true;
            this.GoBack_B.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Prompt_L
            // 
            this.Prompt_L.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompt_L.Location = new System.Drawing.Point(12, 12);
            this.Prompt_L.Name = "Prompt_L";
            this.Prompt_L.Size = new System.Drawing.Size(247, 58);
            this.Prompt_L.TabIndex = 7;
            this.Prompt_L.Text = "Your Statement";
            // 
            // ViewStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 281);
            this.Controls.Add(this.Prompt_L);
            this.Controls.Add(this.GoBack_B);
            this.Controls.Add(this.Statement_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStatement";
            this.VisibleChanged += new System.EventHandler(this.ViewStatement_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Statement_LB;
        private Button GoBack_B;
        private Label Prompt_L;
    }
}