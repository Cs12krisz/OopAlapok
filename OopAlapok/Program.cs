using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAlapok
{
    class Szemely
    {
        public string nev = "Név";
        public int kor = 35;

    }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely();
            Console.WriteLine(tanulo.nev);
            Console.WriteLine(tanulo.kor);
        }
    }
}
