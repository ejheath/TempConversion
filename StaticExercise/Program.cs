using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(44);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(44);

            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }
    }
}
