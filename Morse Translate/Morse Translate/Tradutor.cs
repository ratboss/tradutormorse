using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Translate
{
    internal class Tradutor
    {
        static void Main(string[] args)
        {
            Make_Translate method = new Make_Translate();
            int op;
            Console.WriteLine("What you wanna do?");
            Console.WriteLine("1 - Translate Morse Code");
            Console.WriteLine("2 - Make a sentence in morse code");
            op = Convert.ToInt16(Console.ReadLine());

            switch (op) {
                case 1:
                    method.traduzir();
                    break;
                case 2:
                    method.criar();
                    break;
            }

            Console.ReadKey();
        }
    }
}
