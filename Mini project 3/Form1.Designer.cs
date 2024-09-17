namespace Mini_project_3
{
    partial class Form1
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
            this.labelOrchestra = new System.Windows.Forms.Label();
            this.labelGrandTier = new System.Windows.Forms.Label();
            this.labelBalcony = new System.Windows.Forms.Label();
            this.textBoxOrchestraTickets = new System.Windows.Forms.TextBox();
            this.textBoxGrandTierTickets = new System.Windows.Forms.TextBox();
            this.textBoxBalconyTickets = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOrchestraText = new System.Windows.Forms.Label();
            this.labelGrandTierText = new System.Windows.Forms.Label();
            this.labelBalconyText = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelOrchestraRevenue = new System.Windows.Forms.Label();
            this.labelGrandTierRevenue = new System.Windows.Forms.Label();
            this.labelBalconyRevenue = new System.Windows.Forms.Label();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOrchestra
            // 
            this.labelOrchestra.AutoSize = true;
            this.labelOrchestra.Location = new System.Drawing.Point(48, 102);
            this.labelOrchestra.Name = "labelOrchestra";
            this.labelOrchestra.Size = new System.Drawing.Size(101, 16);
            this.labelOrchestra.TabIndex = 0;
            this.labelOrchestra.Text = "Orchestra Level";
            // 
            // labelGrandTier
            // 
            this.labelGrandTier.AutoSize = true;
            this.labelGrandTier.Location = new System.Drawing.Point(58, 154);
            this.labelGrandTier.Name = "labelGrandTier";
            this.labelGrandTier.Size = new System.Drawing.Size(71, 16);
            this.labelGrandTier.TabIndex = 1;
            this.labelGrandTier.Text = "Grand Tier";
            // 
            // labelBalcony
            // 
            this.labelBalcony.AutoSize = true;
            this.labelBalcony.Location = new System.Drawing.Point(73, 214);
            this.labelBalcony.Name = "labelBalcony";
            this.labelBalcony.Size = new System.Drawing.Size(56, 16);
            this.labelBalcony.TabIndex = 2;
            this.labelBalcony.Text = "Balcony";
            // 
            // textBoxOrchestraTickets
            // 
            this.textBoxOrchestraTickets.Location = new System.Drawing.Point(186, 96);
            this.textBoxOrchestraTickets.Name = "textBoxOrchestraTickets";
            this.textBoxOrchestraTickets.Size = new System.Drawing.Size(155, 22);
            this.textBoxOrchestraTickets.TabIndex = 3;
            // 
            // textBoxGrandTierTickets
            // 
            this.textBoxGrandTierTickets.Location = new System.Drawing.Point(186, 151);
            this.textBoxGrandTierTickets.Name = "textBoxGrandTierTickets";
            this.textBoxGrandTierTickets.Size = new System.Drawing.Size(155, 22);
            this.textBoxGrandTierTickets.TabIndex = 4;
            // 
            // textBoxBalconyTickets
            // 
            this.textBoxBalconyTickets.Location = new System.Drawing.Point(186, 208);
            this.textBoxBalconyTickets.Name = "textBoxBalconyTickets";
            this.textBoxBalconyTickets.Size = new System.Drawing.Size(155, 22);
            this.textBoxBalconyTickets.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(117, 274);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(179, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate Revenue";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ticket Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Revenue";
            // 
            // labelOrchestraText
            // 
            this.labelOrchestraText.AutoSize = true;
            this.labelOrchestraText.Location = new System.Drawing.Point(510, 102);
            this.labelOrchestraText.Name = "labelOrchestraText";
            this.labelOrchestraText.Size = new System.Drawing.Size(101, 16);
            this.labelOrchestraText.TabIndex = 9;
            this.labelOrchestraText.Text = "Orchestra Level";
            // 
            // labelGrandTierText
            // 
            this.labelGrandTierText.AutoSize = true;
            this.labelGrandTierText.Location = new System.Drawing.Point(525, 154);
            this.labelGrandTierText.Name = "labelGrandTierText";
            this.labelGrandTierText.Size = new System.Drawing.Size(71, 16);
            this.labelGrandTierText.TabIndex = 10;
            this.labelGrandTierText.Text = "Grand Tier";
            // 
            // labelBalconyText
            // 
            this.labelBalconyText.AutoSize = true;
            this.labelBalconyText.Location = new System.Drawing.Point(532, 206);
            this.labelBalconyText.Name = "labelBalconyText";
            this.labelBalconyText.Size = new System.Drawing.Size(56, 16);
            this.labelBalconyText.TabIndex = 11;
            this.labelBalconyText.Text = "Balcony";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(533, 300);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(170, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset All";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelOrchestraRevenue
            // 
            this.labelOrchestraRevenue.AutoSize = true;
            this.labelOrchestraRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrchestraRevenue.Location = new System.Drawing.Point(637, 102);
            this.labelOrchestraRevenue.Name = "labelOrchestraRevenue";
            this.labelOrchestraRevenue.Size = new System.Drawing.Size(2, 18);
            this.labelOrchestraRevenue.TabIndex = 13;
            // 
            // labelGrandTierRevenue
            // 
            this.labelGrandTierRevenue.AutoSize = true;
            this.labelGrandTierRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGrandTierRevenue.Location = new System.Drawing.Point(637, 154);
            this.labelGrandTierRevenue.Name = "labelGrandTierRevenue";
            this.labelGrandTierRevenue.Size = new System.Drawing.Size(2, 18);
            this.labelGrandTierRevenue.TabIndex = 14;
            // 
            // labelBalconyRevenue
            // 
            this.labelBalconyRevenue.AutoSize = true;
            this.labelBalconyRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBalconyRevenue.Location = new System.Drawing.Point(637, 206);
            this.labelBalconyRevenue.Name = "labelBalconyRevenue";
            this.labelBalconyRevenue.Size = new System.Drawing.Size(2, 18);
            this.labelBalconyRevenue.TabIndex = 15;
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalText.Location = new System.Drawing.Point(539, 258);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(43, 16);
            this.labelTotalText.TabIndex = 16;
            this.labelTotalText.Text = "Total";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.Location = new System.Drawing.Point(637, 258);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(2, 18);
            this.labelTotalRevenue.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.labelTotalText);
            this.Controls.Add(this.labelBalconyRevenue);
            this.Controls.Add(this.labelGrandTierRevenue);
            this.Controls.Add(this.labelOrchestraRevenue);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelBalconyText);
            this.Controls.Add(this.labelGrandTierText);
            this.Controls.Add(this.labelOrchestraText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxBalconyTickets);
            this.Controls.Add(this.textBoxGrandTierTickets);
            this.Controls.Add(this.textBoxOrchestraTickets);
            this.Controls.Add(this.labelBalcony);
            this.Controls.Add(this.labelGrandTier);
            this.Controls.Add(this.labelOrchestra);
            this.Name = "Form1";
            this.Text = "Theater Ticket Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrchestra;
        private System.Windows.Forms.Label labelGrandTier;
        private System.Windows.Forms.Label labelBalcony;
        private System.Windows.Forms.TextBox textBoxOrchestraTickets;
        private System.Windows.Forms.TextBox textBoxGrandTierTickets;
        private System.Windows.Forms.TextBox textBoxBalconyTickets;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOrchestraText;
        private System.Windows.Forms.Label labelGrandTierText;
        private System.Windows.Forms.Label labelBalconyText;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelOrchestraRevenue;
        private System.Windows.Forms.Label labelGrandTierRevenue;
        private System.Windows.Forms.Label labelBalconyRevenue;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelTotalRevenue;
    }
}

