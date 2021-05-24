using System;
using System.Collections.Generic;
using System.Linq;

namespace ATIVIDADE_6___Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDenomes = new List<string>();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + i + " nome:");
                string nome = Console.ReadLine();
                listaDenomes.Add(nome);
            }

            Console.WriteLine("Digite o nome que a ser buscado:");
            string NomeQueSeQuerAchar = Console.ReadLine();

            Console.WriteLine(listaDenomes.IndexOf(NomeQueSeQuerAchar));

            if (listaDenomes.IndexOf(NomeQueSeQuerAchar) !=-1 )
            {
                Console.WriteLine("Nome não encontrado");
            }
            else
            {
                Console.WriteLine("Nome encontrado");
            }


 
            
        }
    }
}
