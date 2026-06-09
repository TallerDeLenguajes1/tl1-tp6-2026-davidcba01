## ¿String es un tipo por valor o un tipo por referencia?

string es un tipo por referencia en C#. Sin embargo, posee un comportamiento especial llamado inmutabilidad, 
lo que significa que una vez creada una cadena de texto, su contenido no puede modificarse. Cuando parece que se 
modifica una cadena, en realidad se crea una nueva.


## ¿Qué secuencias de escape tiene el tipo string?

Algunas de las secuencias de escape más utilizadas son:
- \n : salto de línea.
- \t : tabulación horizontal.
- \\ : representa el carácter barra invertida (\).
- \" : representa comillas dobles dentro de una cadena.
- \' : representa una comilla simple.
- \r : retorno de carro.
- \0 : carácter nulo.

### Ejemplo:
Console.WriteLine("Hola\nMundo");


## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

### @ (cadena literal)
Permite escribir cadenas de texto sin necesidad de escapar caracteres especiales como la barra invertida (\).

### Ejemplo:
string ruta = @"C:\Users\David\Documentos";

### $ (interpolación de cadenas)
Permite insertar variables o expresiones dentro de una cadena utilizando llaves {}.

### Ejemplo:
string nombre = "David";
Console.WriteLine($"Hola {nombre}");

### Salida:
Hola David

### También pueden combinarse ambos símbolos:
string archivo = "datos.txt";
string ruta = $@"C:\Archivos\{archivo}";¿String es un tipo por valor o un tipo por referencia?
