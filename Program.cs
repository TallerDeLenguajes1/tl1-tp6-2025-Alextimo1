// CALCULADORAV2
 Console.WriteLine("=== Calculadora V2 ===");

        // --- PRIMERA PARTE: Operaciones con UN número ---
        Console.Write("Ingrese un número: ");
        bool valido1 = double.TryParse(Console.ReadLine(), out double numero);

        if (!valido1)
        {
            Console.WriteLine("Error: no ingresó un número válido.");
        }
        else
        {
            Console.WriteLine($"\nOperaciones con el número {numero}:");

            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");

            if (numero >= 0)
                Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
            else
                Console.WriteLine("Raíz cuadrada: No definida para números negativos");

            Console.WriteLine($"Seno: {Math.Sin(numero)}");
            Console.WriteLine($"Coseno: {Math.Cos(numero)}");

            Console.WriteLine($"Parte entera: {Math.Truncate(numero)}");
        }

        // --- SEGUNDA PARTE: Comparación entre DOS números ---
        Console.Write("\nIngrese el primer número: ");
        bool valido2 = double.TryParse(Console.ReadLine(), out double numero1);

        Console.Write("Ingrese el segundo número: ");
        bool valido3 = double.TryParse(Console.ReadLine(), out double numero2);

        if (!valido2 || !valido3)
        {
            Console.WriteLine("Error: uno o ambos números no son válidos.");
        }
        else
        {
            Console.WriteLine($"\nMáximo entre {numero1} y {numero2}: {Math.Max(numero1, numero2)}");
            Console.WriteLine($"Mínimo entre {numero1} y {numero2}: {Math.Min(numero1, numero2)}");
        }

        Console.WriteLine("\nFin del programa.");
        Console.ReadLine();
