namespace SaleForm
{
    partial class SalaForm
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
            this.liSale = new System.Windows.Forms.ListBox();
            this.laOpis = new System.Windows.Forms.Label();
            this.laHarmonogram = new System.Windows.Forms.Label();
            this.buZapisz = new System.Windows.Forms.Button();
            this.buAnuluj = new System.Windows.Forms.Button();
            this.teOpis = new System.Windows.Forms.TextBox();
            this.buHarmonogram = new System.Windows.Forms.Button();
            this.buDodaj = new System.Windows.Forms.Button();
            this.buUsuń = new System.Windows.Forms.Button();
            this.pbHarmonogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHarmonogram)).BeginInit();
            this.SuspendLayout();
            // 
            // liSale
            // 
            this.liSale.FormattingEnabled = true;
            this.liSale.Location = new System.Drawing.Point(13, 13);
            this.liSale.Name = "liSale";
            this.liSale.Size = new System.Drawing.Size(171, 290);
            this.liSale.TabIndex = 0;
            // 
            // laOpis
            // 
            this.laOpis.AutoSize = true;
            this.laOpis.Location = new System.Drawing.Point(209, 22);
            this.laOpis.Name = "laOpis";
            this.laOpis.Size = new System.Drawing.Size(77, 13);
            this.laOpis.TabIndex = 1;
            this.laOpis.Text = "Podaj opis sali:";
            // 
            // laHarmonogram
            // 
            this.laHarmonogram.AutoSize = true;
            this.laHarmonogram.Location = new System.Drawing.Point(209, 53);
            this.laHarmonogram.Name = "laHarmonogram";
            this.laHarmonogram.Size = new System.Drawing.Size(76, 13);
            this.laHarmonogram.TabIndex = 2;
            this.laHarmonogram.Text = "Harmonogram:";
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(211, 280);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(75, 23);
            this.buZapisz.TabIndex = 3;
            this.buZapisz.Text = "Zapisz";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // buAnuluj
            // 
            this.buAnuluj.Location = new System.Drawing.Point(307, 280);
            this.buAnuluj.Name = "buAnuluj";
            this.buAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buAnuluj.TabIndex = 4;
            this.buAnuluj.Text = "Anuluj";
            this.buAnuluj.UseVisualStyleBackColor = true;
            // 
            // teOpis
            // 
            this.teOpis.Location = new System.Drawing.Point(322, 19);
            this.teOpis.Name = "teOpis";
            this.teOpis.Size = new System.Drawing.Size(100, 20);
            this.teOpis.TabIndex = 5;
            this.teOpis.Leave += new System.EventHandler(this.teOpis_Leave);
            // 
            // buHarmonogram
            // 
            this.buHarmonogram.Location = new System.Drawing.Point(322, 48);
            this.buHarmonogram.Name = "buHarmonogram";
            this.buHarmonogram.Size = new System.Drawing.Size(124, 23);
            this.buHarmonogram.TabIndex = 6;
            this.buHarmonogram.Text = "Utwórz harmonogram";
            this.buHarmonogram.UseVisualStyleBackColor = true;
            this.buHarmonogram.Click += new System.EventHandler(this.buHarmonogram_Click);
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(212, 97);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(75, 23);
            this.buDodaj.TabIndex = 7;
            this.buDodaj.Text = "Dodaj";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(307, 96);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(75, 23);
            this.buUsuń.TabIndex = 8;
            this.buUsuń.Text = "Usuń";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.buUsuń_Click);
            // 
            // pbHarmonogram
            // 
            this.pbHarmonogram.Location = new System.Drawing.Point(452, 48);
            this.pbHarmonogram.Name = "pbHarmonogram";
            this.pbHarmonogram.Size = new System.Drawing.Size(21, 21);
            this.pbHarmonogram.TabIndex = 9;
            this.pbHarmonogram.TabStop = false;
            // 
            // SalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 325);
            this.ControlBox = false;
            this.Controls.Add(this.pbHarmonogram);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.buHarmonogram);
            this.Controls.Add(this.teOpis);
            this.Controls.Add(this.buAnuluj);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.laHarmonogram);
            this.Controls.Add(this.laOpis);
            this.Controls.Add(this.liSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SalaForm";
            this.Text = "Kreator sal";
            this.Load += new System.EventHandler(this.SalaForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbHarmonogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liSale;
        private System.Windows.Forms.Label laOpis;
        private System.Windows.Forms.Label laHarmonogram;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Button buAnuluj;
        private System.Windows.Forms.TextBox teOpis;
        private System.Windows.Forms.Button buHarmonogram;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.PictureBox pbHarmonogram;
    }
}