using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Exemplos
    {
        public void ConverterTemperatura(bool ceusiusToFahrenheit, double graus)
        {
            double temperatura = 0;

            temperatura = ceusiusToFahrenheit ? (graus * 1.8) + 32 : (graus - 32) / 1.8;
            Console.WriteLine(ceusiusToFahrenheit ? temperatura + "ºF" : temperatura + "ºC");
        }

    }
}
