using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Calculadora
    {
        public double Somar(double valor1, double valor2)
        {
            double soma = valor1 + valor2;
            Console.WriteLine(soma);
            return soma;
        }
        public double Subtrair(double valor1, double valor2)
        {
            double subitrair = valor1 - valor2;
            Console.WriteLine(subitrair);
            return subitrair;
        }
        public double Dividir(double valor1, double valor2)
        {
            double dividir = valor1 / valor2;
            Console.WriteLine(dividir);
            return dividir;
        }
        public double Multiplicar(double valor1, double valor2)
        {
            double multiplicar = valor1 * valor2;
            Console.WriteLine(multiplicar);
            return multiplicar;
        }
    }
}
