using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopAlapok
{

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
        public string nev = "Név";
        private int kor = 53;
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

        public override string ToString()
        {
            return $"Név: {this.nev}; Életkor: {Kor};";
        }

        public Szemely() { }

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            Kor = kor;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely();
            Console.WriteLine(tanulo.nev);
            Console.WriteLine(tanulo.Kor);
            Szemely szemely1 = new Szemely("Személy", -1);
            Console.WriteLine(szemely1);
            BankSzamla bankSzamla1 = new BankSzamla(300);
            bankSzamla1.Bevesz(100);
            Console.WriteLine(bankSzamla1.Egyenleg);
            bankSzamla1.Kivesz(500);
            Console.WriteLine(bankSzamla1.Egyenleg);


        }
    }
}
