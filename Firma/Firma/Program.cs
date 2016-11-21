using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pracownik pracownik1 = new Pracownik();
            Pracownik pracownik2 = new Pracownik("Jan", "Kowalski");
            Pracownik pracownik3 = new Pracownik("Piotr", "Wróbel", typKontraktu.etat, 3000);
            pracownik3.wypiszInfo();
            pracownik2.wypiszInfo();
            Console.ReadKey();
        }
    }
}
