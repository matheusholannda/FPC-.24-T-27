using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Usando um contador para contabilizar a quantidade de valores positivos e devolvendo o resultado para o usuário
int cont = 0;
double soma = 0.0;
if (a > 0.0)
{
    cont = cont + 1;
    soma = soma + a;
}
if (b > 0.0)
{
    cont = cont + 1;
    soma = soma + b;
}
if (c > 0.0)
{
    cont = cont + 1;
    soma = soma + c;
}
if (d > 0.0)
{
    cont = cont + 1;
    soma = soma + d;
}
if (e > 0.0)
{
    cont = cont + 1;
    soma = soma + e;
}
if (f > 0.0)
{
    cont = cont + 1;
    soma = soma + f;
}
Console.WriteLine(cont + " valores positivos");

double media = soma / cont;
Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
