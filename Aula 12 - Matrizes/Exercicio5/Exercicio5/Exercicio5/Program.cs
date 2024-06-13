//Recebendo o que o usuário digitar e guardando dentro da lista valores
string[] valores = Console.ReadLine().Split(' ');

//Separando o que foi informado em suas respectivas listas
int M = int.Parse(valores[0]);
int N = int.Parse(valores[1]);

//Instanciando as matrizes com os tamanhos que foram recebidos em M e N
int[,] A = new int[M, N];
int[,] B = new int[M, N];
int[,] C = new int[M, N];

// leitura da matriz A
for (int i = 0; i < M; i++)
{
    valores = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(valores[j]);
    }
}

// leitura da matriz B
for (int i = 0; i < M; i++)
{
    valores = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        B[i, j] = int.Parse(valores[j]);
    }
}

// geracao da matriz C
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        C[i, j] = A[i, j] + B[i, j];
    }
}
Console.WriteLine();

// impressao da matriz C na tela
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadLine();