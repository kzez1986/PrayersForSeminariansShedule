using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmonogram_Harmonogram;

namespace Sala_Harmonogram
{
    public class Sala
    {
        private string _opis;
        private HarmonogramDane _h;
        private int _liczba_terminów;
        //właściwości
        public string opis
        {
            get
            {
                return _opis;
            }
            set
            {
                _opis = value;
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
    }
}
