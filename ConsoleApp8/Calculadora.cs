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
            Console.WriteLine($"{valor1} - {valor2} = {soma}");
            return soma;
        }
        public double Subtrair(double valor1, double valor2)
        {
            double subitrair = valor1 - valor2;
            Console.WriteLine($"{valor1} - {valor2} = {subitrair}");
            return subitrair;
        }
        public double Dividir(double valor1, double valor2)
        {
            double dividir = valor1 / valor2;
            Console.WriteLine($"{valor1} / {valor2} = {dividir}");
            return dividir;
        }
        public double Multiplicar(double valor1, double valor2)
        {
            double multiplicar = valor1 * valor2;
            Console.WriteLine($"{valor1} * {valor2} = {multiplicar}");
            return multiplicar;
        }
        public void Potencia(int numero, int potenciaN)
        {
            int resultado = numero;
            //double potencia = Math.Pow(numero1, potenciaN);
            for (int i = 2; i <= potenciaN; i++)
            {
                resultado *= numero;
                Console.WriteLine($"{numero}^{i} = {resultado}");
            }
        }
    }
}
