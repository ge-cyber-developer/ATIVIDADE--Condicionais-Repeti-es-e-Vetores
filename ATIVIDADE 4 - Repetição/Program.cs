using System;
using System.Collections.Generic;
using System.Linq;

namespace ATIVIDADE_5___Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeNumeros = new List<int>();
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Digite o "+i+" valor: ");
                int valorDigitado = int.Parse(Console.ReadLine());
                listaDeNumeros.Add(valorDigitado);
            }

            Console.WriteLine("O maior valor é: "+listaDeNumeros.Max()+" e o menor numero é "+listaDeNumeros.Min());
        }
    }
}