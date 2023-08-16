using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificadorDePalavraPalindrome {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para verificarmos se ela é um Palíndromo");
            string palavra = Console.ReadLine();

            char[] inversaoEtransformacao = palavra.ToCharArray();

            Array.Reverse(inversaoEtransformacao);

            string verificacao = new string(inversaoEtransformacao);

            if (verificacao == palavra)
            {
                Console.WriteLine("a palavra é um palíndromo");
            }
            else
            {
                Console.WriteLine("a palavra não é um palíndromo");
            }
        }
    }
}
