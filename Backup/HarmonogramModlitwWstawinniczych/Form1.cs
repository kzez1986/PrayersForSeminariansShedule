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
using Sala_Harmonogram;
using Harmonogram_Harmonogram;
using MenadżerDni;
using OpisyDni_Harmonogram;
using System.IO;
using WstawinnicyForma;
using SeminarzyściForm;
using SaleForm;
using Modlitwa_Harmonogram;

namespace HarmonogramModlitwWstawinniczych
{
    public struct ZmianaHarmonogramuWstawiennika
    {
        public short nr_wstaw;
        public short nr_dnia;
        public short nr_godz;
    }

    public struct DanePomocnicze
    {
        public int j;
        public int k;
        public int l;
        public int m;
        public int n;
    }
    
    public partial class Harmonogram : Form
    {
        private OpisyDni opd;
        private Seminarzysta[] s;
        private Wstawiennik[] w;
        private Sala[] sal;
        private string[] dane;
        private byte algorytm = 0;
        public Harmonogram()
        {
            InitializeComponent();
            Wczytaj();
        }

        private void Harmonogram_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void daneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenadzerDni m = new MenadzerDni(opd, this);
            m.Visible = true;
            this.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WstawiennikForm wstaw = new WstawiennikForm(opd, this, w);
            wstaw.Visible = true;
            //this.Enabled = false;
        }

        private void buKreatorSeminarzystów_Click(object sender, EventArgs e)
        {
            SeminarzystaForm sem = new SeminarzystaForm(opd, this, w);
            sem.Visible = true;
            this.Enabled = false;
        }
        public void Wczytaj()
        {
            WczytajOpisyDni();
            WczytajWstawienników();
            WczytajSeminarzystów();
            WczytajSale();
        }
        public void WczytajOpisyDni()
        {
            opd = new OpisyDni();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\dni.in"))
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\dni.in");
                int długość_pliku = int.Parse(sr.ReadLine());
                dane = new string[długość_pliku];
                for (int i = 0; i < długość_pliku; i++)
                {
                    dane[i] = sr.ReadLine();
                }
                //uzupełnianie klasy
                opd.opisy_dni = dane;
                sr.Close();
            }
        }
        public void WczytajWstawienników()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\wstawiennicy.in"))
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\wstawiennicy.in");
                int długość_pliku = int.Parse(sr.ReadLine());
                w = new Wstawiennik[długość_pliku];
                for (int i = 0; i < długość_pliku; i++)
                {
                    w[i] = new Wstawiennik();
                    w[i].imię = sr.ReadLine();
                    w[i].nazwisko = sr.ReadLine();
                    w[i].płeć = bool.Parse(sr.ReadLine());
                    w[i].max_modlitw = short.Parse(sr.ReadLine());
                    w[i].liczba_terminów = int.Parse(sr.ReadLine());
                    w[i].h = WczytajHarmonogram(ref sr);
                    w[i].doświadczenie = bool.Parse(sr.ReadLine());
                    w[i].egzorcysta = bool.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            else
            {
                w = new Wstawiennik[0];
            }
        }
        public void WczytajSeminarzystów()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\seminarzysci.in"))
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\seminarzysci.in");
                int długość_pliku = int.Parse(sr.ReadLine());
                s = new Seminarzysta[długość_pliku];
                for (int i = 0; i < długość_pliku; i++)
                {
                    s[i] = new Seminarzysta();
                    s[i].imię = sr.ReadLine();
                    s[i].nazwisko = sr.ReadLine();
                    s[i].płeć = bool.Parse(sr.ReadLine()); 
                    s[i].h = WczytajHarmonogram(ref sr);
                    s[i].grupa_wymagana = byte.Parse(sr.ReadLine());
                    s[i].wymaga_egzorcysty = bool.Parse(sr.ReadLine());
                    s[i].musi = new List<string>();
                    int tmp = int.Parse(sr.ReadLine());
                    for (int j = 0; j < tmp; j++)
                    {
                        s[i].musi.Add(sr.ReadLine());
                    }
                    s[i].nie_może = new List<string>();
                    tmp = int.Parse(sr.ReadLine());
                    for (int j = 0; j < tmp; j++)
                    {
                        s[i].nie_może.Add(sr.ReadLine());
                    }
                    s[i].liczba_terminów = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
        }
        public void WczytajSale()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\sale.in"))
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\sale.in");
                int długość_pliku = int.Parse(sr.ReadLine());
                sal = new Sala[długość_pliku];
                for (int i = 0; i < długość_pliku; i++)
                {
                    sal[i] = new Sala();
                    sal[i].opis = sr.ReadLine();
                    sal[i].liczba_terminów = int.Parse(sr.ReadLine());
                    sal[i].h = WczytajHarmonogram(ref sr);
                }
                sr.Close();
            }
        }
        private HarmonogramDane WczytajHarmonogram(ref StreamReader reader)
        {
            HarmonogramDane h = new HarmonogramDane(opd);
            bool[,] tmp = new bool[opd.liczba_dni,48];
            for (int i = 0; i < opd.liczba_dni; i++)
            {
                for (int j = 0; j < 48; j++)
                {
                    int wart = reader.Read();
                    if (wart == 48)
                        tmp[i, j] = false;
                    else
                        tmp[i,j] = true;
                }
                reader.ReadLine(); //znak końca linii
            }
            h.czy_wolne = tmp;
            return h;
        }

        private void buKreatorSal_Click(object sender, EventArgs e)
        {
            SalaForm sa = new SalaForm(opd, this);
            sa.Visible = true;
            this.Enabled = false;
        }

        private void ądanieWszystkichPrzypadkówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm = 0;
        }

        private void ąceNajmniejCzasuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm = 1;
        }

        private void poRównoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm = 2;
        }

        private void buTwórzHarmonogram_Click(object sender, EventArgs e)
        {            
            Modlitwa[] mo = new Modlitwa[s.Length];
            bool utworzono = false;
            /*
            if (algorytm == 1) //najmniej terminów - najpierw
            {
                //Sortowanie
                SortujWstawiennikówPoIlościTerminów();
                SortujSeminarzystówPoIlościTerminów();
                SortujSalePoIlościTerminów();
            }
            */
            if (algorytm == 0) //znajdź pierwsze rozwiązanie
            {     
                Stack<ZmianaHarmonogramuWstawiennika> zm = new Stack<ZmianaHarmonogramuWstawiennika>();
                ZmianaHarmonogramuWstawiennika zm_tmp = new ZmianaHarmonogramuWstawiennika();
                Stack<DanePomocnicze> dp = new Stack<DanePomocnicze>();
                DanePomocnicze dp_temp = new DanePomocnicze();
                bool wejście_do_środka = false;
                //analiza seminarzystów
                for (int i = 0; i < s.Length; i++) //poziom seminarzysty
                {
                next:
                    if (i == s.Length) //utworzono harmonogram
                    {
                        utworzono = true;
                        goto koniec;
                    }
                    for (int j = 0; j < opd.liczba_dni; j++) //poziom dni
                    {
                        dp_temp.j = j;
                        for (int k = 0; k < 47; k++) //poziom godzin, bez ostatniej gdyż 1 modlitwa = 2 jednostki
                        {
                            dp_temp.k = k;
                            for (int l = 0; l < w.Length; l++) //poziom pierwszego wstawiennika
                            {
                                dp_temp.l = l;
                                if ((s[i].h.czy_wolne[j, k] == true && w[l].h.czy_wolne[j, k] == true && s[i].h.czy_wolne[j, k + 1] == true && w[l].h.czy_wolne[j, k + 1] == true)||(wejście_do_środka == true)) //sprawdzenie harmonogramu seminarzysty z 1 wstawiennikiem 1 modlitwa == 2 jednostki czasu
                                {
                                    if (Pasuje(w[l], s[i])||wejście_do_środka == true) //czy 1 wstawiennik1 może omadlać aktualnego seminarzystę
                                    {
                                        //oznacz w harmonogramie wstawiennika
                                        w[l].h.czy_wolne[j, k] = false;
                                        w[l].h.czy_wolne[j, k + 1] = false;
                                        //zapisać w stosie zmian
                                        zm_tmp.nr_wstaw = (short)l;
                                        zm_tmp.nr_dnia = (short)j;
                                        zm_tmp.nr_godz = (short)k;
                                        zm.Push(zm_tmp);
                                        for (int m = l + 1; m < w.Length; m++) //poziom 2 wstawiennika
                                        {
                                            dp_temp.m = m;
                                            if ((s[i].h.czy_wolne[j, k] == true && w[m].h.czy_wolne[j, k] == true && s[i].h.czy_wolne[j, k + 1] == true && w[m].h.czy_wolne[j, k + 1] == true)||(wejście_do_środka == true)) //sprawdzenie harmonogramu seminarzysty z 2 wstawiennikiem 1 modlitwa == 2 jednostki czasu
                                            {
                                                if (Pasuje(w[m], s[i])||wejście_do_środka == true) //czy 2 wstawiennik może omadlać aktualnego seminarzystę
                                                {
                                                    //oznacz w harmonogramie wstawiennika
                                                    w[m].h.czy_wolne[j, k] = false;
                                                    w[m].h.czy_wolne[j, k + 1] = false;
                                                    //zapisać w stosie zmian
                                                    zm_tmp.nr_wstaw = (short)m;
                                                    zm_tmp.nr_dnia = (short)j;
                                                    zm_tmp.nr_godz = (short)k;
                                                    zm.Push(zm_tmp);
                                                    for (int n = m + 1; n < w.Length; n++) //poziom 3 wstawiennika
                                                    {
                                                        dp_temp.n = n;
                                                        if ((s[i].h.czy_wolne[j, k] == true && w[n].h.czy_wolne[j, k] == true && s[i].h.czy_wolne[j, k + 1] == true && w[n].h.czy_wolne[j, k + 1] == true)||(wejście_do_środka == true)) //sprawdzenie harmonogramu seminarzysty z 3 wstawiennikiem 1 modlitwa == 2 jednostki czasu
                                                        {
                                                            if (Pasuje(w[n], s[i])||wejście_do_środka == true)//sprawdzenie harmonogramu seminarzysty z 3 wstawiennikiem
                                                            {
                                                                //oznacz w harmonogramie
                                                                //oznacz w harmonogramie wstawiennika
                                                                w[n].h.czy_wolne[j, k] = false;
                                                                w[n].h.czy_wolne[j, k + 1] = false;
                                                                //zapisać w stosie zmian
                                                                zm_tmp.nr_wstaw = (short)n;
                                                                zm_tmp.nr_dnia = (short)j;
                                                                zm_tmp.nr_godz = (short)k;
                                                                zm.Push(zm_tmp);
                                                                //sprawdź warunki końcowe
                                                                if (WarunkiKońcowe(w[l], w[m], w[n], s[i])|| wejście_do_środka == true)
                                                                {
                                                                    for (int o = 0; o < sal.Length; o++) //poziom sal
                                                                    {
                                                                        if (wejście_do_środka)
                                                                        {
                                                                            wejście_do_środka = false;
                                                                            i--; //przejście do poprzedniego przypadku
                                                                            //czyszczenie bzdur wstawionych przy wejściu do pętli
                                                                            zm_tmp = zm.Pop();
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                                            zm_tmp = zm.Pop();
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                                            zm_tmp = zm.Pop();
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                                            w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                                            //wyrzucenie informacji o sali
                                                                            zm_tmp = zm.Pop();
                                                                            //przygotowanie do badania kolejnej sali
                                                                            o = zm_tmp.nr_wstaw; //w następnym obrocie pętli będzie następna sala
                                                                            //skasowanie informacji o harmonogramie sali
                                                                            s[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                                            s[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                                            //przywracanie parametrów poprzedniego sprawdzania, na którym zakończono
                                                                            dp_temp = dp.Pop();
                                                                            j = dp_temp.j;
                                                                            k = dp_temp.k;
                                                                            l = dp_temp.l;
                                                                            m = dp_temp.m;
                                                                            n = dp_temp.n;
                                                                            w[l].ustawiono_modlitw--;
                                                                            w[m].ustawiono_modlitw--;
                                                                            w[n].ustawiono_modlitw--;
                                                                        }
                                                                        else if (s[i].h.czy_wolne[j, k] == true && sal[o].h.czy_wolne[j, k] == true && s[i].h.czy_wolne[j, k + 1] == true && sal[o].h.czy_wolne[j, k + 1] == true)
                                                                        {
                                                                            //zapisz modlitwę
                                                                            mo[i] = new Modlitwa();
                                                                            mo[i].w[0] = w[l];
                                                                            mo[i].w[1] = w[m];
                                                                            mo[i].w[2] = w[n];
                                                                            mo[i].s = s[i];
                                                                            mo[i].dzień = opd.opisy_dni[j];
                                                                            mo[i].godzina = (short)(k / 2);
                                                                            mo[i].sal = sal[o];
                                                                            if (k % 2 == 0)
                                                                            {
                                                                                mo[i].minuty = 0;
                                                                            }
                                                                            else
                                                                            {
                                                                                mo[i].minuty = 30;
                                                                            }
                                                                            //uaktualnij dane o liczbie modlitw wstawienników
                                                                            w[l].ustawiono_modlitw++;
                                                                            w[m].ustawiono_modlitw++;
                                                                            w[n].ustawiono_modlitw++;
                                                                            //zapisz do harmonogramu sali
                                                                            sal[o].h.czy_wolne[j, k] = false;
                                                                            sal[o].h.czy_wolne[j, k + 1] = false;
                                                                            zm_tmp.nr_wstaw = (short)o;
                                                                            zm_tmp.nr_dnia = (short)j;
                                                                            zm_tmp.nr_godz = (short)k;
                                                                            zm.Push(zm_tmp);
                                                                            //zapisz j i k
                                                                            dp.Push(dp_temp);
                                                                            //przygotowanie do analizy kolejnego seminarzysty
                                                                            i++;
                                                                            j = 0;
                                                                            k = 0;
                                                                            l = 0;
                                                                            m = 0;
                                                                            n = 0;
                                                                            o = 0;
                                                                            goto next;
                                                                        }
                                                                    }
                                                                }
                                                                //cofnięcie do nast. wstawiennika poziomu 3
                                                                zm_tmp = zm.Pop();
                                                                w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                                w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                                //jeśli nie zostanie znaleziona sala dla danej kombinacji, to na pewno inna kombinacja wstawienników dla tego dnia i godziny też nic nie da
                                                                //trzeba więc cofnąć się aż do godzin
                                                                l = w.Length;
                                                                m = w.Length;
                                                                n = w.Length;
                                                            }
                                                        }
                                                    }
                                                    //cofnięcie do nast. wstawiennika poziomu 2
                                                    zm_tmp = zm.Pop();
                                                    w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                                    w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                                }
                                            }
                                        }
                                        //cofnięcie do nast. wstawiennika poziomu 1
                                        zm_tmp = zm.Pop();
                                        w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz] = true;
                                        w[zm_tmp.nr_wstaw].h.czy_wolne[zm_tmp.nr_dnia, zm_tmp.nr_godz + 1] = true;
                                    }
                                }
                            }
                            if (k == 46 && j + 1 == opd.liczba_dni) //do seminarzysty nic nie pasuje
                            {
                                if (i == 0)
                                {
                                    MessageBox.Show("Nie da się utworzyć harmonogramu dla podanych danych wejściowych.");
                                    i = s.Length; //aby nastąpiło wyjście z pętli
                                    j = opd.liczba_dni;
                                    k = 48;
                                }
                                else
                                {
                                    //cofanie do poprzedniego wstawiennika
                                    wejście_do_środka = true;
                                    k = 0; //aby nie zmienił i
                                 }
                            }
                        }
                    }
                }
            koniec:
                if(utworzono)
                    MessageBox.Show("Utworzono harmonogram");
            }
            else //po równo
            {
            }
            //zapis danych do pliku
            if (utworzono)
            {
                StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\harmonogram.out");
                for (int i = 0; i < s.Length; i++)
                {
                    sw.WriteLine(mo[i].s.imię + " " + mo[i].s.nazwisko);
                    sw.WriteLine(mo[i].w[0].imię + " " + mo[i].w[0].nazwisko);
                    sw.WriteLine(mo[i].w[1].imię + " " + mo[i].w[1].nazwisko);
                    sw.WriteLine(mo[i].w[2].imię + " " + mo[i].w[2].nazwisko);
                    string minuty;
                    if (mo[i].minuty == 0)
                        minuty = "00";
                    else
                        minuty = "30";
                    sw.WriteLine(mo[i].dzień + " " + mo[i].godzina.ToString() + ":" + minuty);
                    sw.WriteLine(mo[i].sal.opis);
                    sw.WriteLine("-------------------------------");
                }
                sw.Close();
            }
            //zakończenie pracy i przywrócenie oryginalnych danych
            Wczytaj();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        /*
        public void SortujSalePoIlościTerminów()
        {
            Sala sal_temp = new Sala();
            for (int i = 0; i < sal.Length; i++)
            {
                int min_index = i;
                for (int j = 0; j < sal.Length; j++)
                {
                    if (sal[j].liczba_terminów < sal[i].liczba_terminów)
                    {
                        min_index = j;
                    }
                }
                //zamiana
                sal_temp = sal[i];
                sal[i] = sal[min_index];
                sal[min_index] = sal_temp;
            }
        }

        public void SortujWstawiennikówPoIlościTerminów()
        {
            Wstawiennik w_temp = new Wstawiennik();
            for (int i = 0; i < w.Length; i++)
            {
                int min_index = i;
                for (int j = 0; j < w.Length; j++)
                {
                    if (w[j].liczba_terminów < w[i].liczba_terminów)
                    {
                        min_index = j;
                    }
                }
                //zamiana
                w_temp = w[i];
                w[i] = w[min_index];
                w[min_index] = w_temp;
            }
        }

        public void SortujSeminarzystówPoIlościTerminów()
        {
            Seminarzysta s_temp = new Seminarzysta();
            for (int i = 0; i < s.Length; i++)
            {
                int min_index = i;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j].liczba_terminów < s[i].liczba_terminów)
                    {
                        min_index = j;
                    }
                }
                //zamiana
                s_temp = s[i];
                s[i] = s[min_index];
                s[min_index] = s_temp;
            }
        }
        */
        //public bool CzySpełniaWarunki(Seminarzysta se, Czas cz)
        //{
        //}

        public bool Pasuje(Wstawiennik wst, Seminarzysta sem)
        {
            //warunek płci będzie ignorowany jeśli dany wstawiennik musi omadlać seminarzystę
            bool warunek_płci = true;
            for (int i = 0; i < sem.musi.Count; i++)
            {
                if (sem.musi[i].Equals(wst.imię + " " + wst.nazwisko))
                    warunek_płci = false;
            }
            //warunek płci
            if (warunek_płci)
            {
                if (wst.płeć != sem.płeć)
                    return false;
            }
            //czy nie przekracza max modlitw
            if (wst.max_modlitw != 0) //0 oznacza brak limitów
            {
                if (wst.max_modlitw <= wst.ustawiono_modlitw)
                    return false;
            }
            return true;
        }

        public bool WarunkiKońcowe(Wstawiennik w1, Wstawiennik w2, Wstawiennik w3, Seminarzysta sem)
        {
            //relacje
            String[] im_na = new String[3];
            im_na[0] = w1.imię + " " + w1.nazwisko;
            im_na[1] = w2.imię + " " + w2.nazwisko;
            im_na[2] = w3.imię + " " + w3.nazwisko;
            //musi
            for (int i = 0; i < sem.musi.Count; i++)
            {
                if(!im_na[0].Equals(sem.musi[i]) && !im_na[1].Equals(sem.musi[i]) && !im_na.Equals(sem.musi[i]))
                    return false;
            }
            //nie może
            for (int i = 0; i < sem.nie_może.Count; i++)
            {
                if (im_na[0].Equals(sem.nie_może[i]) || im_na[1].Equals(sem.nie_może[i]) || im_na.Equals(sem.nie_może[i]))
                    return false;
            }
            //liczba doświadczonych wstawienników
            byte ilu_doświadczonych = 0;
            if (w1.doświadczenie == true) ilu_doświadczonych++;
            if (w2.doświadczenie == true) ilu_doświadczonych++;
            if (w3.doświadczenie == true) ilu_doświadczonych++;
            if (ilu_doświadczonych < sem.grupa_wymagana)
                return false;
            //egzorcysta
            if (w1.egzorcysta == false && w2.egzorcysta == false && w3.egzorcysta == false && sem.wymaga_egzorcysty == true)
                return false;
            return true;
        }
    }
}
