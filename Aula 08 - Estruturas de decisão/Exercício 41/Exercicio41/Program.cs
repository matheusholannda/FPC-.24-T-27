using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

//Fazendo a classificação e devolvendo o resultado para o usuário
if (x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}
else if (x == 0.0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0.0)
{
    Console.WriteLine("Eixo X");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}
