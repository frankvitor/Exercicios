using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Tabuada
    {
        int count = 1;
        public void TabuadaDeN(int numero)
        {
            while (count <= 10)
            {
                Console.WriteLine($"{numero} x {count} = {numero * count}");
                count++;
            }
        }
    }
}
