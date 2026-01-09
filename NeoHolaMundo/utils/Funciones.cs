using System;
using System.Collections.Generic;
using System.Text;

namespace NeoHolaMundo.utils
{
    internal class Funciones
    {

        public static string nombre()
        {
            string? nombre;

            do
            {
                Console.WriteLine("Cuál es tu nombre?");
                nombre = Console.ReadLine()?.Trim();
            } while (string.IsNullOrEmpty(nombre));

            return nombre;
        }

        public static int edad()
        {
            int edad;

            do
            {
                Console.WriteLine("Cuál es tu edad");
                while (!int.TryParse(Console.ReadLine(), out edad))
                {
                    Console.WriteLine("Ingresa un valor correcto");
                }

                if (edad < 1)
                    Console.WriteLine("Ingrese una edad mayor a 1");
            } while (edad < 1 );


            return edad;
        }

        public static bool mayorDeEdad(int edad)
        {
            if (edad >= 18)
                return true;
            else
                return false;
        }

        public static void acceso(string nombre, int edad, bool mayor)
        {
            if (mayor == true)
            {
                Console.WriteLine($"Bienvenido {nombre}");
            }
            else
                Console.WriteLine($"{nombre} no tiene acceso. Te faltan {18 - edad} años para entrar.");
        }

        public static bool continuar()
        {
            string? continuar;

            do
            {
                Console.WriteLine("Desea ingresara otra persona? (si/no)");
                continuar = Console.ReadLine()?.ToLower().Trim();
            } while (string.IsNullOrEmpty(continuar));

            if (continuar == "si")
                return true;
            else
                return false;
        }

    }
}
