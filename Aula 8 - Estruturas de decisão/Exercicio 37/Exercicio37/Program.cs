using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Condição para descobrirmos em qual intervalo está o número
if (numero < 0.0 || numero > 100.0)
{
    Console.WriteLine("Fora de intervalo");
}
else if (numero <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (numero <= 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (numero <= 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75,100]");
}