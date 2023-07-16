using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harmonogram_Harmonogram;
using HarmonogramForma;
using OpisyDni_Harmonogram;
using System.IO;
using HarmonogramModlitwWstawinniczych;
using Wstawinnik_Harmonogram;

namespace WstawinnicyForma
{

    public struct opis_wstawinnika
    {
        public string imię;
        public string nazwisko;
        public bool płeć;
        public short max_modlitw;
        public HarmonogramDane h;
        public bool doświadczenie;
        public bool egzorcysta;
        public int liczba_terminów;
    }

    public partial class WstawiennikForm : Form
    {
        private opis_wstawinnika[] ow;
        private OpisyDni adres;
        private Harmonogram adres_rodzica;

        public PictureBox rys_adres
        {
            get
            {
                return pbCzyHarmonogram;
            }
        }

        public bool[,] DajHarmonogram
        {
            get
            {
                return ow[liWstawiennicy.Items.Count].h.czy_wolne;
            }
            set
            {
                ow[liWstawiennicy.Items.Count].h.czy_wolne = value;
            }
        }

        public int liczba_terminów_
        {
            get
            {
                return ow[liWstawiennicy.Items.Count].liczba_terminów;
            }
            set
            {
                ow[liWstawiennicy.Items.Count].liczba_terminów = value;
            }
        }

        public WstawiennikForm(OpisyDni od, Harmonogram adr, Wstawiennik[] wst)
        {
            InitializeComponent();
            ow = new opis_wstawinnika[200];
            adres = od;
            adres_rodzica = adr;
            //uzupełnieanie opisu wstawiennika
            for (int i = 0; i < wst.Length; i++)
            {
                ow[i].imię = wst[i].imię;
                ow[i].nazwisko = wst[i].nazwisko;
                ow[i].płeć = wst[i].płeć;
                ow[i].max_modlitw = wst[i].max_modlitw;
                ow[i].h = wst[i].h;
                ow[i].doświadczenie = wst[i].doświadczenie;
                ow[i].egzorcysta = wst[i].egzorcysta;
                liWstawiennicy.Items.Add(new object());
                liWstawiennicy.Items[i] = ow[i].imię + " " + ow[i].nazwisko;
            }
        }

        private void WstawiennikForm_Load(object sender, EventArgs e)
        {
            coPłeć.SelectedIndex = 0;
            pbCzyHarmonogram.Load(Directory.GetCurrentDirectory() + "\\rysunki\\zle.bmp");
            coDoświadczenie.SelectedIndex = 0;
            //wartości domyślne
            coPłeć_SelectedIndexChanged(null, null);
            nuMaxModlitw_ValueChanged(null, null);
            coDoświadczenie_SelectedIndexChanged(null, null);
            cbEgzorcysta_CheckedChanged(null, null);
        }

        private void teImię_Leave(object sender, EventArgs e)
        {
            if (teImię.Text.Length != 0)
            {
                if (teImię.Text[teImię.Text.Length - 1] == 'a')
                    coPłeć.SelectedIndex = 1;
                else
                    coPłeć.SelectedIndex = 0;
                ow[liWstawiennicy.Items.Count].imię = teImię.Text;
            }
        }

        private void laNazwisko_Click(object sender, EventArgs e)
        {

        }

        private void buAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            if (liWstawiennicy.Items.Count < 200)
            {
                //zbieranie danych
                if(ow[liWstawiennicy.Items.Count].imię == null)
                {
                    MessageBox.Show("Nie podałeś imienia wstawiennika.");
                    return;
                }
                if(ow[liWstawiennicy.Items.Count].nazwisko == null)
                {
                    MessageBox.Show("Nie podałeś nazwiska wstawiennika.");
                    return;
                }     
                if (ow[liWstawiennicy.Items.Count].h == null)
                {
                    MessageBox.Show("Nie utworzyłeś harmonogramu wstawiennika.");
                    return;
                }
                //dodawanie danych
                object obj = new object();
                liWstawiennicy.Items.Add(obj);
                liWstawiennicy.Items[liWstawiennicy.Items.Count-1] = teImię.Text + " " + teNazwisko.Text;
                pbCzyHarmonogram.Load(Directory.GetCurrentDirectory() + "\\rysunki\\zle.bmp");
                //czyszczenie
                teImię.Text = "";
                teNazwisko.Text = "";
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę wstawinników! Aby dodać nowych musisz usunąć przynajmniej 1 pozycję!");
            }
        }

        private void buHarmonogram_Click(object sender, EventArgs e)
        {
            if(ow[liWstawiennicy.Items.Count].h == null)
                ow[liWstawiennicy.Items.Count].h = new HarmonogramDane(adres);
            HarmonogramForm hf = new HarmonogramForm(adres, this, ow[liWstawiennicy.Items.Count],0);
            hf.Visible = true;
            this.Enabled = false;
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            //zapis do pliku i klasy
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\wstawiennicy.in");
            sw.WriteLine(liWstawiennicy.Items.Count);
            for (int i = 0; i < liWstawiennicy.Items.Count; i++)
            {
                sw.WriteLine(ow[i].imię);
                sw.WriteLine(ow[i].nazwisko);
                sw.WriteLine(ow[i].płeć);
                sw.WriteLine(ow[i].max_modlitw);
                sw.WriteLine(ow[i].liczba_terminów);
                for (int j = 0; j < adres.liczba_dni; j++)
                {
                    for (int k = 0; k < 48; k++)
                    {
                        if (ow[i].h.czy_wolne[j, k] == true)
                            sw.Write(1);
                        else
                            sw.Write(0);
                    }
                    sw.WriteLine();
                }
                sw.WriteLine(ow[i].doświadczenie);
                sw.WriteLine(ow[i].egzorcysta);
            }
            sw.Close();
            this.Close();
            adres_rodzica.WczytajWstawienników();
        }

        private void WstawiennikForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCzyHarmonogram_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void WstawiennikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void coPłeć_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coPłeć.SelectedIndex == 0)
                ow[liWstawiennicy.Items.Count].płeć = false;
            else
                ow[liWstawiennicy.Items.Count].płeć = true;
        }

        private void cbEgzorcysta_CheckedChanged(object sender, EventArgs e)
        {
            ow[liWstawiennicy.Items.Count].egzorcysta = cbEgzorcysta.Checked;
        }

        private void coDoświadczenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coDoświadczenie.SelectedIndex == 0)
                ow[liWstawiennicy.Items.Count].doświadczenie = false;
            else
                ow[liWstawiennicy.Items.Count].doświadczenie = true;
        }

        private void teNazwisko_Leave(object sender, EventArgs e)
        {
            ow[liWstawiennicy.Items.Count].nazwisko = teNazwisko.Text;
        }

        private void nuMaxModlitw_ValueChanged(object sender, EventArgs e)
        {
            ow[liWstawiennicy.Items.Count].max_modlitw = (short)nuMaxModlitw.Value;
        }

        private void buUsuń_Click(object sender, EventArgs e)
        {
            if (liWstawiennicy.SelectedIndex >= 0)
            {
                for (int i = liWstawiennicy.SelectedIndex; i < liWstawiennicy.Items.Count - 1; i++)
                {
                    ow[i] = ow[i + 1];
                }
                ow[liWstawiennicy.Items.Count - 1] = new opis_wstawinnika();
                liWstawiennicy.Items.RemoveAt(liWstawiennicy.SelectedIndex);
            }
        }

        private void liWstawiennicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liWstawiennicy.SelectedIndex >= 0)
            {
                teImię.Text = ow[liWstawiennicy.SelectedIndex].imię;
                teNazwisko.Text = ow[liWstawiennicy.SelectedIndex].nazwisko;
                if (ow[liWstawiennicy.SelectedIndex].płeć == false)
                {
                    coPłeć.SelectedIndex = 0;
                }
                else
                {
                    coPłeć.SelectedIndex = 1;
                }
                nuMaxModlitw.Value = ow[liWstawiennicy.SelectedIndex].max_modlitw;
                if (ow[liWstawiennicy.SelectedIndex].doświadczenie == false)
                {
                    coDoświadczenie.SelectedIndex = 0;
                }
                else
                {
                    coDoświadczenie.SelectedIndex = 1;
                }
                cbEgzorcysta.Checked = ow[liWstawiennicy.SelectedIndex].egzorcysta;
            }
        }

        private void teImię_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
