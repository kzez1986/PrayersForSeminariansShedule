using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpisyDni_Harmonogram;
using HarmonogramModlitwWstawinniczych;
using System.IO;

namespace MenadżerDni
{
    public partial class MenadzerDni : Form
    {
        private OpisyDni od_adres;
        private Harmonogram adres;
        public MenadzerDni(OpisyDni od, Harmonogram adr)
        {
            InitializeComponent();
            od_adres = od;
            adres = adr;
        }

        private void MenadzerDni_Load(object sender, EventArgs e)
        {
            //uzupełnianie danych
            int dni = od_adres.liczba_dni;
            string[] dane;
            dane = od_adres.opisy_dni;
            for (int i = 0; i < dni; i++)
            {
                liDni.Items.Add(dane[i]);
            }
        }

        private void MenadzerDni_FormClosed(object sender, FormClosedEventArgs e)
        {
            adres.Enabled = true;
        }

        private void buDodaj_Click(object sender, EventArgs e)
        {
            liDni.Items.Add(teOpis.Text);
        }

        private void caData_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d = caData.SelectionStart;
            teOpis.Clear();
            //int liczba = (int)d.DayOfWeek;
            if ((int)d.DayOfWeek == 0)
                teOpis.Text = "Niedziela";
            if ((int)d.DayOfWeek == 1)
                teOpis.Text = "Poniedziałek";
            if ((int)d.DayOfWeek == 2)
                teOpis.Text = "Wtorek";
            if ((int)d.DayOfWeek == 3)
                teOpis.Text = "Środa";
            if ((int)d.DayOfWeek == 4)
                teOpis.Text = "Czwartek";
            if ((int)d.DayOfWeek == 5)
                teOpis.Text = "Piątek";
            if ((int)d.DayOfWeek == 6)
                teOpis.Text = "Sobota";
            teOpis.Text = teOpis.Text + " " + d.Day.ToString() + "." + d.Month.ToString() + "." + d.Year.ToString();
        }

        private void caData_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buUsuń_Click(object sender, EventArgs e)
        {
            if (liDni.SelectedIndex >= 0)
            {
                int indeks = liDni.SelectedIndex;
                liDni.Items.RemoveAt(liDni.SelectedIndex);
                if (liDni.Items.Count > 0 && indeks < liDni.Items.Count)
                {
                    liDni.SelectedIndex = indeks;
                }
            }
  
        }

        private void buWgórę_Click(object sender, EventArgs e)
        {
            if (liDni.SelectedIndex > 0)
            {
                object element;
                int indeks = liDni.SelectedIndex;
                element = liDni.SelectedItem;
                liDni.Items.RemoveAt(indeks);
                liDni.Items.Insert(indeks - 1, element);
                liDni.SelectedIndex = indeks - 1;
            }
        }

        private void buWdół_Click(object sender, EventArgs e)
        {
            if (liDni.SelectedIndex >= 0 && liDni.SelectedIndex < liDni.Items.Count - 1)
            {
                object element;
                int indeks = liDni.SelectedIndex;
                element = liDni.SelectedItem;
                liDni.Items.RemoveAt(indeks);
                liDni.Items.Insert(indeks + 1, element);
                liDni.SelectedIndex = indeks + 1;
            }
        }

        private void buAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            string[] dane = new string[liDni.Items.Count];
            for(int i=0;i<dane.Length;i++)
            {
                dane[i] = liDni.Items[i].ToString();
            }
            //zapis do klasy
            od_adres.opisy_dni = dane;
            //zapis do pliku
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\dni.in");
            sw.WriteLine(liDni.Items.Count);
            for (int i = 0; i < liDni.Items.Count; i++)
            {
                sw.WriteLine(dane[i]);
            }
            sw.Close();
            this.Close();
        }
    }
}
