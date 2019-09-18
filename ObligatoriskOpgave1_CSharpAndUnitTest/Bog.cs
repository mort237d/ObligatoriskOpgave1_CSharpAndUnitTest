using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatoriskOpgave1_CSharpAndUnitTest
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Bog()
        {
            
        }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            Titel = titel;
            Forfatter = forfatter;
            Sidetal = sidetal;
            Isbn13 = isbn13;
        }

        public string Titel
        {
            get => _titel;
            set
            {
                if (value.Length <= 2) throw new ArgumentException("Titlen skal være mere end 1 bogstav langt.", Titel);
                _titel = value;
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set => _forfatter = value;
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value < 10 || value > 1000) throw new ArgumentOutOfRangeException(nameof(value));
                _sidetal = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length != 13) throw new ArgumentException("ISBN13 skal være 13 karaktere.", Isbn13);
                _isbn13 = value;
            }
        }
    }
}
