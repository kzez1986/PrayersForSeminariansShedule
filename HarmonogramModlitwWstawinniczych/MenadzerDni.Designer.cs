namespace MenadżerDni
{
    partial class MenadzerDni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenadzerDni));
            this.liDni = new System.Windows.Forms.ListBox();
            this.buDodaj = new System.Windows.Forms.Button();
            this.buUsuń = new System.Windows.Forms.Button();
            this.caData = new System.Windows.Forms.MonthCalendar();
            this.teOpis = new System.Windows.Forms.TextBox();
            this.buZapisz = new System.Windows.Forms.Button();
            this.buAnuluj = new System.Windows.Forms.Button();
            this.laOpis = new System.Windows.Forms.Label();
            this.buWdół = new System.Windows.Forms.Button();
            this.buWgórę = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liDni
            // 
            this.liDni.FormattingEnabled = true;
            this.liDni.Location = new System.Drawing.Point(12, 12);
            this.liDni.Name = "liDni";
            this.liDni.Size = new System.Drawing.Size(191, 225);
            this.liDni.TabIndex = 0;
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(12, 243);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(75, 23);
            this.buDodaj.TabIndex = 1;
            this.buDodaj.Text = "Dodaj";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(93, 243);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(75, 23);
            this.buUsuń.TabIndex = 2;
            this.buUsuń.Text = "Usuń";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.buUsuń_Click);
            // 
            // caData
            // 
            this.caData.Location = new System.Drawing.Point(290, 18);
            this.caData.Name = "caData";
            this.caData.TabIndex = 3;
            this.caData.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.caData_DateSelected);
            this.caData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.caData_DateChanged);
            // 
            // teOpis
            // 
            this.teOpis.Location = new System.Drawing.Point(215, 207);
            this.teOpis.Name = "teOpis";
            this.teOpis.Size = new System.Drawing.Size(296, 20);
            this.teOpis.TabIndex = 4;
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(260, 243);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(107, 23);
            this.buZapisz.TabIndex = 5;
            this.buZapisz.Text = "Zapisz i zamknij";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // buAnuluj
            // 
            this.buAnuluj.Location = new System.Drawing.Point(386, 243);
            this.buAnuluj.Name = "buAnuluj";
            this.buAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buAnuluj.TabIndex = 6;
            this.buAnuluj.Text = "Anuluj";
            this.buAnuluj.UseVisualStyleBackColor = true;
            this.buAnuluj.Click += new System.EventHandler(this.buAnuluj_Click);
            // 
            // laOpis
            // 
            this.laOpis.AutoSize = true;
            this.laOpis.Location = new System.Drawing.Point(212, 182);
            this.laOpis.Name = "laOpis";
            this.laOpis.Size = new System.Drawing.Size(299, 13);
            this.laOpis.TabIndex = 9;
            this.laOpis.Text = "Wybierz datę jako opis dnia z kalendarza i/lub wpisz swój opis";
            // 
            // buWdół
            // 
            this.buWdół.Image = global::HarmonogramModlitwWstawinniczych.Properties.Resources.w_dol;
            this.buWdół.Location = new System.Drawing.Point(209, 128);
            this.buWdół.Name = "buWdół";
            this.buWdół.Size = new System.Drawing.Size(27, 27);
            this.buWdół.TabIndex = 8;
            this.buWdół.UseVisualStyleBackColor = true;
            this.buWdół.Click += new System.EventHandler(this.buWdół_Click);
            // 
            // buWgórę
            // 
            this.buWgórę.Image = ((System.Drawing.Image)(resources.GetObject("buWgórę.Image")));
            this.buWgórę.Location = new System.Drawing.Point(209, 92);
            this.buWgórę.Name = "buWgórę";
            this.buWgórę.Size = new System.Drawing.Size(27, 27);
            this.buWgórę.TabIndex = 7;
            this.buWgórę.UseVisualStyleBackColor = true;
            this.buWgórę.Click += new System.EventHandler(this.buWgórę_Click);
            // 
            // MenadzerDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 301);
            this.ControlBox = false;
            this.Controls.Add(this.laOpis);
            this.Controls.Add(this.buWdół);
            this.Controls.Add(this.buWgórę);
            this.Controls.Add(this.buAnuluj);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.teOpis);
            this.Controls.Add(this.caData);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.liDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenadzerDni";
            this.Text = "Menedzer dni";
            this.Load += new System.EventHandler(this.MenadzerDni_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenadzerDni_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liDni;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.MonthCalendar caData;
        private System.Windows.Forms.TextBox teOpis;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Button buAnuluj;
        private System.Windows.Forms.Button buWgórę;
        private System.Windows.Forms.Button buWdół;
        private System.Windows.Forms.Label laOpis;
    }
}