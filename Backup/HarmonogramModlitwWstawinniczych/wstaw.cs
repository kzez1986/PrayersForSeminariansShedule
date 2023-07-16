using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmonogram_Harmonogram;

namespace Wstawinnik_Harmonogram
{
    public class Wstawiennik
    {
        //pola
        private string _imię;
        private string _nazwisko;
        private bool _płeć;
        private short _max_modlitw;
        private short _ustawiono_modlitw;
        private int _liczba_terminów;
        private HarmonogramDane _h;
        private bool _doświadczenie;
        private bool _egzorcysta;
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
        public short max_modlitw
        {
            get
            {
                return _max_modlitw;
            }
            set
            {
                _max_modlitw = value;
            }
        }
        public short ustawiono_modlitw
        {
            get
            {
                return _ustawiono_modlitw;
            }
            set
            {
                _ustawiono_modlitw = value;
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
        public bool doświadczenie
        {
            get
            {
                return _doświadczenie;
            }
            set
            {
                _doświadczenie = value;
            }
        }
        public bool egzorcysta
        {
            get
            {
                return _egzorcysta;
            }
            set
            {
                _egzorcysta = value;
            }
        }
    }
}
