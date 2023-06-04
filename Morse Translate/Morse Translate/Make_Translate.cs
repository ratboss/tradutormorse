using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Morse_Translate
{
    internal class Make_Translate
    {
        public String[] palavra = new String[50];
        

        public void traduzir()
        {
            Console.WriteLine("Digite de letra em letra em morse(Até 50 caracteres)");


            for (int i = 0; i < palavra.Length; i++)
            {
                palavra[i] = Console.ReadLine();
                switch (palavra[i])
                {
                    case ".-":
                        Console.WriteLine("A ");
                        break;
                    case "-...":
                        Console.WriteLine("B ");
                        break;
                    case "-.-.":
                        Console.WriteLine("C ");
                        break;
                    case "-..":
                        Console.WriteLine("D ");
                        break;
                    case ".":
                        Console.WriteLine("E ");
                        break;
                    case "..-.":
                        Console.WriteLine("F ");
                        break;
                    case "--.":
                        Console.WriteLine("G ");
                        break;
                    case "....":
                        Console.WriteLine("H ");
                        break;
                    case "..":
                        Console.WriteLine("I ");
                        break;
                    case ".---":
                        Console.WriteLine("J ");
                        break;
                    case "-.-":
                        Console.WriteLine("K ");
                        break;
                    case ".-..":
                        Console.WriteLine("L ");
                        break;
                    case "--":
                        Console.WriteLine("M ");
                        break;
                    case "-.":
                        Console.WriteLine("N ");
                        break;
                    case "---":
                        Console.WriteLine("O ");
                        break;
                    case ".--.":
                        Console.WriteLine("P ");
                        break;
                    case "--.-":
                        Console.WriteLine("Q ");
                        break;
                    case ".-.":
                        Console.WriteLine("R ");
                        break;
                    case "...":
                        Console.WriteLine("S ");
                        break;
                    case "-":
                        Console.WriteLine("T ");
                        break;
                    case "..-":
                        Console.WriteLine("U ");
                        break;
                    case "...-":
                        Console.WriteLine("V ");
                        break;
                    case ".--":
                        Console.WriteLine("W ");
                        break;
                    case "-..-":
                        Console.WriteLine("X ");
                        break;
                    case "-.--":
                        Console.WriteLine("Y ");
                        break;
                    case "--..":
                        Console.WriteLine("Z ");
                        break;
                    default:
                        Console.WriteLine("Simbolo indefinido");
                        break;
                }
            }
        }
        public void criar()
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                palavra[i] = Console.ReadLine();
                switch (palavra[i].ToLower())
                {
                    case "a":
                        Console.WriteLine(".- / ");
                        break;
                    case "b":
                        Console.WriteLine("-... / ");
                        break;
                    case "c":
                        Console.WriteLine("-.-. / ");
                        break;
                    case "d":
                        Console.WriteLine("-.. / ");
                        break;
                    case "e":
                        Console.WriteLine(". / ");
                        break;
                    case "f":
                        Console.WriteLine("..-. / ");
                        break;
                    case "g":
                        Console.WriteLine("--. / ");
                        break;
                    case "h":
                        Console.WriteLine(".... / ");
                        break;
                    case "i":
                        Console.WriteLine(".. / ");
                        break;
                    case "j":
                        Console.WriteLine(".--- / ");
                        break;
                    case "k":
                        Console.WriteLine("-.- / ");
                        break;
                    case "l":
                        Console.WriteLine(".-.. / ");
                        break;
                    case "m":
                        Console.WriteLine("-- / ");
                        break;
                    case "n":
                        Console.WriteLine("-. / ");
                        break;
                    case "o":
                        Console.WriteLine("--- / ");
                        break;
                    case "p":
                        Console.WriteLine(".--. / ");
                        break;
                    case "q":
                        Console.WriteLine("--.- / ");
                        break;
                    case "r":
                        Console.WriteLine(".-. / ");
                        break;
                    case "s":
                        Console.WriteLine("... / ");
                        break;
                    case "t":
                        Console.WriteLine("- / ");
                        break;
                    case "u":
                        Console.WriteLine("..- / ");
                        break;
                    case "v":
                        Console.WriteLine("...- / ");
                        break;
                    case "w":
                        Console.WriteLine(".-- / ");
                        break;
                    case "x":
                        Console.WriteLine("-..- / ");
                        break;
                    case "y":
                        Console.WriteLine("-.-- / ");
                        break;
                    case "z":
                        Console.WriteLine("--.. / ");
                        break;
                    default:
                        Console.WriteLine("Letra não existente");
                        break;
                }
            }
        }
 
    }
}
