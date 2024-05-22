using System.Globalization;

//Declarando as variáveis
int X;
double Y, kml;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
X = int.Parse(Console.ReadLine());
Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e atribuindo o resultado a variável kml
kml = X / Y;

//Devolvendo o resultado para o usuário
Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");