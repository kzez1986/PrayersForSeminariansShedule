using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpisyDni_Harmonogram
{
    public class OpisyDni //jedna instancja
    {
        //pola
        private int _liczba_dni;
        private string[] _opisy_dni;
        //właściwości
        public int liczba_dni
        {
            set
            {
                //_opisy_dni = new string[_liczba_dni];
                _liczba_dni = value;
            }
            get
            {
                return _liczba_dni;
            }
        }
        public string[] opisy_dni
        {
            set
            {
                _opisy_dni = value;
                liczba_dni = _opisy_dni.Length;
            }
            get
            {
                return _opisy_dni;
            }
        }
        //metody
    }
}
