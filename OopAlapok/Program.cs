using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopAlapok
{

    class Hallgato : Szemely
    {
        private string neptunKod;

        public string NeptunKod
        {
            get { return neptunKod; }
            set { neptunKod = value; }
        }


        public Hallgato(string nev, int kor, string neptunkod) : base(nev, kor)
        {
            this.Nev = nev;
            Kor = kor;
            NeptunKod = neptunkod;
        }
    }


    class BankSzamla
    {

        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set
            {
                if (egyenleg < 0) Console.WriteLine("Az egyenleg nem lehet negatív!");
                else egyenleg = value;
            }
        }


        public BankSzamla(int egyenleg)
        {
            Egyenleg = egyenleg;
        }

        public void Bevesz(int ertek)
        {
            Egyenleg += ertek;
        }

        public void Kivesz(int ertek)
        {
            if (Egyenleg - ertek < 0)
            {
                Console.WriteLine("Nincsen elég pénz!");
            }
            else
            {
                Egyenleg -= ertek;
            }
        }

    }

    class Szemely
    {
        private string nev;
        private int kor;
        public int Kor
        {
            get { return this.kor; }
            set
            {

                if (this.kor > 0)
                {
                    this.kor = value;
                }
                else { Console.WriteLine("Nem lehet negatív az életkor!"); }

            }
        }

        public string Nev { get => nev; set => nev = value; }


        public override string ToString()
        {
            return $"Név: {this.Nev}; Életkor: {Kor};";
        }


        public Szemely(string nev, int kor)
        {
            this.Nev = nev;
            Kor = kor;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely("Kiss Péter", 35);
            Szemely szemely1 = new Szemely("Személy", -1);
            Console.WriteLine(szemely1);
            BankSzamla bankSzamla1 = new BankSzamla(300);
            bankSzamla1.Bevesz(100);
            Console.WriteLine(bankSzamla1.Egyenleg);
            bankSzamla1.Kivesz(500);
            Console.WriteLine(bankSzamla1.Egyenleg);
            Hallgato hallgato = new Hallgato("Nagy János", 23, "erere23");
            Console.WriteLine($"A hallgató neve {hallgato.Nev} akinek kora {hallgato.Kor} és neptunkódja {hallgato.NeptunKod}");

        }
    }
}
