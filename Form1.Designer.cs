namespace Statistica_bar_Isii
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.RBO = new System.Windows.Forms.RadioButton();
            this.btnV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PBS = new System.Windows.Forms.ProgressBar();
            this.PBD = new System.Windows.Forms.ProgressBar();
            this.PBO = new System.Windows.Forms.ProgressBar();
            this.RBS = new System.Windows.Forms.RadioButton();
            this.Display = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Display);
            this.groupBox1.Controls.Add(this.RBS);
            this.groupBox1.Controls.Add(this.btnV);
            this.groupBox1.Controls.Add(this.RBO);
            this.groupBox1.Controls.Add(this.RBD);
            this.groupBox1.Location = new System.Drawing.Point(72, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PBO);
            this.groupBox2.Controls.Add(this.PBD);
            this.groupBox2.Controls.Add(this.PBS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(72, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vota la qualita del servizio BAR";
            // 
            // RBD
            // 
            this.RBD.AutoSize = true;
            this.RBD.Location = new System.Drawing.Point(304, 60);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(64, 17);
            this.RBD.TabIndex = 1;
            this.RBD.TabStop = true;
            this.RBD.Text = "Discreto";
            this.RBD.UseVisualStyleBackColor = true;
            this.RBD.CheckedChanged += new System.EventHandler(this.RBD_CheckedChanged);
            // 
            // RBO
            // 
            this.RBO.AutoSize = true;
            this.RBO.Location = new System.Drawing.Point(451, 60);
            this.RBO.Name = "RBO";
            this.RBO.Size = new System.Drawing.Size(55, 17);
            this.RBO.TabIndex = 2;
            this.RBO.TabStop = true;
            this.RBO.Text = "Ottimo";
            this.RBO.UseVisualStyleBackColor = true;
            this.RBO.CheckedChanged += new System.EventHandler(this.RBO_CheckedChanged);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(144, 112);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(382, 58);
            this.btnV.TabIndex = 3;
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scarso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discreto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ottimo";
            // 
            // PBS
            // 
            this.PBS.Location = new System.Drawing.Point(144, 58);
            this.PBS.Name = "PBS";
            this.PBS.Size = new System.Drawing.Size(501, 51);
            this.PBS.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBS.TabIndex = 3;
            this.PBS.Click += new System.EventHandler(this.PBS_Click);
            // 
            // PBD
            // 
            this.PBD.Location = new System.Drawing.Point(144, 143);
            this.PBD.Name = "PBD";
            this.PBD.Size = new System.Drawing.Size(501, 51);
            this.PBD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBD.TabIndex = 4;
            this.PBD.Click += new System.EventHandler(this.PBD_Click);
            // 
            // PBO
            // 
            this.PBO.Location = new System.Drawing.Point(144, 230);
            this.PBO.Name = "PBO";
            this.PBO.Size = new System.Drawing.Size(501, 51);
            this.PBO.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBO.TabIndex = 5;
            this.PBO.Click += new System.EventHandler(this.PBO_Click);
            // 
            // RBS
            // 
            this.RBS.AutoSize = true;
            this.RBS.Location = new System.Drawing.Point(160, 60);
            this.RBS.Name = "RBS";
            this.RBS.Size = new System.Drawing.Size(58, 17);
            this.RBS.TabIndex = 4;
            this.RBS.TabStop = true;
            this.RBS.Text = "Scarso";
            this.RBS.UseVisualStyleBackColor = true;
            this.RBS.CheckedChanged += new System.EventHandler(this.RBS_CheckedChanged);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(144, 207);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(382, 31);
            this.Display.TabIndex = 5;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Indagine statistica bar 1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.RadioButton RBO;
        private System.Windows.Forms.RadioButton RBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PBO;
        private System.Windows.Forms.ProgressBar PBD;
        private System.Windows.Forms.ProgressBar PBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBS;
        private System.Windows.Forms.TextBox Display;
    }
}

