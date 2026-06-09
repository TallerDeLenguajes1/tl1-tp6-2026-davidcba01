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

// Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una 
// calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
// Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
// pida dos números y que devuelva el resultado de la operación seleccionada. Además 
// una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n=== CALCULADORA ===");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Seleccione una opción (1-4): ");

    bool esNum = int.TryParse(Console.ReadLine(), out int opcion); //Recibe la opción en string y la convierte a int

    if (!esNum || opcion < 1 || opcion > 4)
    {
        Console.WriteLine("\nOpción inválida");
    }
    else
    {
        Console.Write("\nIngrese el primer número: ");
        bool esNum1 = double.TryParse(Console.ReadLine(), out double num1);

        Console.Write("Ingrese el segundo número: ");
        bool esNum2 = double.TryParse(Console.ReadLine(), out double num2);

        if (!esNum1 || !esNum2)
        {
            Console.WriteLine("\nError: Debe ingresar números válidos");
        }
        else
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"\nResultado: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"\nResultado: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"\nResultado: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"\nResultado: {(num1 / num2):F2}"); //F2 para mostrar solo 2 decimales
                    else
                        Console.WriteLine("\nError: No se puede dividir por cero");
                    break;
            }
        }
    }

    Console.Write("\n¿Desea realizar otra operación? (s/n): ");
    string respuesta = Console.ReadLine();

    if (respuesta.ToLower() == "s")
    {
        continuar = true;
    }
    else
    {
        continuar = false;
    }
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

// Ejercicio 4.
// Realizar los siguientes ejercicios
// Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
// tarea:

// ● Obtener la longitud de la cadena y muestre por pantalla.

Console.WriteLine("\n--- TRABAJANDO CON EL TIPO STRING ---");

Console.Write("\nIngrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine($"La longitud de la cadena es: {cadena1.Length}");

// ● A partir de una segunda cadena ingresada por el usuario, concatene ambas
// cadenas distintas.

Console.Write("\nIngrese una segunda cadena de texto: ");
string cadena2 = Console.ReadLine();
string concatenada = string.Concat(cadena1, " ", cadena2);
Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// ● Extraer una subcadena de la cadena ingresada.

if (concatenada.Length >= 3)
{
    string subcadena = concatenada.Substring(0, 3); // primeros 3 caracteres
    Console.WriteLine($"\nSubcadena (primeros 3 caracteres): {subcadena}");
}
else
{
    Console.WriteLine("La cadena es muy corta para extraer una subcadena de 3 caracteres.");
}

// ● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
// números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
// la suma sería:
// “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
// Donde num1, num2 y resultados son los sumandos y el resultado de la operación
// respectivamente.
// Nota: Busque el comportamiento del Método ToString();

Console.WriteLine("\n=== CALCULADORA ===");

double a1, b1;
bool esNuma1, esNumb1;

do
{
    Console.Write("\nIngrese el primer número: ");
    esNuma1 = double.TryParse(Console.ReadLine(), out a1);

    Console.Write("Ingrese el segundo número: ");
    esNumb1 = double.TryParse(Console.ReadLine(), out b1);

    if (!esNuma1 || !esNumb1)
    {
        Console.WriteLine("Error: Debe ingresar números válidos");
    }

} while (!esNuma1 || !esNumb1);

double resultado = a1 + b1;

string textoResultado =
    $"La suma de {a1.ToString()} y de {b1.ToString()} es igual a: {resultado.ToString()}";

Console.WriteLine(textoResultado);

// ● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
// elemento en pantalla

Console.WriteLine("\nCaracteres individuales de la cadena concatenada:");
foreach (char c in concatenada)
{
    Console.WriteLine(c);
}

// ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada

Console.Write("\nIngrese una palabra a buscar en la cadena concatenada: ");
string palabra = Console.ReadLine();

if (concatenada.Contains(palabra))
    Console.WriteLine($"La palabra '{palabra}' aparece en la cadena.");
else
    Console.WriteLine($"La palabra '{palabra}' NO se encuentra.");


Console.Write("\n---Otra forma---");

Console.Write("\nIngrese una palabra a buscar en la cadena concatenada: ");
string palabra2 = Console.ReadLine();

int posicion = concatenada.IndexOf(palabra2);

if (posicion != -1)
{
    Console.WriteLine($"La palabra '{palabra2}' aparece en la cadena.");
    Console.WriteLine($"Se encontró a partir de la posición {posicion}.");
}
else
{
    Console.WriteLine($"La palabra '{palabra2}' NO se encuentra.");
}

// ● Convierta la cadena a mayúsculas y luego a minúsculas.

Console.WriteLine($"\nMayúsculas: {concatenada.ToUpper()}");
Console.WriteLine($"Minúsculas: {concatenada.ToLower()}");

// ● Ingrese una cadena separada por caracteres que usted determine y muestre por
// pantalla los resultados (Revisar el comportamiento de split())

Console.Write("\nIngrese una cadena separada por comas: ");
string separada = Console.ReadLine();

string[] partes = separada.Split(',');

Console.WriteLine("Partes separadas:");
foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim()); // elimina espacios
}

// ● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
// simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
// por pantalla “582+2” y que le devuelva la suma de 582 con 2

Console.Write("\nIngrese una ecuación simple (ej. 582+2): ");
string ecuacion = Console.ReadLine();

if (ecuacion.Contains("+"))
{
    var partes1 = ecuacion.Split('+');

    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 + n22}");
    else
        Console.WriteLine("Valores no válidos");
}
else if (ecuacion.Contains("-"))
{
    var partes1 = ecuacion.Split('-');

    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 - n22}");
    else
        Console.WriteLine("Valores no válidos");
}
else if (ecuacion.Contains("*"))
{
    var partes1 = ecuacion.Split('*');

    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 * n22}");
    else
        Console.WriteLine("Valores no válidos");
}
else if (ecuacion.Contains("/"))
{
    var partes1 = ecuacion.Split('/');
    
    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
    {
        if (n22 != 0)
            Console.WriteLine($"Resultado: {n11 / n22}");
        else
            Console.WriteLine("No se puede dividir por cero");
    }
    else
        Console.WriteLine("Valores no válidos");
}
else
{
    Console.WriteLine("Formato de ecuación no válido");
}