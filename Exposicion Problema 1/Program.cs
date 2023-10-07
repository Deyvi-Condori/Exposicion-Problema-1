using System;

namespace RegistroAutomovil
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el año del modelo del automóvil: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el peso del automóvil (en lbs): ");
            int peso = int.Parse(Console.ReadLine());

            int clase;
            decimal tarifa;

            if (año <= 1970)
            {
                if (peso < 2700) { clase = 1; tarifa = 16.50m; }
                else if (peso <= 3800) { clase = 2; tarifa = 25.50m; }
                else { clase = 3; tarifa = 46.50m; }
            }
            else if (año <= 1979)
            {
                if (peso < 2700) { clase = 4; tarifa = 27.00m; }
                else if (peso <= 3800) { clase = 5; tarifa = 30.50m; }
                else { clase = 6; tarifa = 52.50m; }
            }
            else
            {
                if (peso < 3500) { clase = 7; tarifa = 19.50m; }
                else { clase = 8; tarifa = 52.50m; }
            }

            Console.WriteLine($"Clase de peso: {clase}\nTarifa de registro: ${tarifa}");
        }
    }
}