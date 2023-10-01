using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2_ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaración de variables
            int cantidadDeArticulos;
            double precioPorArticulo;
            double total;

            // Entrada de datos
            Console.Write("Ingrese la cantidad de artículos: ");
            if (!int.TryParse(Console.ReadLine(), out cantidadDeArticulos) || cantidadDeArticulos < 0)
            {
                Console.WriteLine("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Lógica para determinar el precio por artículo
            if (cantidadDeArticulos <= 10)
            {
                precioPorArticulo = 20.0;
            }
            else
            {
                precioPorArticulo = 15.0;
            }

            // Cálculo del total
            total = cantidadDeArticulos * precioPorArticulo;

            // Salida de resultados
            Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
            Console.WriteLine($"Total a pagar: ${total}");
            Console.ReadLine();
        }
    }
}
  
