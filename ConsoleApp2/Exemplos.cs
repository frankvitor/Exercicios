using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Exemplos
    {
        public void Potencia(bool quadrado, double numero, double elevado)
        {
            double potencia = quadrado ? Math.Pow(numero, elevado) : Math.Pow(numero, elevado);
            Console.WriteLine($"{numero} ^ {elevado} = " + potencia);
        }
    }
}
