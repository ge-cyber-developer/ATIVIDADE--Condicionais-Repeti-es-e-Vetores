using System;
using System.Collections.Generic;
using System.Linq;

namespace ATIVIDADE_7___Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> listaDeNumeros = new List<int>();
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine("Digite o valor: ");
                int valorDigitado = int.Parse(Console.ReadLine());
                listaDeNumeros.Add(valorDigitado);
            }

             listaDeNumeros.Reverse();


            foreach(int numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
