using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Divisor
    {
        public void Divisores(int numero, int divisor)
        {
            while (divisor < numero)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine($"{divisor} é um divisor de {numero}");
                }
                divisor++;
            }
        }
    }
}
