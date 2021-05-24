using System;

namespace ATIVIDADE_2___Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o a quantidade de litros comprada: ");
            int QuantidadeLitros = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o tipo de combustível: A - Álcool | G - Gasolina");
            string tipoDeCombustivel = Console.ReadLine();

            float precoDoLitro;
            float precoFinal;

            if (tipoDeCombustivel == "A")
            {
                precoDoLitro = 4.9f;
            }
            else 
            {
                precoDoLitro = 5.3f;
            }

            precoFinal = precoDoLitro*QuantidadeLitros;

            //Descontos
            if (tipoDeCombustivel == "A"){
                if(QuantidadeLitros < 20){
                    precoFinal = precoFinal * 0.97f;
                }else {
                    precoFinal = precoFinal * 0.95f;
                }
            }else {
                if (QuantidadeLitros < 20){
                    precoFinal = precoFinal * 0.96f;
                }
            }



            
        }
    }
}
