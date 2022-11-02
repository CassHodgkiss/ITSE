namespace ATM
{
    partial class InputBox
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
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.Submit_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prompt_L
            // 
            this.Prompt_L.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prompt_L.Location = new System.Drawing.Point(12, 9);
            this.Prompt_L.Name = "Prompt_L";
            this.Prompt_L.Size = new System.Drawing.Size(210, 40);
            this.Prompt_L.TabIndex = 0;
            this.Prompt_L.Text = "<prompt>";
            this.Prompt_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input_TB
            // 
            this.Input_TB.Location = new System.Drawing.Point(35, 81);
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.Size = new System.Drawing.Size(164, 23);
            this.Input_TB.TabIndex = 1;
            // 
            // Submit_B
            // 
            this.Submit_B.Location = new System.Drawing.Point(80, 134);
            this.Submit_B.Name = "Submit_B";
            this.Submit_B.Size = new System.Drawing.Size(75, 23);
            this.Submit_B.TabIndex = 2;
            this.Submit_B.Text = "Submit";
            this.Submit_B.UseVisualStyleBackColor = true;
            this.Submit_B.Click += new System.EventHandler(this.Submit_B_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 169);
            this.Controls.Add(this.Submit_B);
            this.Controls.Add(this.Input_TB);
            this.Controls.Add(this.Prompt_L);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<title>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Prompt_L;
        public TextBox Input_TB;
        private Button Submit_B;
    }
}