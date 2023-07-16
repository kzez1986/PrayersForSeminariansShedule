using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wstawinnik_Harmonogram;
using Seminarzysta_Harmonogram;
using Sala_Harmonogram;

namespace Modlitwa_Harmonogram
{
    public class Modlitwa
    {
        //pola
        private Seminarzysta _s;
        private Wstawiennik[] _w;
        private String _dzień;
        private short _godzina;
        private short _minuty;
        private Sala _sal;
        //właściwości
        public Seminarzysta s
        {
            get
            {
                return _s;
            }
            set
            {
                _s = value;
            }
        }
        public Wstawiennik[] w
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }
        public String dzień
        {
            get
            {
                return _dzień;
            }
            set
            {
                _dzień = value;
            }
        }
        public short godzina
        {
            get
            {
                return _godzina;
            }
            set
            {
                _godzina = value;
            }
        }
        public short minuty
        {
            get
            {
                return _minuty;
            }
            set
            {
                _minuty = value;
            }
        }
        public Sala sal
        {
            get
            {
                return _sal;
            }
            set
            {
                _sal = value;
            }
        }
        //metody
        public Modlitwa()
        {
            _w = new Wstawiennik[3];
            _s = new Seminarzysta();
            _sal = new Sala();
        }
    }
}
