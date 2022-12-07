namespace ATM.Forms
{
    partial class InsertCardSim
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
            this.Card_LB = new System.Windows.Forms.ListBox();
            this.EnterCard_B = new System.Windows.Forms.Button();
            this.DoesntExist_LB = new System.Windows.Forms.ListBox();
            this.Enter_DE_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Card_LB
            // 
            this.Card_LB.FormattingEnabled = true;
            this.Card_LB.ItemHeight = 15;
            this.Card_LB.Location = new System.Drawing.Point(12, 12);
            this.Card_LB.Name = "Card_LB";
            this.Card_LB.Size = new System.Drawing.Size(265, 154);
            this.Card_LB.TabIndex = 0;
            // 
            // EnterCard_B
            // 
            this.EnterCard_B.Location = new System.Drawing.Point(12, 172);
            this.EnterCard_B.Name = "EnterCard_B";
            this.EnterCard_B.Size = new System.Drawing.Size(265, 59);
            this.EnterCard_B.TabIndex = 1;
            this.EnterCard_B.Text = "Enter";
            this.EnterCard_B.UseVisualStyleBackColor = true;
            this.EnterCard_B.Click += new System.EventHandler(this.EnterCard_B_Click);
            // 
            // DoesntExist_LB
            // 
            this.DoesntExist_LB.FormattingEnabled = true;
            this.DoesntExist_LB.ItemHeight = 15;
            this.DoesntExist_LB.Location = new System.Drawing.Point(12, 247);
            this.DoesntExist_LB.Name = "DoesntExist_LB";
            this.DoesntExist_LB.Size = new System.Drawing.Size(265, 49);
            this.DoesntExist_LB.TabIndex = 2;
            // 
            // Enter_DE_B
            // 
            this.Enter_DE_B.Location = new System.Drawing.Point(12, 302);
            this.Enter_DE_B.Name = "Enter_DE_B";
            this.Enter_DE_B.Size = new System.Drawing.Size(265, 27);
            this.Enter_DE_B.TabIndex = 3;
            this.Enter_DE_B.Text = "Enter";
            this.Enter_DE_B.UseVisualStyleBackColor = true;
            this.Enter_DE_B.Click += new System.EventHandler(this.Enter_DE_B_Click);
            // 
            // InsertCardSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 342);
            this.Controls.Add(this.Enter_DE_B);
            this.Controls.Add(this.DoesntExist_LB);
            this.Controls.Add(this.EnterCard_B);
            this.Controls.Add(this.Card_LB);
            this.Name = "InsertCardSim";
            this.Text = "InsertCardSim";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Card_LB;
        private Button EnterCard_B;
        private ListBox DoesntExist_LB;
        private Button Enter_DE_B;
    }
}