namespace Automobile
{
    partial class Form1
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
            this.ACCENDI = new System.Windows.Forms.Button();
            this.SPEGNI = new System.Windows.Forms.Button();
            this.ACC = new System.Windows.Forms.Button();
            this.FRENO = new System.Windows.Forms.Button();
            this.AUM = new System.Windows.Forms.Button();
            this.DIM = new System.Windows.Forms.Button();
            this.MARCIA = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ACCENDI
            // 
            this.ACCENDI.Location = new System.Drawing.Point(123, 179);
            this.ACCENDI.Name = "ACCENDI";
            this.ACCENDI.Size = new System.Drawing.Size(89, 72);
            this.ACCENDI.TabIndex = 0;
            this.ACCENDI.Text = "ACCENDI";
            this.ACCENDI.UseVisualStyleBackColor = true;
            this.ACCENDI.Click += new System.EventHandler(this.ACCENDI_Click);
            // 
            // SPEGNI
            // 
            this.SPEGNI.Location = new System.Drawing.Point(123, 257);
            this.SPEGNI.Name = "SPEGNI";
            this.SPEGNI.Size = new System.Drawing.Size(89, 72);
            this.SPEGNI.TabIndex = 1;
            this.SPEGNI.Text = "SPEGNI";
            this.SPEGNI.UseVisualStyleBackColor = true;
            this.SPEGNI.Click += new System.EventHandler(this.SPEGNI_Click);
            // 
            // ACC
            // 
            this.ACC.Location = new System.Drawing.Point(218, 179);
            this.ACC.Name = "ACC";
            this.ACC.Size = new System.Drawing.Size(89, 72);
            this.ACC.TabIndex = 2;
            this.ACC.Text = "ACCELERATORE";
            this.ACC.UseVisualStyleBackColor = true;
            this.ACC.Click += new System.EventHandler(this.ACC_Click);
            // 
            // FRENO
            // 
            this.FRENO.Location = new System.Drawing.Point(218, 257);
            this.FRENO.Name = "FRENO";
            this.FRENO.Size = new System.Drawing.Size(89, 72);
            this.FRENO.TabIndex = 3;
            this.FRENO.Text = "FRENO";
            this.FRENO.UseVisualStyleBackColor = true;
            this.FRENO.Click += new System.EventHandler(this.FRENO_Click);
            // 
            // AUM
            // 
            this.AUM.Location = new System.Drawing.Point(313, 179);
            this.AUM.Name = "AUM";
            this.AUM.Size = new System.Drawing.Size(89, 72);
            this.AUM.TabIndex = 4;
            this.AUM.Text = "AUMENTA";
            this.AUM.UseVisualStyleBackColor = true;
            this.AUM.Click += new System.EventHandler(this.AUM_Click);
            // 
            // DIM
            // 
            this.DIM.Location = new System.Drawing.Point(313, 257);
            this.DIM.Name = "DIM";
            this.DIM.Size = new System.Drawing.Size(89, 72);
            this.DIM.TabIndex = 5;
            this.DIM.Text = "DIMINUISCI";
            this.DIM.UseVisualStyleBackColor = true;
            this.DIM.Click += new System.EventHandler(this.DIM_Click);
            // 
            // MARCIA
            // 
            this.MARCIA.AutoSize = true;
            this.MARCIA.Location = new System.Drawing.Point(332, 163);
            this.MARCIA.Name = "MARCIA";
            this.MARCIA.Size = new System.Drawing.Size(48, 13);
            this.MARCIA.TabIndex = 6;
            this.MARCIA.Text = "MARCIA";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(123, 335);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(89, 20);
            this.T1.TabIndex = 7;
            this.T1.Text = "spento";
            this.T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(218, 335);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(89, 20);
            this.T2.TabIndex = 8;
            this.T2.Text = "0";
            this.T2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(313, 335);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(89, 20);
            this.T3.TabIndex = 9;
            this.T3.Text = "N";
            this.T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 458);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.MARCIA);
            this.Controls.Add(this.DIM);
            this.Controls.Add(this.AUM);
            this.Controls.Add(this.FRENO);
            this.Controls.Add(this.ACC);
            this.Controls.Add(this.SPEGNI);
            this.Controls.Add(this.ACCENDI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ACCENDI;
        private System.Windows.Forms.Button SPEGNI;
        private System.Windows.Forms.Button ACC;
        private System.Windows.Forms.Button FRENO;
        private System.Windows.Forms.Button AUM;
        private System.Windows.Forms.Button DIM;
        private System.Windows.Forms.Label MARCIA;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
    }
}

