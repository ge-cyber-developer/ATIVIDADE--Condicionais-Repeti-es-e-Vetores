using System;

namespace ATIVIDADE_3___Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome do produto:");
            string nome =  Console.ReadLine();

            Console.WriteLine("Escreva a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o preço unitário do produto:");
            double valorunitario = double.Parse(Console.ReadLine());

            double desconto;
            double  valorfinal = quantidade * valorunitario;

            if (quantidade <= 5)
            {
                desconto = 0.2;
              
            }
            else if ( quantidade > 5 && quantidade <= 10)
            {
                desconto = 0.3;
            }
            else 
            {
                desconto = 0.5;

            }

              double valorfinalpagar = valorfinal - valorfinal*desconto;
              Console.WriteLine("O produto "+nome+ " de valor unitario R$"+ valorunitario+", sendo compradas "+ quantidade+" unidades fica no valor de "+valorfinalpagar);


        }
    }
}
