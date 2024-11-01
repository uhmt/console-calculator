using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        double numero1 = PedirNumero("Introduce el primer número: ");
        double numero2 = PedirNumero("Introduce el segundo número: ");
        string  operacion = PedirOperacion("Introduce la operación (+, -, *, /): ");

        double resultado;

        switch (operacion)
        {
            case "+":
                resultado = numero1 + numero2;
                Console.WriteLine($"el resultado es: {resultado}");
                break;
            
            case "-":
                resultado = numero1 - numero2;
                Console.WriteLine($"el resultado es: {resultado}");
                break;

            case "*":
                resultado = numero1 * numero2;
                Console.WriteLine($"el resultado es: {resultado}");
                break;

            case "/":
                resultado = numero1 / numero2;
                Console.WriteLine($"el resultado es: {resultado}");
                break;
        }
    }

    static double PedirNumero(string mensaje)
    {
        double numero;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine();
            esValido = double.TryParse(entrada, out numero);

            if (!esValido)
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }

        } while (!esValido);

        return numero;
    }
    static string PedirOperacion(string mensaje)
{
    string entradaValida;
    do
    {
        Console.WriteLine(mensaje);
        entradaValida = Console.ReadLine() ?? "";
        
        if (entradaValida == "+" || entradaValida == "-" || entradaValida == "*" || entradaValida == "/")
        {
            return entradaValida;
        }
        
        Console.WriteLine("Por favor, introduce una operación válida.");
    } while (true); // Mantiene el bucle hasta que se introduzca una operacion valida
}

}
