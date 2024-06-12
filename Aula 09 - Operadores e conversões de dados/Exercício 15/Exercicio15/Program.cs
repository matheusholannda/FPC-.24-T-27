using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e devolvendo o resultado para o usuário
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
Console.ReadLine();