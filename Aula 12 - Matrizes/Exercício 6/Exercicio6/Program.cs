﻿using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a matriz com o tamanho que foi recebido em N (matriz quadrada)
double[,] mat = new double[N, N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); //Recebendo o que o usuário digitar e guardando dentro da lista valores
    for (int j = 0; j < N; j++)
    {
        mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture); //Inserindo os valores dentro da matriz
    }
}

int linha = int.Parse(Console.ReadLine());
int coluna = int.Parse(Console.ReadLine());

// a) soma dos positivos
double soma = 0.0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] > 0.0)
        {
            soma = soma + mat[i, j];
        }
    }
}
Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

// b) imprimir os elementos da linha escolhida		
Console.Write("LINHA ESCOLHIDA: ");
for (int j = 0; j < N; j++)
{
    Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

// c) imprimir os elementos da coluna escolhida		
Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < N; i++)
{
    Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

// d) imprimir a diagonal principal
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

// e) alterar a matriz elevando os negativos ao quadrado
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] < 0.0)
        {
            mat[i, j] = mat[i, j] * mat[i, j];
        }
    }
}

Console.WriteLine("MATRIZ ALTERADA:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();