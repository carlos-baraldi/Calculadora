using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;
            double ImprimirSomar, ImprimirSubtrair, ImprimirMultiplicar, ImprimirDividir, ImprimirPotencia,ImprimirRaiz;
            int escolha;
            do
            {
                funcoes funcoes = new funcoes();


                funcoes.MostrarOpcoes();

                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                {
                    switch (escolha)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine("Digite o primeiro número: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            valor2 = Convert.ToInt32(Console.ReadLine());

                            ImprimirSomar = funcoes.Somar(valor1, valor2);
                            Console.WriteLine($"O resultado de {valor1} + {valor2} é igual a {ImprimirSomar}");                            
                            break;
                            
                        case 2:
                            Console.WriteLine("Digite o primeiro número: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            valor2 = Convert.ToInt32(Console.ReadLine());
                            ImprimirSubtrair = funcoes.Subtrair(valor1, valor2);
                            Console.WriteLine($"O resultado de  {valor1} - {valor2} é igual a {ImprimirSubtrair}");                            
                            break;
                        case 3:
                            Console.WriteLine("Digite o primeiro número: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            valor2 = Convert.ToInt32(Console.ReadLine());
                            ImprimirMultiplicar = funcoes.Multiplicar(valor1, valor2);
                            Console.WriteLine($"O resultado de  {valor1} * {valor2} é igual a {ImprimirMultiplicar}");                            
                            break;
                        case 4:
                            Console.WriteLine("Digite o primeiro número: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            valor2 = Convert.ToInt32(Console.ReadLine());
                            ImprimirDividir = funcoes.Dividir(valor1, valor2);
                            Console.WriteLine($"O resultado de  {valor1} / {valor2} é igual a {ImprimirDividir}");                            
                            break;
                        case 5:
                            Console.WriteLine("Digite o número a ser elevado: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o número pelo qual o primeiro número será elevado: ");
                            valor2 = Convert.ToInt32(Console.ReadLine());
                            ImprimirPotencia = funcoes.Potencia(valor1, valor2);
                            Console.WriteLine($"O resultado de  {valor1} elevado a {valor2} é igual a {ImprimirPotencia}");                            
                            break;
                        case 6:
                            Console.WriteLine("Digite um número: ");
                            valor1 = Convert.ToInt32(Console.ReadLine());
                            ImprimirRaiz = funcoes.Raiz(valor1);
                            Console.WriteLine($"A raíz de {valor1} é igual a {ImprimirRaiz}");                           
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Digite uma opção válida");
                            
                            break;
                    }
                }
                
            } while (escolha != 0);




            Console.ReadLine();
        }
    }
}
