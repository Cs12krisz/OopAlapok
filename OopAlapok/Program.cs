using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopAlapok
{
  
    public class Hallgato : Szemely
    {
        private string neptunKod;

        public string NeptunKod
        {
            get { return neptunKod; }
            set {
                if (value.Length <= 6)
                {
                    neptunKod = value;
                }
            }
        }


        public Hallgato(string nev, int kor, string neptunkod) : base(nev, kor)
        {
            Nev = nev;
            Kor = kor;
            NeptunKod = neptunkod;
        }


        public override string ToString()
        {
            return $"A hallgató neve {Nev} akinek kora {Kor} és neptunkódja {NeptunKod}";
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
                if (value < 0) Console.WriteLine("Az egyenleg nem lehet negatív!");
                else egyenleg = value;
            }
        }


        public BankSzamla(int egyenleg)
        {
            Egyenleg = egyenleg;
        }

        public void Betesz(int ertek)
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

   public class Szemely
   {
        protected string nev;
        private int kor;
        public int Kor
        {
            get { return this.kor; }
            set
            {

                if (value > 0)
                {
                    this.kor = value;
                }

            }
        }
        
        public string Nev 
        {
            get { return nev; }
            set { nev = value; }
        }


        public override string ToString()
        {
            return $"Név: {Nev}; Életkor: {Kor};";
        }


        public Szemely(string nev, int kor)
        {
           Nev = nev;
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
            bankSzamla1.Betesz(100);
            Console.WriteLine(bankSzamla1.Egyenleg);
            bankSzamla1.Kivesz(500);
            Console.WriteLine(bankSzamla1.Egyenleg);

            List<Hallgato> hallgatok = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Kérem a nevet: ");
                string nev = Console.ReadLine();
                Console.Write("Kérem az életkort: ");
                int kor = int.Parse(Console.ReadLine());
                Console.Write("Kérem a neptunkódot: ");
                string neptkod = Console.ReadLine();
                Hallgato h1 = new Hallgato(nev, kor, neptkod);
                hallgatok.Add(h1);
            }

            foreach (var item in hallgatok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
