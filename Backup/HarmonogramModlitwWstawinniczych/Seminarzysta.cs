using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmonogram_Harmonogram;
using Wstawinnik_Harmonogram;

namespace Seminarzysta_Harmonogram
{
    public struct Relacja
    {
        public byte typ;
        /* 0 - może być omadlany przez... (domyślnie)
         * 1 - musi być omadlany przez...
         * 2 - nie może być omadlany przez...
        */
        public Wstawiennik w; //null jeśli typ = 0
    }
    public class Seminarzysta
    {
        private string _imię;
        private string _nazwisko;
        private bool _płeć;
        private int _liczba_terminów;
        private HarmonogramDane _h;
        private byte _grupa_wymagana;
        private bool _wymaga_egzorcysty;
        private Relacja _r;
        private List<String> _musi;
        private List<String> _nie_może;
        //właściwości
        public string imię
        {
            get
            {
                return _imię;
            }
            set
            {
                _imię = value;
            }
        }
        public string nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }
        public bool płeć
        {
            get
            {
                return _płeć;
            }
            set
            {
                _płeć = value;
            }
        }
        public int liczba_terminów
        {
            get
            {
                return _liczba_terminów;
            }
            set
            {
                _liczba_terminów = value;
            }
        }
        public HarmonogramDane h
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
        public byte grupa_wymagana
        {
            get
            {
                return _grupa_wymagana;
            }
            set
            {
                _grupa_wymagana = value;
            }
        }
        public bool wymaga_egzorcysty
        {
            get
            {
                return _wymaga_egzorcysty;
            }
            set
            {
                _wymaga_egzorcysty = value;
            }
        }
        public Relacja r
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }
        public List<String> musi
        {
            get
            {
                return _musi;
            }
            set
            {
                _musi = value;
            }
        }
        public List<String> nie_może
        {
            get
            {
                return _nie_może;
            }
            set
            {
                _nie_może = value;
            }
        }
    }
}
