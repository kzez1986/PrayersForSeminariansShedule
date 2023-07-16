namespace RelacjeForm
{
    partial class Relacje
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
            this.coRelacja = new System.Windows.Forms.ComboBox();
            this.coWstawiennik = new System.Windows.Forms.ComboBox();
            this.buDodaj = new System.Windows.Forms.Button();
            this.liRelacjaMusi = new System.Windows.Forms.ListBox();
            this.buZapisz = new System.Windows.Forms.Button();
            this.laUwaga = new System.Windows.Forms.Label();
            this.buAnuluj = new System.Windows.Forms.Button();
            this.laUwaga2 = new System.Windows.Forms.Label();
            this.buUsuń = new System.Windows.Forms.Button();
            this.buEdytuj = new System.Windows.Forms.Button();
            this.laSeminarzysta = new System.Windows.Forms.Label();
            this.liRelacjaNieMoże = new System.Windows.Forms.ListBox();
            this.buUsuń2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coRelacja
            // 
            this.coRelacja.FormattingEnabled = true;
            this.coRelacja.Items.AddRange(new object[] {
            "musi być omadlany przez",
            "nie może być omadlany przez"});
            this.coRelacja.Location = new System.Drawing.Point(157, 12);
            this.coRelacja.Name = "coRelacja";
            this.coRelacja.Size = new System.Drawing.Size(121, 21);
            this.coRelacja.TabIndex = 1;
            // 
            // coWstawiennik
            // 
            this.coWstawiennik.FormattingEnabled = true;
            this.coWstawiennik.Location = new System.Drawing.Point(296, 12);
            this.coWstawiennik.Name = "coWstawiennik";
            this.coWstawiennik.Size = new System.Drawing.Size(121, 21);
            this.coWstawiennik.TabIndex = 2;
            // 
            // buDodaj
            // 
            this.buDodaj.Location = new System.Drawing.Point(432, 12);
            this.buDodaj.Name = "buDodaj";
            this.buDodaj.Size = new System.Drawing.Size(75, 23);
            this.buDodaj.TabIndex = 3;
            this.buDodaj.Text = "Dodaj";
            this.buDodaj.UseVisualStyleBackColor = true;
            this.buDodaj.Click += new System.EventHandler(this.buDodaj_Click);
            // 
            // liRelacjaMusi
            // 
            this.liRelacjaMusi.FormattingEnabled = true;
            this.liRelacjaMusi.Location = new System.Drawing.Point(12, 74);
            this.liRelacjaMusi.Name = "liRelacjaMusi";
            this.liRelacjaMusi.Size = new System.Drawing.Size(265, 147);
            this.liRelacjaMusi.TabIndex = 4;
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(406, 346);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(75, 23);
            this.buZapisz.TabIndex = 5;
            this.buZapisz.Text = "Zapisz";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // laUwaga
            // 
            this.laUwaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laUwaga.Location = new System.Drawing.Point(292, 52);
            this.laUwaga.Name = "laUwaga";
            this.laUwaga.Size = new System.Drawing.Size(223, 86);
            this.laUwaga.TabIndex = 6;
            this.laUwaga.Text = "Relacje mają wyższy priorytet od reguł standardowych. Przy przydzielaniu pomijane" +
                " są ograniczenia np. płci.";
            // 
            // buAnuluj
            // 
            this.buAnuluj.Location = new System.Drawing.Point(406, 306);
            this.buAnuluj.Name = "buAnuluj";
            this.buAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buAnuluj.TabIndex = 7;
            this.buAnuluj.Text = "Anuluj";
            this.buAnuluj.UseVisualStyleBackColor = true;
            this.buAnuluj.Click += new System.EventHandler(this.buAnuluj_Click);
            // 
            // laUwaga2
            // 
            this.laUwaga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laUwaga2.Location = new System.Drawing.Point(292, 150);
            this.laUwaga2.Name = "laUwaga2";
            this.laUwaga2.Size = new System.Drawing.Size(203, 86);
            this.laUwaga2.TabIndex = 8;
            this.laUwaga2.Text = "Jeżeli nie zostanie wprowadzona relacja, domyślnie jest relacja może być omadlany" +
                " przez.";
            // 
            // buUsuń
            // 
            this.buUsuń.Location = new System.Drawing.Point(12, 45);
            this.buUsuń.Name = "buUsuń";
            this.buUsuń.Size = new System.Drawing.Size(75, 23);
            this.buUsuń.TabIndex = 9;
            this.buUsuń.Text = "Usuń";
            this.buUsuń.UseVisualStyleBackColor = true;
            this.buUsuń.Click += new System.EventHandler(this.buUsuń_Click);
            // 
            // buEdytuj
            // 
            this.buEdytuj.Location = new System.Drawing.Point(406, 263);
            this.buEdytuj.Name = "buEdytuj";
            this.buEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buEdytuj.TabIndex = 10;
            this.buEdytuj.Text = "Edytuj";
            this.buEdytuj.UseVisualStyleBackColor = true;
            this.buEdytuj.Click += new System.EventHandler(this.buEdytuj_Click);
            // 
            // laSeminarzysta
            // 
            this.laSeminarzysta.AutoSize = true;
            this.laSeminarzysta.Location = new System.Drawing.Point(12, 15);
            this.laSeminarzysta.Name = "laSeminarzysta";
            this.laSeminarzysta.Size = new System.Drawing.Size(35, 13);
            this.laSeminarzysta.TabIndex = 11;
            this.laSeminarzysta.Text = "label1";
            // 
            // liRelacjaNieMoże
            // 
            this.liRelacjaNieMoże.FormattingEnabled = true;
            this.liRelacjaNieMoże.Location = new System.Drawing.Point(12, 236);
            this.liRelacjaNieMoże.Name = "liRelacjaNieMoże";
            this.liRelacjaNieMoże.Size = new System.Drawing.Size(266, 134);
            this.liRelacjaNieMoże.TabIndex = 12;
            // 
            // buUsuń2
            // 
            this.buUsuń2.Location = new System.Drawing.Point(296, 346);
            this.buUsuń2.Name = "buUsuń2";
            this.buUsuń2.Size = new System.Drawing.Size(75, 23);
            this.buUsuń2.TabIndex = 13;
            this.buUsuń2.Text = "Usuń";
            this.buUsuń2.UseVisualStyleBackColor = true;
            this.buUsuń2.Click += new System.EventHandler(this.buUsuń2_Click);
            // 
            // Relacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 382);
            this.Controls.Add(this.buUsuń2);
            this.Controls.Add(this.liRelacjaNieMoże);
            this.Controls.Add(this.laSeminarzysta);
            this.Controls.Add(this.buEdytuj);
            this.Controls.Add(this.buUsuń);
            this.Controls.Add(this.laUwaga2);
            this.Controls.Add(this.buAnuluj);
            this.Controls.Add(this.laUwaga);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.liRelacjaMusi);
            this.Controls.Add(this.buDodaj);
            this.Controls.Add(this.coWstawiennik);
            this.Controls.Add(this.coRelacja);
            this.Name = "Relacje";
            this.Text = "Relacje";
            this.Load += new System.EventHandler(this.Relacje_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relacje_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coRelacja;
        private System.Windows.Forms.ComboBox coWstawiennik;
        private System.Windows.Forms.Button buDodaj;
        private System.Windows.Forms.ListBox liRelacjaMusi;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Label laUwaga;
        private System.Windows.Forms.Button buAnuluj;
        private System.Windows.Forms.Label laUwaga2;
        private System.Windows.Forms.Button buUsuń;
        private System.Windows.Forms.Button buEdytuj;
        private System.Windows.Forms.Label laSeminarzysta;
        private System.Windows.Forms.ListBox liRelacjaNieMoże;
        private System.Windows.Forms.Button buUsuń2;
    }
}