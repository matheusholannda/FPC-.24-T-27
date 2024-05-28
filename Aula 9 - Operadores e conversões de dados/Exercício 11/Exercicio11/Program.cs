using System.Globalization;

//Declarando as variáveis
double raio, volume;

//Recebendo o que o usuário digitar e guardando dentro variável
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e devolvendo o resultado para o usuário
volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;
//volume = 4.0 / 3.0 * 3.14159 * Math.Pow(raio, 3);
Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));