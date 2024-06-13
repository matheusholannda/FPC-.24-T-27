//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando as listas com o tamanho que foi recebido em N
int[] A = new int[N];
int[] B = new int[N];

string[] valores = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(valores[i]); //Pegando N números e guardando dentro da lista A
}

valores = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    B[i] = int.Parse(valores[i]); //Pegando N números e guardando dentro da lista A
}

// 1: gerando o vetor C
int[] C = new int[N];
for (int i = 0; i < N; i++)
{
    C[i] = A[i] + B[i];
}
Console.WriteLine();

// 2: mostrando o vetor C na tela
for (int i = 0; i < N; i++)
{
    Console.Write(C[i] + " ");
}

Console.ReadLine();