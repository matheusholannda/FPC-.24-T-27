using System.Globalization;

//Declarando as variáveis
double A, B, C, media;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e atribuindo o resultado a variável media
media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

//Devolvendo o resultado para o usuário
Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));