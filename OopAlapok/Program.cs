using System;
using System.Collections.Generic;
using System.Linq;
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
                if (egyenleg > 0)
                {
                    egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Az egyenleg nem lehet negatív!");
                }
            }
        }


        static void Bevesz(int ertek)
        {
        }

        static void Kivesz()
        {

        }

        public BankSzamla() { }


    }
    class Szemely
    {
        public string nev = "Név";
        private int kor = -3;
        public int Kor
        {
            get { return this.kor; }
            set {

                if (this.kor > 0) {
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
        }
    }
}
