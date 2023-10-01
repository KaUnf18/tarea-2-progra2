using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea__2_progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la cantidad de estudiantes
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            // Declarar arreglos para almacenar información de estudiantes
            string[] estudiantes = new string[cantidadEstudiantes];
            float[] promedio = new float[cantidadEstudiantes];

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"Estudiante #{i + 1}");

                // Solicitar el número de carnet
                Console.Write("Digite el número de carnet: ");
                string carnet = Console.ReadLine();

                // Solicitar el nombre completo
                Console.Write("Digite el nombre completo: ");
                string nombre = Console.ReadLine();

                // Solicitar las notas de quices
                Console.Write("Digite la nota del Quiz 1: ");
                float quiz1 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del Quiz 2: ");
                float quiz2 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del Quiz 3: ");
                float quiz3 = float.Parse(Console.ReadLine());

                // Solicitar las notas de tareas
                Console.Write("Digite la nota de la Tarea 1: ");
                float tarea1 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota de la Tarea 2: ");
                float tarea2 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota de la Tarea 3: ");
                float tarea3 = float.Parse(Console.ReadLine());

                // Solicitar las notas de exámenes
                Console.Write("Digite la nota del Examen 1: ");
                float examen1 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del Examen 2: ");
                float examen2 = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del Examen 3: ");
                float examen3 = float.Parse(Console.ReadLine());

                // Calcular promedio
                float[] notas = { quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3 };
                promedio[i] = CalcularPromedio(notas);

                // imprime informacion del estudiante
                Console.WriteLine("\nResumen del estudiante:");
                Console.WriteLine($"Carnet: {carnet}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Promedio: {promedio[i]}\n");
            }

            // imprime el promedio general del curso
            float promedioGeneral = CalcularPromedio(promedio);
            Console.WriteLine($"Promedio general del curso: {promedioGeneral}");
        }

        // Función para calcular el promedio de un conjunto de notas
        static float CalcularPromedio(float[] notas)
        {
            float suma = 0;

            foreach (float nota in notas)
            {
                suma += nota;
            }

            return suma / notas.Length;
        }
    }
}
