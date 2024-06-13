//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

//Usando um contador para contabilizar a quantidade de valores pares e devolvendo o resultado para o usuário
int cont = 0;
if (a % 2 == 0)
{
    cont = cont + 1;
}
if (b % 2 == 0)
{
    cont = cont + 1;
}
if (c % 2 == 0)
{
    cont = cont + 1;
}
if (d % 2 == 0)
{
    cont = cont + 1;
}
if (e % 2 == 0)
{
    cont = cont + 1;
}
Console.WriteLine(cont + " valores pares");