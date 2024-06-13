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
    int maior = mat[i, 0]; //Assumimos que o maior seja o primeiro
    for (int j = 1; j < N; j++)
    {
        if (mat[i, j] > maior) //Se o número seguinte da linha for maior
        {
            maior = mat[i, j]; //Ele assume o valor da variável maior
        }
    }
    Console.WriteLine(maior);
}
Console.ReadLine();