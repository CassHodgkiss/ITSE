namespace ATM.Forms
{
    partial class ATMForm
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
            this.B1 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.ATMScreen = new System.Windows.Forms.Panel();
            this.MainOptions_P = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.WaitingForCard_P = new System.Windows.Forms.Panel();
            this.ATMScreen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.ForeColor = System.Drawing.Color.Snow;
            this.B1.Location = new System.Drawing.Point(12, 90);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 1;
            this.B1.Text = ">";
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B4.ForeColor = System.Drawing.Color.Snow;
            this.B4.Location = new System.Drawing.Point(568, 90);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(100, 100);
            this.B4.TabIndex = 3;
            this.B4.Text = "<";
            this.B4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // ATMScreen
            // 
            this.ATMScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ATMScreen.Controls.Add(this.WaitingForCard_P);
            this.ATMScreen.Controls.Add(this.MainOptions_P);
            this.ATMScreen.Controls.Add(this.panel1);
            this.ATMScreen.Location = new System.Drawing.Point(118, 31);
            this.ATMScreen.Name = "ATMScreen";
            this.ATMScreen.Size = new System.Drawing.Size(444, 383);
            this.ATMScreen.TabIndex = 0;
            // 
            // MainOptions_P
            // 
            this.MainOptions_P.Location = new System.Drawing.Point(3, 58);
            this.MainOptions_P.Name = "MainOptions_P";
            this.MainOptions_P.Size = new System.Drawing.Size(436, 320);
            this.MainOptions_P.TabIndex = 2;
            this.MainOptions_P.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lloyds Minster Bank ATM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.ForeColor = System.Drawing.Color.Snow;
            this.B2.Location = new System.Drawing.Point(12, 196);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 6;
            this.B2.Text = ">";
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.ForeColor = System.Drawing.Color.Snow;
            this.B3.Location = new System.Drawing.Point(12, 302);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 7;
            this.B3.Text = ">";
            this.B3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B5.ForeColor = System.Drawing.Color.Snow;
            this.B5.Location = new System.Drawing.Point(568, 196);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(100, 100);
            this.B5.TabIndex = 8;
            this.B5.Text = "<";
            this.B5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B6.ForeColor = System.Drawing.Color.Snow;
            this.B6.Location = new System.Drawing.Point(568, 302);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(100, 100);
            this.B6.TabIndex = 9;
            this.B6.Text = "<";
            this.B6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // WaitingForCard_P
            // 
            this.WaitingForCard_P.Location = new System.Drawing.Point(3, 58);
            this.WaitingForCard_P.Name = "WaitingForCard_P";
            this.WaitingForCard_P.Size = new System.Drawing.Size(436, 320);
            this.WaitingForCard_P.TabIndex = 3;
            this.WaitingForCard_P.Visible = false;
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.ATMScreen);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B1);
            this.MaximizeBox = false;
            this.Name = "ATMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATMForm";
            this.ATMScreen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button B1;
        private Button B4;
        private Panel ATMScreen;
        private Panel panel1;
        private Label label1;
        private Button B2;
        private Button B3;
        private Button B5;
        private Button B6;
        public Panel MainOptions_P;
        public Panel WaitingForCard_P;
    }
}