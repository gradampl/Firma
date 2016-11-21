using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
     enum typKontraktu { staż, etat }
        class Kontrakt
        {
        private int podstawaWynagrodzenia;
        private typKontraktu typ;

        public int getPodstawa()
        {
            return podstawaWynagrodzenia;
        }
        public typKontraktu getTypKontraktu()
        {
            return typ;
        }

        public Kontrakt()
        { }


        public Kontrakt(typKontraktu typ, int podstawa)
        {
            this.typ = typ;
            this.podstawaWynagrodzenia = podstawa;
        }
        private double Pensja()
        {        
                return podstawaWynagrodzenia;
            
        }
        private double Pensja(int nadgodziny)
        {
            return podstawaWynagrodzenia + nadgodziny * (podstawaWynagrodzenia / 160);
        }
    }
    
   
}
