// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese un numero mayor que cero: ");

string entrada = Console.ReadLine();

bool esNumero = int.TryParse(entrada, out int numero);

if (esNumero && numero > 0)
{
    string numeroInvertidoTexto = "";

    for (int i = entrada.Length - 1; i >= 0; i--)
    {
        numeroInvertidoTexto += entrada[i];
    }
    Console.WriteLine("Numero invertido: " + numeroInvertidoTexto);
}
else
{
    Console.WriteLine("La entrada es un numero no valido");
}

Console.ReadLine();
