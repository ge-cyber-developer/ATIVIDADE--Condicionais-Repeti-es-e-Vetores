using System;

namespace ATIVIDADE_1___Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento:");
            int AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual:");
            int AnoAtual = int.Parse(Console.ReadLine());

            int Idade = AnoAtual - AnoNascimento;

            if (Idade >= 18)
            {
                Console.WriteLine("Parabéns! você pode votar");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode votar.");
            }

            


        }
    }
}
