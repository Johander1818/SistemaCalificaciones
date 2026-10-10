using System;

namespace SistemaCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector con 5 calificaciones
            int[] calificaciones = { 85, 67, 92, 74, 58 };
            int notaAprobacion = 70;

            // 1. Mostrar el vector con un ciclo for
            Console.WriteLine("=== Calificaciones ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1) + " (indice " + i + "): " + calificaciones[i]);
            }

            // 2. Acceso a un elemento por su indice
            Console.WriteLine("\nPrimera calificacion (indice 0): " + calificaciones[0]);
            Console.WriteLine("Tercera calificacion (indice 2): " + calificaciones[2]);

            // 3. Promedio, mayor y menor, aprobados y reprobados
            int suma = 0;
            int mayor = calificaciones[0];
            int menor = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;

            foreach (int nota in calificaciones)
            {
                suma += nota;

                if (nota > mayor)
                {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }

                if (nota >= notaAprobacion)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double promedio = (double)suma / calificaciones.Length;

            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine("Promedio: " + promedio.ToString("F2"));
            Console.WriteLine("Nota mas alta: " + mayor);
            Console.WriteLine("Nota mas baja: " + menor);
            Console.WriteLine("Aprobados (>= " + notaAprobacion + "): " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);

            // 4. Modificar una calificacion
            Console.Write("\nNumero de estudiante a modificar (1-5): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= calificaciones.Length)
            {
                Console.Write("Nueva calificacion: ");
                int nueva = int.Parse(Console.ReadLine());
                calificaciones[numero - 1] = nueva;
                Console.WriteLine("Calificacion modificada.");
            }
            else
            {
                Console.WriteLine("Ese estudiante no existe.");
            }

            // 5. Mostrar el vector actualizado
            Console.WriteLine("\n=== Calificaciones actualizadas ===");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1) + ": " + calificaciones[i]);
            }

            Console.WriteLine("\nPresione Enter para salir...");
            Console.ReadLine();
        }
    }
}
