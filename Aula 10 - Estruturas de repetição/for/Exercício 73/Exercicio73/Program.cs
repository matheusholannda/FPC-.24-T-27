//Recebendo o que o usuário digitar e guardando dentro da variável
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++) //Começando o contador em 2 pois sempre vai ser o primeiro número par
{
    if (i % 2 == 0) //Calculando e exibindo o quadrado somente quando o número for par (se o resto da divisão for igual a 0)
    {
        int quadrado = i * i;
        Console.WriteLine(i + "^2 = " + quadrado);
    }
}
