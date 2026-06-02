// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

// Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el 
// texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del 
// número sólo si éste es mayor a 0.
// Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo 
// "nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine 
// la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.

int numero = 0;

Console.Write("Ingrese un numero que quiera invertir (entero positivo): ");

string entrada = Console.ReadLine();

bool esNumero = int.TryParse(entrada, out numero);

if (esNumero)
{
    Console.WriteLine($"El número ingresado es: {numero}");

    if (numero > 0)
    {
        int numeroInvertido = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            numeroInvertido = (numeroInvertido * 10) + digito;
            numero /= 10;
        }

        Console.WriteLine("El numero invertido es: " + numeroInvertido);
    }
    else
    {
        Console.WriteLine("El número debe ser mayor que 0");
    }
}
else
{
    Console.WriteLine("La entrada no es un número entero válido");
}

// Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la 
// calculadora. Solicite al usuario un número y muestre por pantalla:
// ● El valor absoluto de un número
// ● El cuadrado
// ● La raíz cuadrada
// ● El seno
// ● El Coseno
// ● La parte entera de un tipo float.
// Luego de esto, solicite dos números al usuario y determine:
// ● El Máximo entre los dos números
// ● El Mínimo entre los dos números
// Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no ingrese un número válido.

Console.WriteLine("\n--- CALCULADORA V2 ---");
Console.Write("Ingrese un número: ");
// string entrada1 = Console.ReadLine();

bool esNum3 = double.TryParse(Console.ReadLine(), out double num3);

if (esNum3)
{
    Console.WriteLine($"Valor absoluto: {Math.Abs(num3)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(num3, 2)}");

    if (num3 >= 0)
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num3):F2}");
    else
        Console.WriteLine("Raíz cuadrada: Error, no se puede calcular con un número negativo");

    Console.WriteLine($"Seno: {Math.Sin(num3):F4}");
    Console.WriteLine($"Coseno: {Math.Cos(num3):F4}");
    Console.WriteLine($"Parte entera: {Math.Truncate(num3)}");
}
else
{
    Console.WriteLine("Error: No ingresó un número válido");
}

// Observaciones:
// Math es parte de la librería estándar para funciones matemáticas.
// El :F2 y :F4 limita la cantidad de decimales mostrados.

Console.WriteLine("\n--- COMPARACIÓN ENTRE DOS NÚMEROS ---");

Console.Write("Ingrese el primer número: ");
bool esNum4 = double.TryParse(Console.ReadLine(), out double num4);

Console.Write("Ingrese el segundo número: ");
bool esNum5 = double.TryParse(Console.ReadLine(), out double num5);

if (esNum4 && esNum5)
{
    double max = Math.Max(num4, num5);
    double min = Math.Min(num4, num5);

    Console.WriteLine($"Máximo: {max}");
    Console.WriteLine($"Mínimo: {min}");
}
else
{
    Console.WriteLine("Error: Uno o ambos valores ingresados no son válidos");
}