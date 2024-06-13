using System.Globalization;

//Declarando as variáveis
double A, B, media;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e atribuindo o resultado a variável media
media = ((A * 3.5) + (B * 7.5)) / 11;

//Devolvendo o resultado para o usuário
Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));