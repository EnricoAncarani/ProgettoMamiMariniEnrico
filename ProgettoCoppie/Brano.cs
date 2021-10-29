using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCoppie
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durata;

        #region set/get

        public string Titolo
        {
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Titolo inserito non valido");

                _titolo = value;
            }

            get{return _titolo;}
        }

        public string Autore
        {
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Autore inserito non valido");

                _autore = value;
            }

            get { return _autore; }
        }

        public int Durata
        {
            private set
            {
                if (value < 0)
                    throw new Exception("Durata inserita non valida");

                _durata = value;
            }

            get { return _durata; }
        }
        #endregion

        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public bool shortSong(int durata)
        {
            if(_durata < durata) { return true; }
            else { return false; }            
        }

        public override string ToString()
        {
            return "Titolo: '" + _titolo + "' Autore: " + _autore + " Durata : " + _durata + " secondi";
        }
    }
}
