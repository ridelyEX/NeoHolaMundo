internal class Program
{
    private static void Main(string[] args)
    {
        string opc;
        int personas = 0;

        do
        {
            string? nombre;
            int edad;

            // Lectura de nombre
            do
            {
                Console.WriteLine("Ingrese un nombre");
                nombre = Console.ReadLine();
            } while (string.IsNullOrEmpty(nombre));

            // Lectura de edad
            Console.WriteLine("Ingresa edad");
            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Ingresa un número válido");
            }

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad, puedes pasar");
                Console.WriteLine("Hola, " + nombre);
                personas++;
            }
            else
                Console.WriteLine("Eres menor de edad, acceso restringido");
            
            Console.WriteLine($"personas autorizadas ingresadas: {personas}");


            // Lectura de opción
            do
            {
                Console.WriteLine("Desea ingresar a otra persona? si para continuar, no o salir para cerrar la ejecución");
                opc = Console.ReadLine().ToLower().Trim();
            } while (string.IsNullOrEmpty(opc));
            

        } while ( opc == "si" );

        Console.Write("Ejecución terminada. Hasta pronto");
    }
}