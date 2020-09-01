using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class funcoes
{
    public double Somar(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public double Subtrair(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public double Multiplicar(double valor1, double valor2)
    {
        return valor1 * valor2;
    }

    public double Dividir(double valor1, double valor2)
    {
        return valor1 / valor2;
    }

    public double Potencia(double valor1, double valor2)
    {
        return Math.Pow(valor1, valor2);
    }
    public double Raiz(double valor1)
    {
        return Math.Sqrt(valor1);
    }
    public void MostrarOpcoes()
    {
        Console.WriteLine("\tESCOLHA UMA OPÇÃO ABAIXO PARA EFETUAR A OPERAÇÃO CORRESPONDENTE\n\n");
        Console.WriteLine("\t[1]  ------------SOMAR------------------");
        Console.WriteLine("\t[2]  ------------SUBTRAIR---------------");
        Console.WriteLine("\t[3]  ------------MULTIPLICAR------------");
        Console.WriteLine("\t[4]  ------------DIVIDIR----------------");
        Console.WriteLine("\t[5]  ------------POTÊNCIA---------------");
        Console.WriteLine("\t[6]  ------------RAÍZ QUADRADA----------\n\n\n\n");
        Console.WriteLine("\tSE DESEJA SAIR DO PROGRAMA DIGITE 0 E APERTE A TECLA ENTER DUAS VEZES");
    }

}