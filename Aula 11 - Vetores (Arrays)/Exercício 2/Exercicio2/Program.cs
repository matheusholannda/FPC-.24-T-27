//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a lista com o tamanho que foi recebido em N
int[] vet = new int[N];

//Recebendo o que o usuário digitar e guardando dentro da lista valores
string[] valores = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(valores[i]); //passando o que foi inserido na lista valores para a lista vet
}

// 1: mostrando os numeros pares
for (int i = 0; i < N; i++)
{
    if (vet[i] % 2 == 0)
    {
        Console.Write(vet[i] + " ");
    }
}
Console.WriteLine();

// 2: mostrando a quantidade de pares
int quantidadeDePares = 0;
for (int i = 0; i < N; i++)
{
    if (vet[i] % 2 == 0)
    {
        quantidadeDePares++;
    }
}
Console.WriteLine(quantidadeDePares);

Console.ReadLine();