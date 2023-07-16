using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harmonogram_Harmonogram;
using OpisyDni_Harmonogram;
using HarmonogramModlitwWstawinniczych;
using System.IO;
using HarmonogramForma;

namespace SaleForm
{
    public struct opis_sali
    {
        public string opis;
        public int liczba_terminów;
        public HarmonogramDane h;
    }
    public partial class SalaForm : Form
    {
        private opis_sali[] osali;
        private OpisyDni adres_dni;
        private Harmonogram adres_rodzica;

        public PictureBox rys_adres
        {
            get
            {
                return pbHarmonogram;
            }
        }

        public opis_sali op_sali
        {
            get
            {
                return osali[liSale.Items.Count];
            }
        }

        public int liczba_terminów_
        {
            get
            {
                return osali[liSale.Items.Count].liczba_terminów;
            }
            set
            {
                osali[liSale.Items.Count].liczba_terminów = value;
            }
        }

        public opis_sali op_sem
        {
            get
            {
                return osali[liSale.Items.Count];
            }
        }

        public SalaForm(OpisyDni od, Harmonogram adr)
        {
            InitializeComponent();
            adres_dni = od;
            adres_rodzica = adr;
            osali = new opis_sali[100];
        }

        private void SalaForm_Load(object sender, EventArgs e)
        {
            pbHarmonogram.Load(Directory.GetCurrentDirectory() + "\\rysunki\\zle.bmp");
        }

        private void teOpis_Leave(object sender, EventArgs e)
        {
            if (teOpis.Text.Length != 0)
            {
                osali[liSale.Items.Count].opis = teOpis.Text;
            }
        }

        private void buHarmonogram_Click(object sender, EventArgs e)
        {
            if (osali[liSale.Items.Count].h == null)
                osali[liSale.Items.Count].h = new HarmonogramDane(adres_dni);
            HarmonogramForm hf = new HarmonogramForm(adres_dni, this, osali[liSale.Items.Count], 2);
            hf.Visible = true;
            this.Enabled = false;
        }

        private void SalaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adres_rodzica.Enabled = true;
        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            if (liSale.Items.Count < 100)
            {
                //zbieranie danych
                if (osali[liSale.Items.Count].opis == null)
                {
                    MessageBox.Show("Nie podałeś opisu sali.");
                    return;
                }
                if (osali[liSale.Items.Count].h == null)
                {
                    MessageBox.Show("Nie utworzyłeś harmonogramu sali.");
                    return;
                }
                //dodawanie danych
                object obj = new object();
                liSale.Items.Add(obj);
                liSale.Items[liSale.Items.Count - 1] = teOpis.Text + " ";
                pbHarmonogram.Load(Directory.GetCurrentDirectory() + "\\rysunki\\zle.bmp");
                //czyszczenie
                teOpis.Text = "";
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę sal! Aby dodać nową musisz usunąć przynajmniej 1 pozycję!");
            }
        }

        private void buUsuń_Click(object sender, EventArgs e)
        {
            if (liSale.SelectedIndex >= 0)
            {
                for (int i = liSale.SelectedIndex; i < liSale.Items.Count - 1; i++)
                {
                    osali[i] = osali[i + 1];
                }
                osali[liSale.Items.Count - 1] = new opis_sali();
                liSale.Items.RemoveAt(liSale.SelectedIndex);
            }
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            //zapis do pliku i klasy
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\sale.in");
            sw.WriteLine(liSale.Items.Count);
            for (int i = 0; i < liSale.Items.Count; i++)
            {
                sw.WriteLine(osali[i].opis);
                sw.WriteLine(osali[i].liczba_terminów);
                for (int j = 0; j < adres_dni.liczba_dni; j++)
                {
                    for (int k = 0; k < 48; k++)
                    {
                        if (osali[i].h.czy_wolne[j, k] == true)
                            sw.Write(1);
                        else
                            sw.Write(0);
                    }
                    sw.WriteLine();
                }
            }
            sw.Close();
            this.Close();
            adres_rodzica.WczytajSale();
        }
    }
}
