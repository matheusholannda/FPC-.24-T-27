using System.Globalization;

//Declaração de variáveis
double a, b, c, perimetro, area;

//Recebendo o que o usuário digitar e guardando dentro do array vet
String[] vet = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array vet dentro das respectivas variáveis
a = double.Parse(vet[0], CultureInfo.InvariantCulture);
b = double.Parse(vet[1], CultureInfo.InvariantCulture);
c = double.Parse(vet[2], CultureInfo.InvariantCulture);

//Fazendo os cálculos e devolvendo o resultado para o usuário
if (a < b + c && b < a + c && c < a + b)
{
    perimetro = a + b + c;
    Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
}
else
{
    area = ((a + b) * c) / 2;
    Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
}
