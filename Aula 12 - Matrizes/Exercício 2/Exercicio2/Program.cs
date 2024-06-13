//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a matriz com o tamanho que foi recebido em N (matriz quadrada)
int[,] mat = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); //Recebendo o que o usuário digitar e guardando dentro da lista valores
    for (int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(valores[j]);//Inserindo os valores dentro da matriz
    }
}

Console.WriteLine();
for (int i = 0; i < N; i++)
{
    int soma = 0;
    for (int j = 0; j < N; j++)
    {
        soma = soma + mat[i, j]; //Somando os valores por linha
    }
    Console.WriteLine(soma);
}
Console.ReadLine();
