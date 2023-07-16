using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seminarzysta_Harmonogram;
using Wstawinnik_Harmonogram;
using HarmonogramModlitwWstawinniczych;
using SeminarzyściForm;

namespace RelacjeForm
{
    public partial class Relacje : Form
    {
        private Wstawiennik[] wst;
        private opis_seminarzysty sem;
        private SeminarzystaForm adres_rodzica;

        public Relacje(Wstawiennik[] w, opis_seminarzysty s, SeminarzystaForm sf)
        {
            InitializeComponent();
            wst = w;
            sem = s;
            adres_rodzica = sf;
        }

        private void Relacje_Load(object sender, EventArgs e)
        {
            coRelacja.SelectedIndex = 0;
            for (int i = 0; i < wst.Length; i++)
            {
                coWstawiennik.Items.Add(new Object());
                coWstawiennik.Items[i] = wst[i].imię + " " + wst[i].nazwisko;
            }
        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            if (coRelacja.SelectedIndex == 0)
            {
                //max 3 relacje "musi"
                if (liRelacjaMusi.Items.Count == 3)
                {
                    MessageBox.Show("Nie można utworzyć więcej niż 3 relacji musi, ponieważ seminarzysta może być omadlany przez 3 wstawienników.");
                }
                else
                {
                    bool istnieje = false;
                    for (int i = 0; i < liRelacjaNieMoże.Items.Count; i++)
                    {
                        if (coWstawiennik.SelectedText == (String)liRelacjaNieMoże.Items[i])
                        {
                            istnieje = true;
                            MessageBox.Show("Ten sam wstawiennik nie może być połączony 2 relacjami z seminarzystą!");
                            break;
                        }
                    }
                    liRelacjaMusi.Items.Add(coWstawiennik.Items[coWstawiennik.SelectedIndex]);
                }
            }
            else
            {
                bool istnieje = false;
                for (int i = 0; i < liRelacjaMusi.Items.Count; i++)
                {
                    if (coWstawiennik.SelectedText == (String)liRelacjaMusi.Items[i])
                    {
                        istnieje = true;
                        MessageBox.Show("Ten sam wstawiennik nie może być połączony 2 relacjami z seminarzystą!");
                        break;
                    }
                }
                if(!istnieje)
                    liRelacjaNieMoże.Items.Add(coWstawiennik.Items[coWstawiennik.SelectedIndex]);
            }
        }

        private void buAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buEdytuj_Click(object sender, EventArgs e)
        {

        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < liRelacjaNieMoże.Items.Count; i++)
            {
                 adres_rodzica.PobierzNieMoże.Add((String)liRelacjaNieMoże.Items[i]);
            }
            for (int i = 0; i < liRelacjaMusi.Items.Count; i++)
            {
                adres_rodzica.PobierzMusi.Add((String)liRelacjaMusi.Items[i]);
            }
            this.Close();
        }

        private void buUsuń_Click(object sender, EventArgs e)
        {
            if (liRelacjaMusi.SelectedIndex >= 0)
            {
                liRelacjaMusi.Items.RemoveAt(liRelacjaMusi.SelectedIndex);
            }
        }

        private void buUsuń2_Click(object sender, EventArgs e)
        {
            if (liRelacjaNieMoże.SelectedIndex >= 0)
            {
                liRelacjaNieMoże.Items.RemoveAt(liRelacjaNieMoże.SelectedIndex);
            }
        }

        private void Relacje_FormClosing(object sender, FormClosingEventArgs e)
        {
            adres_rodzica.Enabled = true;
        }
    }
}
