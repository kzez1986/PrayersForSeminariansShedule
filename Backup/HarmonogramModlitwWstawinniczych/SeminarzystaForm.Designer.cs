namespace SeminarzyściForm
{
    partial class SeminarzystaForm
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
            this.liSeminarzyści = new System.Windows.Forms.ListBox();
            this.laImię = new System.Windows.Forms.Label();
            this.laUwaga = new System.Windows.Forms.Label();
            this.laNazwisko = new System.Windows.Forms.Label();
            this.laPłeć = new System.Windows.Forms.Label();
            this.laHarmonogram = new System.Windows.Forms.Label();
            this.laDoświadczeni = new System.Windows.Forms.Label();
            this.teImię = new System.Windows.Forms.TextBox();
            this.coPłeć = new System.Windows.Forms.ComboBox();
            this.teNazwisko = new System.Windows.Forms.TextBox();
            this.buHarmonogram = new System.Windows.Forms.Button();
            this.nuDoświadczeni = new System.Windows.Forms.NumericUpDown();
            this.cbPotrzebujeEgzorcysty = new System.Windows.Forms.CheckBox();
            this.buDodaj = new System.Windows.Forms.Button();
            this.buUsuń = new System.Windows.Forms.Button();
            this.buZapisz = new System.Windows.Forms.Button();
            this.buZamknij = new System.Windows.Forms.Button();
            this.pbHarmonogram = new System.Windows.Forms.PictureBox();
            this.cbTrybEdycji = new System.Windows.Forms.CheckBox();
            this.buRelacje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuDoświadczeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHarmonogram)).BeginInit();
            this.SuspendLayout();
            // 
            // liSeminarzyści
            // 
            this.liSeminarzyści.FormattingEnabled = true;
            this.liSeminarzyści.Location = new System.Drawing.Point(12, 12);
            this.liSeminarzyści.Name = "liSeminarzyści";
            this.liSeminarzyści.Size = new System.Drawing.Size(171, 355);
            this.liSeminarzyści.TabIndex = 0;
            this.liSeminarzyści.SelectedIndexChanged += new System.EventHandler(this.liSeminarzyści_SelectedIndexChanged);
            // 
            // laImię
            // 
            this.laImię.AutoSize = true;
            this.laImię.Location = new System.Drawing.Point(207, 15);
            this.laImię.Name = "laImię";
            this.laImię.Size = new System.Drawing.Size(58, 13);
            this.laImię.TabIndex = 1;
            this.laImię.Text = "Podaj imię:";
            // 
            // laUwaga
            // 
            this.laUwaga.Location = new System.Drawing.Point(189, 45);
            this.laUwaga.Name = "laUwaga";
            this.laUwaga.Size = new System.Drawing.Size(318, 34);
            this.laUwaga.TabIndex = 2;
            this.laUwaga.Text = "UWAGA! Program stara się wybrać płeć po imieniu. Jednak zdrobnienia lub dziwne im" +
                "iona mogą spowodować zły wybór.";
            // 
            // laNazwisko
            // 
            this.laNazwisko.AutoSize = true;
            this.laNazwisko.Location = new System.Drawing.Point(206, 85);
            this.laNazwisko.Name = "laNazwisko";
            this.laNazwisko.Size = new System.Drawing.Size(84, 13);
            this.laNazwisko.TabIndex = 3;
            this.laNazwisko.Text = "Podaj nazwisko:";
            // 
            // laPłeć
            // 
            this.laPłeć.AutoSize = true;
            this.laPłeć.Location = new System.Drawing.Point(207, 126);
            this.laPłeć.Name = "laPłeć";
            this.laPłeć.Size = new System.Drawing.Size(95, 13);
            this.laPłeć.TabIndex = 4;
            this.laPłeć.Text = "Płeć seminarzysty:";
            // 
            // laHarmonogram
            // 
            this.laHarmonogram.AutoSize = true;
            this.laHarmonogram.Location = new System.Drawing.Point(207, 163);
            this.laHarmonogram.Name = "laHarmonogram";
            this.laHarmonogram.Size = new System.Drawing.Size(76, 13);
            this.laHarmonogram.TabIndex = 5;
            this.laHarmonogram.Text = "Harmonogram:";
            // 
            // laDoświadczeni
            // 
            this.laDoświadczeni.Location = new System.Drawing.Point(206, 195);
            this.laDoświadczeni.Name = "laDoświadczeni";
            this.laDoświadczeni.Size = new System.Drawing.Size(100, 34);
            this.laDoświadczeni.TabIndex = 6;
            this.laDoświadczeni.Text = "Ilu potrzebuje doświadczonych:";
            // 
            // teImię
            // 
            this.teImię.Location = new System.Drawing.Point(313, 12);
            this.teImię.Name = "teImię";
            this.teImię.Size = new System.Drawing.Size(100, 20);
            this.teImię.TabIndex = 8;
            this.teImię.TextChanged += new System.EventHandler(this.teImię_TextChanged);
            this.teImię.Leave += new System.EventHandler(this.teImię_Leave);
            // 
            // coPłeć
            // 
            this.coPłeć.FormattingEnabled = true;
            this.coPłeć.Items.AddRange(new object[] {
            "chłopak",
            "dziewczyna"});
            this.coPłeć.Location = new System.Drawing.Point(313, 123);
            this.coPłeć.Name = "coPłeć";
            this.coPłeć.Size = new System.Drawing.Size(121, 21);
            this.coPłeć.TabIndex = 9;
            this.coPłeć.SelectedIndexChanged += new System.EventHandler(this.coPłeć_SelectedIndexChanged);
            // 
            // teNazwisko
            // 
            this.teNazwisko.Location = new System.Drawing.Point(313, 82);
            this.teNazwisko.Name = "teNazwisko";
            this.teNazwisko.Size = new System.Drawing.Size(100, 20);
            this.teNazwisko.TabIndex = 10;
            this.teNazwisko.TextChanged += new System.EventHandler(this.teNazwisko_TextChanged);
            // 
            // buHarmonogram
            // 
            this.buHarmonogram.Location = new System.Drawing.Point(313, 158);
            this.buHarmonogram.Name = "buHarmonogram";
            this.buHarmonogram.Size = new System.Drawing.Size(121, 23);
            this.buHarmonogram.TabIndex = 11;
            this.buHarmonogram.Text = "Utwórz harmonogram";
            this.buHarmonogram.UseVisualStyleBackColor = true;
            this.buHarmonogram.Click += new System.EventHandler(this.buHarmonogram_Click);
            // 
            // nuDoświadczeni
            // 
            this.nuDoświadczeni.Location = new System.Drawing.Point(313, 200);
            this.nuDoświadczeni.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nuDoświadczeni.Name = "nuDoświadczeni";
            this.nuDoświadczeni.Size = new System.Drawing.Size(120, 20);
            this.nuDoświadczeni.TabIndex = 13;
            this.nuDoświadczeni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDoświadczeni.ValueChanged += new System.EventHandler(this.nuDoświadczeni_ValueChanged);
            // 
            // cbPotrzebujeEgzorcysty
            // 
            this.cbPotrzebujeEgzorcysty.AutoSize = true;
            this.cbPotrzebujeEgzorcysty.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPotrzebujeEgzorcysty.Location = new System.Drawing.Point(209, 242);
            this.cbPotrzebujeEgzorcysty.Name = "cbPotrzebujeEgzorcysty";
            this.cbPotrzebujeEgzorcysty.Size = new System.Drawing.Size(132, 17);
            this.cbPotrzebujeEgzorcysty.TabIndex = 14;
            this.cbPotrzebujeEgzorcysty.Text = "Potrzebuje egzorcysty:";
            this.cbPotrzebujeEgzorcysty.UseVisualStyleBackColor = true;
            this.cbPotrzebujeEgzorcysty.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(209, 309);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(97, 23);
            this.buDodaj.TabIndex = 15;
            this.buDodaj.Text = "Dodaj / Edytuj";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(327, 308);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(75, 23);
            this.buUsuń.TabIndex = 16;
            this.buUsuń.Text = "Usuń";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.buUsuń_Click);
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(242, 338);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(99, 23);
            this.buZapisz.TabIndex = 17;
            this.buZapisz.Text = "Zapisz i zamknij";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // buZamknij
            // 
            this.buZamknij.Location = new System.Drawing.Point(359, 338);
            this.buZamknij.Name = "buZamknij";
            this.buZamknij.Size = new System.Drawing.Size(75, 23);
            this.buZamknij.TabIndex = 18;
            this.buZamknij.Text = "Anuluj";
            this.buZamknij.UseVisualStyleBackColor = true;
            this.buZamknij.Click += new System.EventHandler(this.buZamknij_Click);
            // 
            // pbHarmonogram
            // 
            this.pbHarmonogram.Location = new System.Drawing.Point(440, 158);
            this.pbHarmonogram.Name = "pbHarmonogram";
            this.pbHarmonogram.Size = new System.Drawing.Size(21, 21);
            this.pbHarmonogram.TabIndex = 12;
            this.pbHarmonogram.TabStop = false;
            // 
            // cbTrybEdycji
            // 
            this.cbTrybEdycji.AutoSize = true;
            this.cbTrybEdycji.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTrybEdycji.Location = new System.Drawing.Point(359, 242);
            this.cbTrybEdycji.Name = "cbTrybEdycji";
            this.cbTrybEdycji.Size = new System.Drawing.Size(77, 17);
            this.cbTrybEdycji.TabIndex = 19;
            this.cbTrybEdycji.Text = "Tryb edycji";
            this.cbTrybEdycji.UseVisualStyleBackColor = true;
            this.cbTrybEdycji.CheckedChanged += new System.EventHandler(this.cbTrybEdycji_CheckedChanged);
            // 
            // buRelacje
            // 
            this.buRelacje.Location = new System.Drawing.Point(210, 266);
            this.buRelacje.Name = "buRelacje";
            this.buRelacje.Size = new System.Drawing.Size(75, 23);
            this.buRelacje.TabIndex = 20;
            this.buRelacje.Text = "Releacje";
            this.buRelacje.UseVisualStyleBackColor = true;
            this.buRelacje.Click += new System.EventHandler(this.buRelacje_Click);
            // 
            // SeminarzystaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 373);
            this.ControlBox = false;
            this.Controls.Add(this.buRelacje);
            this.Controls.Add(this.cbTrybEdycji);
            this.Controls.Add(this.buZamknij);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.cbPotrzebujeEgzorcysty);
            this.Controls.Add(this.nuDoświadczeni);
            this.Controls.Add(this.pbHarmonogram);
            this.Controls.Add(this.buHarmonogram);
            this.Controls.Add(this.teNazwisko);
            this.Controls.Add(this.coPłeć);
            this.Controls.Add(this.teImię);
            this.Controls.Add(this.laDoświadczeni);
            this.Controls.Add(this.laHarmonogram);
            this.Controls.Add(this.laPłeć);
            this.Controls.Add(this.laNazwisko);
            this.Controls.Add(this.laUwaga);
            this.Controls.Add(this.laImię);
            this.Controls.Add(this.liSeminarzyści);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SeminarzystaForm";
            this.Text = "Kreator seminarzysatów";
            this.Load += new System.EventHandler(this.SeminarzystaForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeminarzystaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nuDoświadczeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHarmonogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liSeminarzyści;
        private System.Windows.Forms.Label laImię;
        private System.Windows.Forms.Label laUwaga;
        private System.Windows.Forms.Label laNazwisko;
        private System.Windows.Forms.Label laPłeć;
        private System.Windows.Forms.Label laHarmonogram;
        private System.Windows.Forms.Label laDoświadczeni;
        private System.Windows.Forms.TextBox teImię;
        private System.Windows.Forms.ComboBox coPłeć;
        private System.Windows.Forms.TextBox teNazwisko;
        private System.Windows.Forms.Button buHarmonogram;
        private System.Windows.Forms.PictureBox pbHarmonogram;
        private System.Windows.Forms.NumericUpDown nuDoświadczeni;
        private System.Windows.Forms.CheckBox cbPotrzebujeEgzorcysty;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Button buZamknij;
        private System.Windows.Forms.CheckBox cbTrybEdycji;
        private System.Windows.Forms.Button buRelacje;
    }
}