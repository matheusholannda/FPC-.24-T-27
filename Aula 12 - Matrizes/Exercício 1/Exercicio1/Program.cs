//Recebendo o que o usuário digitar e guardando dentro da lista valores
string[] valores = Console.ReadLine().Split(' ');

//Separando o que foi informado em suas respectivas variáveis
int M = int.Parse(valores[0]);
int N = int.Parse(valores[1]);

int[,] mat = new int[M, N]; //Instanciando a matriz com o tamanho que foi recebido em M e N

for (int i = 0; i < M; i++)
{
    valores = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(valores[j]); //Inserindo os valores dentro da matriz
    }
}

Console.WriteLine("\nVALORES NEGATIVOS:");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] < 0) //Pegando os valores negativos
        {
            Console.WriteLine(mat[i, j]);
        }
    }
}

Console.ReadLine();
