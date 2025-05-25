// EJERCICIO 4-STRING
Console.Write("Ingrese una cadena de texto: ");
        string texto1 = Console.ReadLine();

        // Longitud
        Console.WriteLine($"Longitud: {texto1.Length}");

        // Concatenación
        Console.Write("Ingrese otra cadena para concatenar: ");
        string texto2 = Console.ReadLine();
        string textoConcatenado = texto1 + " " + texto2;
        Console.WriteLine("Concatenación: " + textoConcatenado);

        // Subcadena
        Console.Write("Ingrese desde qué posición extraer una subcadena: ");
        int desde = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la longitud de la subcadena: ");
        int largo = int.Parse(Console.ReadLine());
        string subcadena = texto1.Substring(desde, largo);
        Console.WriteLine("Subcadena: " + subcadena);

        // Operación matemática como texto
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");

        // Recorrer cadena con foreach
        Console.WriteLine("Caracteres del primer texto:");
        foreach (char c in texto1)
        {
            Console.WriteLine(c);
        }

        // Buscar palabra
        Console.Write("Ingrese palabra a buscar en el texto original: ");
        string palabra = Console.ReadLine();
        bool contiene = texto1.Contains(palabra);
        Console.WriteLine(contiene ? "Palabra encontrada." : "Palabra no encontrada.");

        // Mayúsculas / minúsculas
        Console.WriteLine("Mayúsculas: " + texto1.ToUpper());
        Console.WriteLine("Minúsculas: " + texto1.ToLower());

        // Split
        Console.Write("Ingrese una cadena separada por comas: ");
        string cadenaSeparada = Console.ReadLine();
        string[] partes = cadenaSeparada.Split(',');
        Console.WriteLine("Elementos separados:");
        foreach (var parte in partes)
        {
            Console.WriteLine(parte.Trim());
        }

        // Resolver ecuación tipo "582+2"
        Console.Write("Ingrese una ecuación simple (ej: 582+2): ");
        string ecuacion = Console.ReadLine();
        char[] operadores = { '+', '-', '*', '/' };

        foreach (char op in operadores)
        {
            if (ecuacion.Contains(op))
            {
                string[] partesEcuacion = ecuacion.Split(op);
                double op1 = double.Parse(partesEcuacion[0]);
                double op2 = double.Parse(partesEcuacion[1]);

                double resultado = op switch
                {
                    '+' => op1 + op2,
                    '-' => op1 - op2,
                    '*' => op1 * op2,
                    '/' => op2 != 0 ? op1 / op2 : double.NaN,
                    _ => 0
                };

                Console.WriteLine($"Resultado: {ecuacion} = {resultado}");
                break;
            }
        }

        Console.WriteLine("Fin del programa.");
        Console.ReadLine();
