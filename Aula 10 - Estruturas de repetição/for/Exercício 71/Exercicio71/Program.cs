//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

//Organizando o maior e o menor número 
int min, max;
if (x < y)
{
    min = x;
    max = y;
}
else
{
    min = y;
    max = x;
}

//
int soma = 0;
for (int i = min + 1; i < max; i++)
{
    if (i % 2 != 0) //Só acrescentamos o número a soma se o resto da divisão do mesmo por 2 for diferente de 0 (ou seja for ímpar)
    {
        soma = soma + i;
    }
}

Console.WriteLine(soma);