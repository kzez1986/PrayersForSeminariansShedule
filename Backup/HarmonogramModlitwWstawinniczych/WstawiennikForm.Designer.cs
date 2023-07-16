namespace WstawinnicyForma
{
    partial class WstawiennikForm
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
            this.liWstawiennicy = new System.Windows.Forms.ListBox();
            this.laImię = new System.Windows.Forms.Label();
            this.laNazwisko = new System.Windows.Forms.Label();
            this.laPłeć = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teImię = new System.Windows.Forms.TextBox();
            this.teNazwisko = new System.Windows.Forms.TextBox();
            this.coPłeć = new System.Windows.Forms.ComboBox();
            this.nuMaxModlitw = new System.Windows.Forms.NumericUpDown();
            this.laUwaga = new System.Windows.Forms.Label();
            this.buDodaj = new System.Windows.Forms.Button();
            this.buUsuń = new System.Windows.Forms.Button();
            this.buZapisz = new System.Windows.Forms.Button();
            this.buHarmonogram = new System.Windows.Forms.Button();
            this.buAnuluj = new System.Windows.Forms.Button();
            this.laHarmonogram = new System.Windows.Forms.Label();
            this.laUwaga2 = new System.Windows.Forms.Label();
            this.laDoświadczenie = new System.Windows.Forms.Label();
            this.coDoświadczenie = new System.Windows.Forms.ComboBox();
            this.cbEgzorcysta = new System.Windows.Forms.CheckBox();
            this.pbCzyHarmonogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxModlitw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCzyHarmonogram)).BeginInit();
            this.SuspendLayout();
            // 
            // liWstawiennicy
            // 
            this.liWstawiennicy.FormattingEnabled = true;
            this.liWstawiennicy.Location = new System.Drawing.Point(12, 12);
            this.liWstawiennicy.Name = "liWstawiennicy";
            this.liWstawiennicy.Size = new System.Drawing.Size(171, 290);
            this.liWstawiennicy.TabIndex = 0;
            this.liWstawiennicy.SelectedIndexChanged += new System.EventHandler(this.liWstawiennicy_SelectedIndexChanged);
            // 
            // laImię
            // 
            this.laImię.AutoSize = true;
            this.laImię.Location = new System.Drawing.Point(205, 15);
            this.laImię.Name = "laImię";
            this.laImię.Size = new System.Drawing.Size(58, 13);
            this.laImię.TabIndex = 1;
            this.laImię.Text = "Podaj imię:";
            // 
            // laNazwisko
            // 
            this.laNazwisko.AutoSize = true;
            this.laNazwisko.Location = new System.Drawing.Point(202, 72);
            this.laNazwisko.Name = "laNazwisko";
            this.laNazwisko.Size = new System.Drawing.Size(84, 13);
            this.laNazwisko.TabIndex = 2;
            this.laNazwisko.Text = "Podaj nazwisko:";
            this.laNazwisko.Click += new System.EventHandler(this.laNazwisko_Click);
            // 
            // laPłeć
            // 
            this.laPłeć.AutoSize = true;
            this.laPłeć.Location = new System.Drawing.Point(202, 96);
            this.laPłeć.Name = "laPłeć";
            this.laPłeć.Size = new System.Drawing.Size(33, 13);
            this.laPłeć.TabIndex = 3;
            this.laPłeć.Text = "Płeć:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max modlitw:";
            // 
            // teImię
            // 
            this.teImię.Location = new System.Drawing.Point(320, 12);
            this.teImię.Name = "teImię";
            this.teImię.Size = new System.Drawing.Size(100, 20);
            this.teImię.TabIndex = 5;
            this.teImię.TextChanged += new System.EventHandler(this.teImię_TextChanged);
            this.teImię.Leave += new System.EventHandler(this.teImię_Leave);
            // 
            // teNazwisko
            // 
            this.teNazwisko.Location = new System.Drawing.Point(320, 69);
            this.teNazwisko.Name = "teNazwisko";
            this.teNazwisko.Size = new System.Drawing.Size(100, 20);
            this.teNazwisko.TabIndex = 6;
            this.teNazwisko.Leave += new System.EventHandler(this.teNazwisko_Leave);
            // 
            // coPłeć
            // 
            this.coPłeć.FormattingEnabled = true;
            this.coPłeć.Items.AddRange(new object[] {
            "Chłopak",
            "Dziewczyna"});
            this.coPłeć.Location = new System.Drawing.Point(320, 93);
            this.coPłeć.Name = "coPłeć";
            this.coPłeć.Size = new System.Drawing.Size(121, 21);
            this.coPłeć.TabIndex = 7;
            this.coPłeć.SelectedIndexChanged += new System.EventHandler(this.coPłeć_SelectedIndexChanged);
            // 
            // nuMaxModlitw
            // 
            this.nuMaxModlitw.Location = new System.Drawing.Point(321, 118);
            this.nuMaxModlitw.Name = "nuMaxModlitw";
            this.nuMaxModlitw.Size = new System.Drawing.Size(120, 20);
            this.nuMaxModlitw.TabIndex = 8;
            this.nuMaxModlitw.ValueChanged += new System.EventHandler(this.nuMaxModlitw_ValueChanged);
            // 
            // laUwaga
            // 
            this.laUwaga.AutoSize = true;
            this.laUwaga.Location = new System.Drawing.Point(191, 147);
            this.laUwaga.Name = "laUwaga";
            this.laUwaga.Size = new System.Drawing.Size(300, 13);
            this.laUwaga.TabIndex = 9;
            this.laUwaga.Text = "UWAGA! 0 w maksymalnej liczbie modlitw oznacza brak limitu.";
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(203, 257);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(75, 23);
            this.buDodaj.TabIndex = 10;
            this.buDodaj.Text = "Dodaj";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(296, 257);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(75, 23);
            this.buUsuń.TabIndex = 11;
            this.buUsuń.Text = "Usuń";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.buUsuń_Click);
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(205, 286);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(120, 23);
            this.buZapisz.TabIndex = 12;
            this.buZapisz.Text = "Zapisz i zamknij";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // buHarmonogram
            // 
            this.buHarmonogram.Location = new System.Drawing.Point(321, 163);
            this.buHarmonogram.Name = "buHarmonogram";
            this.buHarmonogram.Size = new System.Drawing.Size(121, 23);
            this.buHarmonogram.TabIndex = 13;
            this.buHarmonogram.Text = "Utwórz harmonogram";
            this.buHarmonogram.UseVisualStyleBackColor = true;
            this.buHarmonogram.Click += new System.EventHandler(this.buHarmonogram_Click);
            // 
            // buAnuluj
            // 
            this.buAnuluj.Location = new System.Drawing.Point(345, 286);
            this.buAnuluj.Name = "buAnuluj";
            this.buAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buAnuluj.TabIndex = 14;
            this.buAnuluj.Text = "Anuluj";
            this.buAnuluj.UseVisualStyleBackColor = true;
            this.buAnuluj.Click += new System.EventHandler(this.buAnuluj_Click);
            // 
            // laHarmonogram
            // 
            this.laHarmonogram.AutoSize = true;
            this.laHarmonogram.Location = new System.Drawing.Point(202, 168);
            this.laHarmonogram.Name = "laHarmonogram";
            this.laHarmonogram.Size = new System.Drawing.Size(76, 13);
            this.laHarmonogram.TabIndex = 15;
            this.laHarmonogram.Text = "Harmonogram:";
            // 
            // laUwaga2
            // 
            this.laUwaga2.Location = new System.Drawing.Point(194, 38);
            this.laUwaga2.Name = "laUwaga2";
            this.laUwaga2.Size = new System.Drawing.Size(306, 28);
            this.laUwaga2.TabIndex = 16;
            this.laUwaga2.Text = "UWAGA! Program stara się wybrać płeć po imieniu. Jednak zdrobnienia lub dziwne im" +
                "iona mogą spowodować zły wybór.";
            // 
            // laDoświadczenie
            // 
            this.laDoświadczenie.AutoSize = true;
            this.laDoświadczenie.Location = new System.Drawing.Point(202, 197);
            this.laDoświadczenie.Name = "laDoświadczenie";
            this.laDoświadczenie.Size = new System.Drawing.Size(82, 13);
            this.laDoświadczenie.TabIndex = 18;
            this.laDoświadczenie.Text = "Doświadczenie:";
            // 
            // coDoświadczenie
            // 
            this.coDoświadczenie.FormattingEnabled = true;
            this.coDoświadczenie.Items.AddRange(new object[] {
            "małe",
            "duże"});
            this.coDoświadczenie.Location = new System.Drawing.Point(321, 194);
            this.coDoświadczenie.Name = "coDoświadczenie";
            this.coDoświadczenie.Size = new System.Drawing.Size(121, 21);
            this.coDoświadczenie.TabIndex = 19;
            this.coDoświadczenie.SelectedIndexChanged += new System.EventHandler(this.coDoświadczenie_SelectedIndexChanged);
            // 
            // cbEgzorcysta
            // 
            this.cbEgzorcysta.AutoSize = true;
            this.cbEgzorcysta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbEgzorcysta.Location = new System.Drawing.Point(203, 221);
            this.cbEgzorcysta.Name = "cbEgzorcysta";
            this.cbEgzorcysta.Size = new System.Drawing.Size(157, 17);
            this.cbEgzorcysta.TabIndex = 20;
            this.cbEgzorcysta.Text = "Ma uprawnienia egzorcysty:";
            this.cbEgzorcysta.UseVisualStyleBackColor = true;
            this.cbEgzorcysta.CheckedChanged += new System.EventHandler(this.cbEgzorcysta_CheckedChanged);
            // 
            // pbCzyHarmonogram
            // 
            this.pbCzyHarmonogram.Location = new System.Drawing.Point(447, 163);
            this.pbCzyHarmonogram.Name = "pbCzyHarmonogram";
            this.pbCzyHarmonogram.Size = new System.Drawing.Size(21, 21);
            this.pbCzyHarmonogram.TabIndex = 21;
            this.pbCzyHarmonogram.TabStop = false;
            this.pbCzyHarmonogram.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCzyHarmonogram_Paint);
            // 
            // WstawiennikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 321);
            this.ControlBox = false;
            this.Controls.Add(this.pbCzyHarmonogram);
            this.Controls.Add(this.cbEgzorcysta);
            this.Controls.Add(this.coDoświadczenie);
            this.Controls.Add(this.laDoświadczenie);
            this.Controls.Add(this.laUwaga2);
            this.Controls.Add(this.laHarmonogram);
            this.Controls.Add(this.buAnuluj);
            this.Controls.Add(this.buHarmonogram);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.laUwaga);
            this.Controls.Add(this.nuMaxModlitw);
            this.Controls.Add(this.coPłeć);
            this.Controls.Add(this.teNazwisko);
            this.Controls.Add(this.teImię);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laPłeć);
            this.Controls.Add(this.laNazwisko);
            this.Controls.Add(this.laImię);
            this.Controls.Add(this.liWstawiennicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WstawiennikForm";
            this.Text = "Kreator wstawienników";
            this.Load += new System.EventHandler(this.WstawiennikForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WstawiennikForm_Paint);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WstawiennikForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxModlitw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCzyHarmonogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liWstawiennicy;
        private System.Windows.Forms.Label laImię;
        private System.Windows.Forms.Label laNazwisko;
        private System.Windows.Forms.Label laPłeć;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teImię;
        private System.Windows.Forms.TextBox teNazwisko;
        private System.Windows.Forms.ComboBox coPłeć;
        private System.Windows.Forms.NumericUpDown nuMaxModlitw;
        private System.Windows.Forms.Label laUwaga;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Button buHarmonogram;
        private System.Windows.Forms.Button buAnuluj;
        private System.Windows.Forms.Label laHarmonogram;
        private System.Windows.Forms.Label laUwaga2;
        private System.Windows.Forms.Label laDoświadczenie;
        private System.Windows.Forms.ComboBox coDoświadczenie;
        private System.Windows.Forms.CheckBox cbEgzorcysta;
        private System.Windows.Forms.PictureBox pbCzyHarmonogram;
    }
}