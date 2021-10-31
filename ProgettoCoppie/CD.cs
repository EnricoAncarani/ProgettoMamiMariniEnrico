using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCoppie
{
    class CD
    {
        private string _autore;
        private string _titolo;
        private List<Brano> _brani;
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Titolo non valido.");
                _titolo = value;
            }
        }
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Autore non valido.");
                _autore = value;
            }
        }
        public List<Brano> Brani
        {
            get { return _brani; }
            set { _brani = value; }
        }
        public CD(string titolo, string autore)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<Brano>();
        }

        public void addBrano(Brano b)
        {
            _brani.Add(b);
        }

        public int DurataCD()
        {
            int durataCD = 0;
            foreach (Brano b in _brani)
            {
                durataCD = durataCD + b.Durata;
            }
            return durataCD;
        }
        public override string ToString()
        {
            
            return _autore+""+_titolo;
        }
    }
}