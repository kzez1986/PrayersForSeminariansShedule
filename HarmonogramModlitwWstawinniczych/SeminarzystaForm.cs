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
using Seminarzysta_Harmonogram;
using OpisyDni_Harmonogram;
using HarmonogramModlitwWstawinniczych;
using System.IO;
using Wstawinnik_Harmonogram;
using RelacjeForm;

namespace SeminarzyściForm
{
    public struct opis_seminarzysty
    {
        public string imię;
        public string nazwisko;
        public bool płeć;
        public int liczba_terminów;
        public HarmonogramDane h;
        public byte grupa_wymagana;
        public bool wymaga_egzorcysty;
        public List<String> nie_może;
        public List<String> musi;
    }

    public partial class SeminarzystaForm : Form
    {
        
        private opis_seminarzysty[] osem;
        private OpisyDni adres;
        private Harmonogram adres_rodzica;
        private bool tryb_edycji;
        private Wstawiennik[] w_przekaż;
        public SeminarzystaForm(OpisyDni od, Harmonogram adr, Wstawiennik[] w)
        {
            InitializeComponent();
            osem = new opis_seminarzysty[200];
            adres = od;
            adres_rodzica = adr;
            tryb_edycji = false;
            osem[0].musi = new List<string>();
            osem[0].nie_może = new List<string>();
            w_przekaż = w;
        }

        public List<String> PobierzMusi
        {
            get
            {
                return osem[liSeminarzyści.Items.Count].musi;
            }
            set
            {
                osem[liSeminarzyści.Items.Count].musi = value;
            }
        }

        public List<String> PobierzNieMoże
        {
            get
            {
                return osem[liSeminarzyści.Items.Count].nie_może;
            }
            set
            {
                osem[liSeminarzyści.Items.Count].nie_może = value;
            }
        }
        
        public PictureBox rys_adres
        {
            get
            {
                return pbHarmonogram;
            }
        }

        public bool[,] DajHarmonogram
        {
            get
            {
                return osem[liSeminarzyści.Items.Count].h.czy_wolne;
            }
            set
            {
                osem[liSeminarzyści.Items.Count].h.czy_wolne = value;
            }
        }

        public int liczba_terminów_
        {
            get
            {
                return osem[liSeminarzyści.Items.Count].liczba_terminów;
            }
            set
            {
                osem[liSeminarzyści.Items.Count].liczba_terminów = value;
            }
        }

        public opis_seminarzysty op_sem
        {
            get
            {
                return osem[liSeminarzyści.Items.Count];
            }
        }
        
        private void SeminarzystaForm_Load(object sender, EventArgs e)
        {
            coPłeć.SelectedIndex = 0;
            osem[liSeminarzyści.Items.Count].płeć = false;
            osem[liSeminarzyści.Items.Count].wymaga_egzorcysty = false;
            osem[liSeminarzyści.Items.Count].grupa_wymagana = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            osem[liSeminarzyści.Items.Count].wymaga_egzorcysty = cbPotrzebujeEgzorcysty.Checked;
        }

        private void teImię_Leave(object sender, EventArgs e)
        {
            if (teImię.Text.Length != 0)
            {
                osem[liSeminarzyści.Items.Count].imię = teImię.Text;
            }
        }

        private void teNazwisko_TextChanged(object sender, EventArgs e)
        {
            osem[liSeminarzyści.Items.Count].nazwisko = teNazwisko.Text;
        }

        private void coPłeć_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coPłeć.SelectedIndex == 0)
            {
                osem[liSeminarzyści.Items.Count].płeć = false;
            }
            else
            {
                osem[liSeminarzyści.Items.Count].płeć = true;
            }
        }

        private void nuDoświadczeni_ValueChanged(object sender, EventArgs e)
        {
            osem[liSeminarzyści.Items.Count].grupa_wymagana = (byte)nuDoświadczeni.Value;
        }

        private void buHarmonogram_Click(object sender, EventArgs e)
        {
            if (osem[liSeminarzyści.Items.Count].h == null)
                osem[liSeminarzyści.Items.Count].h = new HarmonogramDane(adres);
            HarmonogramForm hf = new HarmonogramForm(adres, this, osem[liSeminarzyści.Items.Count], 1);
            hf.Visible = true;
            this.Enabled = false;
        }

        private void SeminarzystaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adres_rodzica.Enabled = true;
        }

        private void buZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buUsuń_Click(object sender, EventArgs e)
        {
            if (liSeminarzyści.SelectedIndex >= 0)
            {
                for (int i = liSeminarzyści.SelectedIndex; i < liSeminarzyści.Items.Count - 1; i++)
                {
                    osem[i] = osem[i + 1];
                }
                osem[liSeminarzyści.Items.Count - 1] = new opis_seminarzysty();
                liSeminarzyści.Items.RemoveAt(liSeminarzyści.SelectedIndex);
            }
        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            int nr;
            
            if (liSeminarzyści.Items.Count < 200)
            {
                //zbieranie danych
                if (osem[liSeminarzyści.Items.Count].imię == null)
                {
                    MessageBox.Show("Nie podałeś imienia wstawiennika.");
                    return;
                }
                if (osem[liSeminarzyści.Items.Count].nazwisko == null)
                {
                    MessageBox.Show("Nie podałeś nazwiska wstawiennika.");
                    return;
                }
                if (osem[liSeminarzyści.Items.Count].h == null)
                {
                    MessageBox.Show("Nie utworzyłeś harmonogramu wstawiennika.");
                    return;
                }
                //dodawanie danych
                object obj = new object();
                liSeminarzyści.Items.Add(obj);
                liSeminarzyści.Items[liSeminarzyści.Items.Count - 1] = teImię.Text + " " + teNazwisko.Text;
                pbHarmonogram.Load(Directory.GetCurrentDirectory() + "\\rysunki\\zle.bmp");
                //czyszczenie
                teImię.Text = "";
                teNazwisko.Text = "";
                //przygotowanie nowych obiektów
                osem[liSeminarzyści.Items.Count].musi = new List<string>();
                osem[liSeminarzyści.Items.Count].nie_może = new List<string>();
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę wstawinników! Aby dodać nowych musisz usunąć przynajmniej 1 pozycję!");
            }
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            //zapis do pliku i klasy
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\seminarzysci.in");
            sw.WriteLine(liSeminarzyści.Items.Count);
            for (int i = 0; i < liSeminarzyści.Items.Count; i++)
            {
                sw.WriteLine(osem[i].imię);
                sw.WriteLine(osem[i].nazwisko);
                sw.WriteLine(osem[i].płeć);
                for (int j = 0; j < adres.liczba_dni; j++)
                {
                    for (int k = 0; k < 48; k++)
                    {
                        if (osem[i].h.czy_wolne[j, k] == true)
                            sw.Write(1);
                        else
                            sw.Write(0);
                    }
                    sw.WriteLine();
                }
                sw.WriteLine(osem[i].grupa_wymagana);
                sw.WriteLine(osem[i].wymaga_egzorcysty);
                sw.WriteLine(osem[i].musi.Count);
                for (int j = 0; j < osem[i].musi.Count;j++)
                {
                    sw.WriteLine(osem[i].musi[j]);
                }
                sw.WriteLine(osem[i].nie_może.Count);
                for (int j = 0; j < osem[i].nie_może.Count; j++)
                {
                    sw.WriteLine(osem[i].nie_może[j]);
                }
                sw.WriteLine(osem[i].liczba_terminów);
            }
            sw.Close();
            this.Close();
            adres_rodzica.WczytajSeminarzystów();
        }

        private void liSeminarzyści_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liSeminarzyści.SelectedIndex >= 0)
            {
                teImię.Text = osem[liSeminarzyści.SelectedIndex].imię;
                teNazwisko.Text = osem[liSeminarzyści.SelectedIndex].nazwisko;
                if (osem[liSeminarzyści.SelectedIndex].płeć == false)
                {
                    coPłeć.SelectedIndex = 0;
                }
                else
                {
                    coPłeć.SelectedIndex = 1;
                }
                nuDoświadczeni.Value = osem[liSeminarzyści.SelectedIndex].grupa_wymagana;
                cbPotrzebujeEgzorcysty.Checked = osem[liSeminarzyści.SelectedIndex].wymaga_egzorcysty;

            }
        }

        private void cbTrybEdycji_CheckedChanged(object sender, EventArgs e)
        {
            tryb_edycji = cbTrybEdycji.Checked;
        }

        private void teImię_TextChanged(object sender, EventArgs e)
        {

        }

        private void buRelacje_Click(object sender, EventArgs e)
        {
            Relacje rel = new Relacje(w_przekaż, osem[liSeminarzyści.Items.Count], this);
            rel.Visible = true;
            this.Enabled = false;
        }
    }
}
