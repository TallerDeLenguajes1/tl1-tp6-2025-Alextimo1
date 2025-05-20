// See https://aka.ms/new-console-template for more information
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n --- Calculadora Basica ---");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("Seleccione una opcion: ");

    string opcion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero");
    bool esNumero1 = double.TryParse(Console.ReadLine(), out double num1);

    Console.WriteLine("Ingrese el segundo numero");
    bool esNumero2 = double.TryParse(Console.ReadLine(), out double num2);

    if (!esNumero1 || !esNumero2)
    {
        Console.WriteLine("Error: uno o ambos numeros no son validos");
    }
    else
    {
        switch (opcion)
        {
            case "1":
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
            case "2":
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
            case "3":
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
            case "4":
                if (num2 != 0)
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: no se puede dividir por cero");
                }
                break;
            default:
                Console.WriteLine("Opcion no valida. Ingrese (1-4)");
                break;
        }
    }
    Console.WriteLine("\nDesea realizar otra operacion? (s/n)");
    string respuesta = Console.ReadLine();
    if (respuesta != "s" && respuesta != "S")
    {
        continuar = false;
        Console.WriteLine("Saliendo de calculadora...");
    }
}

Console.ReadLine();
