using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1agustinmaglione
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, pesos2, pesos, dolarOficial, DolarParalelo, euro;
            Console.WriteLine("Ingrese la catidad de dolares que quieres cambiar a pesos:");
            dolar = double.Parse(Console.ReadLine());
            pesos = dolar * 230;
            pesos2 = dolar * 280;
            euro = dolar / 1.17;
            dolarOficial = 230;
            DolarParalelo = 280;
            Console.WriteLine(" Dolar oficial $230");
            Console.WriteLine("Dolar paralelo $280");
            Console.WriteLine($" Con ese conto puedes comprar   { Math.Truncate(pesos) } Pesos con el dolar oficial ");
            Console.WriteLine($" Con ese monto puedes comprar  {Math.Truncate(pesos2) } Pesos con el dolar Paralelo");
            Console.WriteLine($" Y podrias comprar {Math.Truncate(euro)} Euros ");
            Console.ReadLine();
        }
    }
}
