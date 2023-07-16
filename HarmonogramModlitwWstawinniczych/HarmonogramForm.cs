using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harmonogram_Harmonogram;
using SeminarzyściForm;
using Seminarzysta_Harmonogram;
using Sala_Harmonogram;
using SaleForm;
using OpisyDni_Harmonogram;
using WstawinnicyForma;
using System.IO;

namespace HarmonogramForma
{
    public partial class HarmonogramForm : Form
    {
        private HarmonogramDane h;
        private Label[] godziny;
        //private Label[] opisy_dni;
        private CheckBox[] zaznacz = new CheckBox[48];
        private OpisyDni adres;
        private Graphics g;
        private bool[,] czy_zaznaczony;
        private WstawiennikForm adres_formy_wst;
        private opis_wstawinnika ows;
        private SeminarzystaForm adres_formy_sem;
        private opis_seminarzysty ose;
        private SalaForm adres_formy_sala;
        private opis_sali osa;
        private short kto_wywołał;
        private int[] liczba_terminów;
        private int ilość_zaznaczeń;
        private int index_tmp = 0;
        
        public HarmonogramForm(OpisyDni od, WstawiennikForm w, opis_wstawinnika ow, short kto)
        {
            InitializeComponent();  
            adres = od;
            kto_wywołał = kto;
            adres_formy_wst = w;
            ows = ow;
        }

        public HarmonogramForm(OpisyDni od, SeminarzystaForm s, opis_seminarzysty os, short kto)
        {
            InitializeComponent();
            adres = od;
            kto_wywołał = kto;
            adres_formy_sem = s;
            ose = os;
        }

        public HarmonogramForm(OpisyDni od, SalaForm sa, opis_sali osal, short kto)
        {
            InitializeComponent();
            adres = od;
            kto_wywołał = kto;
            adres_formy_sala = sa;
            osa = osal;
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HarmonogramForm_Load(object sender, EventArgs e)
        {
            liczba_terminów = new int[adres.liczba_dni];
            g = Graphics.FromHwnd(this.Handle);
            godziny = new Label[48];
            //opisy_dni = new Label[adres.liczba_dni];
            h = new HarmonogramDane(adres);
            //oś X
            for (int i = 0; i < 48; i++)
            {
                godziny[i] = new Label();
                godziny[i].Parent = this;
                string godzina;
                int tmp = i / 2;
                godzina = tmp.ToString();
                if (i % 2 == 0)
                {
                    godzina = godzina + ":00";
                }
                else
                {
                    godzina = godzina + ":30";
                }
                godziny[i].Text = godzina.ToString();
                godziny[i].Left = (i * 40) % (24 * 40);
                if (i < 24)
                    godziny[i].Top = 60;
                else
                    godziny[i].Top = 100;
                godziny[i].Visible = true;
                godziny[i].AutoSize = true;
            }
            for (int i = 0; i < 48; i++)
            {
                zaznacz[i] = new CheckBox();
                zaznacz[i].Parent = this;
                zaznacz[i].Checked = false;
                zaznacz[i].Width = 10;
                zaznacz[i].Height = 10;
                zaznacz[i].Left = godziny[i].Left + 5;
                zaznacz[i].Top = godziny[i].Top + 20;
                zaznacz[i].CheckedChanged += checkBox1_CheckedChanged;
                zaznacz[i].Tag = i;
            }
            RysujTabelę();
            if(adres.liczba_dni != 0){
                czy_zaznaczony = new bool[adres.liczba_dni, 48];
                string[] dni = new string[1];
                dni = adres.opisy_dni;
                for(int i=0;i<dni.Length;i++)
                {
                    coDzień.Items.Add(new object());
                    coDzień.Items[i] = dni[i];
                }
                coDzień.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Najpierw wprowadź dane o dniach modlitw wstawienniczych!");
                Close();
            }
            if (kto_wywołał == 0)
                czy_zaznaczony = ows.h.czy_wolne;
            else if (kto_wywołał == 1)
                czy_zaznaczony = ose.h.czy_wolne;
            else
                czy_zaznaczony = osa.h.czy_wolne;
            coDzień_SelectedIndexChanged(null, null);
        }

        private void HarmonogramForm_Paint(object sender, PaintEventArgs e)
        {
            RysujTabelę();   
        }

        private void RysujTabelę()
        {
            for (int i = 0; i <= 24; i++)
                g.DrawLine(new Pen(Color.Black), i * 40 - 5, 55, i * 40 - 5, 132);
            g.DrawLine(new Pen(Color.Black), 0, 54, 955, 54);
            g.DrawLine(new Pen(Color.Black), 0, 76, 955, 76);
            g.DrawLine(new Pen(Color.Black), 0, 94, 955, 94);
            g.DrawLine(new Pen(Color.Black), 0, 114, 955, 114);
            g.DrawLine(new Pen(Color.Black), 0, 132, 955, 132);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmp = new CheckBox();
            tmp = (CheckBox)sender;
            czy_zaznaczony[coDzień.SelectedIndex, (int)tmp.Tag] = tmp.Checked;
            if (tmp.Checked == true)
            {
                ilość_zaznaczeń++;
            }
            else
            {
                ilość_zaznaczeń--;
            }
        }

        private void coDzień_SelectedIndexChanged(object sender, EventArgs e)
        {
            liczba_terminów[index_tmp] = ilość_zaznaczeń;
            index_tmp = coDzień.SelectedIndex;
            for (int i = 0; i < 48; i++)
            {
                if (czy_zaznaczony[coDzień.SelectedIndex, i])
                {
                    zaznacz[i].Checked = true;
                }
                else
                {
                    zaznacz[i].Checked = false;
                }
            }
        }

        private void HarmonogramForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch(kto_wywołał)
            {
                case 0: adres_formy_wst.Enabled = true; break;
                case 1: adres_formy_sem.Enabled = true; break;
                case 2: adres_formy_sala.Enabled = true; break;
            }
        }

        private void buAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            liczba_terminów[index_tmp] = ilość_zaznaczeń;
            h.czy_wolne = czy_zaznaczony;
            int l_ter = 0;
            for (int i = 0; i < liczba_terminów.Length; i++)
            {
                l_ter = l_ter + liczba_terminów[i];
            }
            if (kto_wywołał == 0)
            {
                adres_formy_wst.liczba_terminów_ = l_ter;
                adres_formy_wst.DajHarmonogram = czy_zaznaczony;
                adres_formy_wst.rys_adres.Load(Directory.GetCurrentDirectory() + "\\rysunki\\ok.bmp");
            }
            else if (kto_wywołał == 1)
            {
                adres_formy_sem.liczba_terminów_ = l_ter;
                adres_formy_sem.DajHarmonogram = czy_zaznaczony;
                adres_formy_sem.rys_adres.Load(Directory.GetCurrentDirectory() + "\\rysunki\\ok.bmp");
            }
            else
            {
                adres_formy_sala.liczba_terminów_ = l_ter;
                adres_formy_sala.op_sali.h.czy_wolne = czy_zaznaczony;
                adres_formy_sala.rys_adres.Load(Directory.GetCurrentDirectory() + "\\rysunki\\ok.bmp");
            }
            this.Close();
        }

        private void HarmonogramForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void HarmonogramForm_Activated(object sender, EventArgs e)
        {
        }
    }
}
