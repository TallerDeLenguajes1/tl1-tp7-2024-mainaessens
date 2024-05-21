using System;
using EspacioCalculadora; 

namespace CalculadoraApp 
{
    class Program // Declara una clase llamada Program
    {
        static void Main(string[] args) // Método principal que es el punto de entrada de la aplicación
        {
            Calculadora calc = new Calculadora(); // Crea una nueva instancia de la clase Calculadora
            bool continuar = true; // Declara una variable booleana para controlar el ciclo while
            
            while (continuar)
            {
                Console.WriteLine("Ingrese una operación (sumar, restar, multiplicar, dividir, limpiar) o 'salir' para terminar:"); // Muestra un mensaje solicitando la operación
                string input = Console.ReadLine().ToLower(); // Lee la entrada del usuario y la convierte a minúsculas

                switch (input)
                {
                    case "sumar": 
                        Console.Write("Ingrese el número a sumar: "); 
                        double sumar = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada del usuario a double y la almacena en la variable sumar
                        calc.Sumar(sumar); // Llama al método Sumar de la clase Calculadora
                        break; 

                    case "restar": 
                        Console.Write("Ingrese el número a restar: "); 
                        double restar = Convert.ToDouble(Console.ReadLine()); 
                        calc.Restar(restar);
                        break; 

                    case "multiplicar": 
                        Console.Write("Ingrese el número a multiplicar: "); 
                        double multiplicar = Convert.ToDouble(Console.ReadLine());
                        calc.Multiplicar(multiplicar);
                        break; 

                    case "dividir":
                        Console.Write("Ingrese el número a dividir: "); 
                        double dividir = Convert.ToDouble(Console.ReadLine());
                        calc.Dividir(dividir);
                        break; 

                    case "limpiar": 
                        calc.Limpiar();
                        break; 

                    case "salir":
                        continuar = false;
                        break; 

                    default:
                        Console.WriteLine("Comando no reconocido.");
                        break; 
                }

                if (continuar)
                {
                    Console.WriteLine($"Resultado actual: {calc.Resultado}");
                }
            }

            Console.WriteLine("Programa terminado.");
        }
    }
}
