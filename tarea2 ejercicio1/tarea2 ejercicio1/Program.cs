using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2_ejercicio1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la cantidad de camisas
            Console.Write("Ingrese la cantidad de camisas: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            // Solicitar el precio de las camisas
            Console.Write("Ingrese el precio de cada camisa: ");
            double precioCamisa = double.Parse(Console.ReadLine());

            // Calcular el costo total sin descuento
            double costoTotalSinDescuento = cantidadCamisas * precioCamisa;

            // Aplicar descuento según la cantidad de camisas
            double descuento = 0;

            if (cantidadCamisas == 1)
            {
                // No hay descuento
                descuento = 0;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                // Descuento del 15%
                descuento = 0.15;
            }
            else if (cantidadCamisas > 5)
            {
                // Descuento del 20%
                descuento = 0.20;
            }

            // Calcular el costo total con descuento
            double costoTotalConDescuento = costoTotalSinDescuento - (costoTotalSinDescuento * descuento);

            // Mostrar resultados
            Console.WriteLine($"\nCantidad de camisas: {cantidadCamisas}");
            Console.WriteLine($"Precio por camisa: ${precioCamisa}");
            Console.WriteLine($"Costo total sin descuento: ${costoTotalSinDescuento}");
            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
            Console.WriteLine($"Costo total con descuento: ${costoTotalConDescuento}");
            Console.ReadLine();
        }
    }
}