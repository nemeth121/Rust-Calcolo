namespace Calcolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metalRes = new System.Windows.Forms.TextBox();
            this.stoneRes = new System.Windows.Forms.TextBox();
            this.woodRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giorniBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.hqmRes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.etichettaGiorni = new System.Windows.Forms.Label();
            this.woodText = new System.Windows.Forms.NumericUpDown();
            this.stoneText = new System.Windows.Forms.NumericUpDown();
            this.metalText = new System.Windows.Forms.NumericUpDown();
            this.hqmText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.giorniBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hqmText)).BeginInit();
            this.SuspendLayout();
            // 
            // metalRes
            // 
            this.metalRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metalRes.Location = new System.Drawing.Point(224, 142);
            this.metalRes.Name = "metalRes";
            this.metalRes.ReadOnly = true;
            this.metalRes.Size = new System.Drawing.Size(100, 20);
            this.metalRes.TabIndex = 6;
            this.metalRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stoneRes
            // 
            this.stoneRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stoneRes.Location = new System.Drawing.Point(118, 142);
            this.stoneRes.Name = "stoneRes";
            this.stoneRes.ReadOnly = true;
            this.stoneRes.Size = new System.Drawing.Size(100, 20);
            this.stoneRes.TabIndex = 5;
            this.stoneRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // woodRes
            // 
            this.woodRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.woodRes.Location = new System.Drawing.Point(12, 142);
            this.woodRes.Name = "woodRes";
            this.woodRes.ReadOnly = true;
            this.woodRes.Size = new System.Drawing.Size(100, 20);
            this.woodRes.TabIndex = 4;
            this.woodRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wood";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Metal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giorniBar
            // 
            this.giorniBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giorniBar.AutoSize = false;
            this.giorniBar.LargeChange = 2;
            this.giorniBar.Location = new System.Drawing.Point(12, 243);
            this.giorniBar.Maximum = 32;
            this.giorniBar.Name = "giorniBar";
            this.giorniBar.Size = new System.Drawing.Size(418, 45);
            this.giorniBar.TabIndex = 10;
            this.giorniBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Days:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hqmRes
            // 
            this.hqmRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hqmRes.Location = new System.Drawing.Point(330, 142);
            this.hqmRes.Name = "hqmRes";
            this.hqmRes.ReadOnly = true;
            this.hqmRes.Size = new System.Drawing.Size(100, 20);
            this.hqmRes.TabIndex = 13;
            this.hqmRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "HQM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "REQUIRED RESOURCES FOR 24H";
            // 
            // etichettaGiorni
            // 
            this.etichettaGiorni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etichettaGiorni.AutoSize = true;
            this.etichettaGiorni.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etichettaGiorni.Location = new System.Drawing.Point(241, 206);
            this.etichettaGiorni.Name = "etichettaGiorni";
            this.etichettaGiorni.Size = new System.Drawing.Size(30, 36);
            this.etichettaGiorni.TabIndex = 16;
            this.etichettaGiorni.Text = "0";
            // 
            // woodText
            // 
            this.woodText.AccessibleName = "woodRes";
            this.woodText.Location = new System.Drawing.Point(12, 47);
            this.woodText.Name = "woodText";
            this.woodText.Size = new System.Drawing.Size(100, 20);
            this.woodText.TabIndex = 17;
            // 
            // stoneText
            // 
            this.stoneText.Location = new System.Drawing.Point(118, 47);
            this.stoneText.Name = "stoneText";
            this.stoneText.Size = new System.Drawing.Size(100, 20);
            this.stoneText.TabIndex = 18;
            // 
            // metalText
            // 
            this.metalText.Location = new System.Drawing.Point(224, 47);
            this.metalText.Name = "metalText";
            this.metalText.Size = new System.Drawing.Size(100, 20);
            this.metalText.TabIndex = 19;
            // 
            // hqmText
            // 
            this.hqmText.Location = new System.Drawing.Point(330, 47);
            this.hqmText.Name = "hqmText";
            this.hqmText.Size = new System.Drawing.Size(100, 20);
            this.hqmText.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 315);
            this.Controls.Add(this.hqmText);
            this.Controls.Add(this.metalText);
            this.Controls.Add(this.stoneText);
            this.Controls.Add(this.woodText);
            this.Controls.Add(this.etichettaGiorni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hqmRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.giorniBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metalRes);
            this.Controls.Add(this.stoneRes);
            this.Controls.Add(this.woodRes);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rust Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giorniBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hqmText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox metalRes;
        private System.Windows.Forms.TextBox stoneRes;
        private System.Windows.Forms.TextBox woodRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar giorniBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hqmRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label etichettaGiorni;
        private System.Windows.Forms.NumericUpDown woodText;
        private System.Windows.Forms.NumericUpDown stoneText;
        private System.Windows.Forms.NumericUpDown metalText;
        private System.Windows.Forms.NumericUpDown hqmText;
    }
}

