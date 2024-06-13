//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a matriz com o tamanho que foi recebido em N (matriz quadrada)
int[,] mat = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); //Recebendo o que o usuário digitar e guardando dentro da lista valores
    for (int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(valores[j]); //Inserindo os valores dentro da matriz
    }
}

int soma = 0;
for (int i = 0; i < N; i++)
{
    for (int j = i + 1; j < N; j++)
    { // j inicia com i+1
        soma = soma + mat[i, j]; //Fazendo a soma dos númeors que estão acima da diagonal principal
    }
}

Console.WriteLine("\n" + soma);
Console.ReadLine();