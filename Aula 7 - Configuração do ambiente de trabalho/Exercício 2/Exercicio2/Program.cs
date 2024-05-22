//Classe que é importada para utilizarmos o método CultureInfo
using System.Globalization;

//Declarando as variáveis e já deixando um valor pré definido para pi
double R, A, pi = 3.14159;

//Recebendo o valor do raio e atribuindo o valor a variável R
R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta
A = pi * R * R;

//Devolvendo o resultado para o usuário
Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

//Outra maneira de devolver a informação para o usuário através da chamada "Interpolação de Strings", quando adicionamos o conteúdo do código dentro das aspas da string e apenas colocamos um $ antes da string
//Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");