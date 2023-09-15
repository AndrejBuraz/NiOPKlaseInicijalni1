using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeKlase1
{
    class Biljka
    {
        public Biljka()
        {
        }
    }

    class Stablo : Biljka
    {
        bool opadajuListovi;
        public Stablo()
        {
        }

        public Stablo(bool opadajuListovi)
        {
            this.OpadajuListovi = opadajuListovi;
        }

        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
    }

    class Cvijet : Biljka
    {
        public Cvijet()
        {
        }
    }

    class Bijelogoricno : Stablo
    {
        public Bijelogoricno()
        {
            this.OpadajuListovi = true;
        }
    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno()
        {
            this.OpadajuListovi = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno();
            Crnogoricno Bor = new Crnogoricno();
            Console.WriteLine("Hrast opadaju listovi: " + Hrast.OpadajuListovi);
            Console.WriteLine("Bor opadaju listovi: " + Bor.OpadajuListovi);
            Console.ReadKey();
        }
    }
}
