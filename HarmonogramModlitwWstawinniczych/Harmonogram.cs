using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpisyDni_Harmonogram;

namespace Harmonogram_Harmonogram
{
    public class HarmonogramDane
    {
        //pola
        private OpisyDni _opis;
        private bool[,] _czy_wolne;
        //właściwości
        public bool[,] czy_wolne
        {
            get
            {
                return _czy_wolne;
            }
            set
            {
                _czy_wolne = value;
            }
        }
        public OpisyDni opis
        {
            get
            {
                return _opis;
            }
        }
        //metody
        public HarmonogramDane(OpisyDni adres)
        {
            _opis = adres;
            _czy_wolne = new bool[_opis.liczba_dni,48];
        }
        
    }
}
