using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Pracownik
    {
        private string imie;
        private string nazwisko;
        private Kontrakt kontrakt;
        //  public Pracownik() { }

        public Pracownik()
        {
            Kontrakt kontrakt = new Kontrakt();

        }
        public Pracownik(string imie, string nazwisko, typKontraktu kontrakt, int podstawa)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            Kontrakt umowa = new Kontrakt(kontrakt, podstawa);
        }

        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            typKontraktu kontrakt = typKontraktu.staż;
            int podstawa = 2000;
            Kontrakt umowa = new Kontrakt(kontrakt, podstawa);
        }
        public override string ToString()
        {
            return String.Format("Imie: {0}, nazwisko:{1}, podstawa{2}", imie, nazwisko, kontrakt.getPodstawa());
        }
    }
}
