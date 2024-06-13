//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Digite o dia: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mês: ");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano: ");
int ano = int.Parse(Console.ReadLine());


if ((dia > 0 && dia < 32) && (mes > 0 && mes < 13) && (ano > 0 && ano < 2014))
{
    Console.WriteLine($"Essa data é válida!");
}
else
{
    Console.WriteLine($"Essa data é inválida!");
}
