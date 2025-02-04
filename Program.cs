using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            RodarPrograma();
        }


        static void RodarPrograma()
        {
            Console.Clear();
            int Numero1, Numero2;
            
            Console.WriteLine("Digite o primeiro número:");
            Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            Numero2 = int.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Qual operação você deseja executar?");
            Console.WriteLine("");
            Console.WriteLine("Adição -> 1");
            Console.WriteLine("Menos -> 2");
            Console.WriteLine("Vezes -> 3");
            Console.WriteLine("Dividir -> 4");
            int resposta = int.Parse(Console.ReadLine());

            switch(resposta) 
                {
                case 1:
                    Somar(Numero1, Numero2);
                    break;
                case 2:
                    Subtracao(Numero1, Numero2);
                    break;
                case 3:
                    Multiplicacao(Numero1, Numero2);
                    break;
                case 4:
                    Divisao(Numero1, Numero2);
                    break;                                        
                default:
                    Console.WriteLine("Numero invalido");
                    Console.ReadKey();
                    RodarPrograma();
                    break;
                }

            
        }


        static void Somar(int n1, int n2){
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado é: {n1 + n2}");
        }


        static void Subtracao(int n1, int n2){
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado é: {n1 - n2}");
        }

        static void Multiplicacao(int n1, int n2){
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado é: {n1 * n2}");
        }

        static void Divisao(int n1, int n2){
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado é: {n1 / n2}");
        }


    }
}