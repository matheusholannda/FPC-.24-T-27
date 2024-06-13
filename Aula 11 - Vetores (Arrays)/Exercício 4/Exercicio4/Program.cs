using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a lista com o tamanho que foi recebido em N
double[] vet = new double[N];

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Guardando os N números na lista vet
}

// 1: calculando e mostrando a media
double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma = soma + vet[i];
}
double media = soma / N;
Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

// 2: mostrando todos elementos abaixo da media
Console.WriteLine("VALORES ABAIXO DA MEDIA:");
for (int i = 0; i < N; i++)
{
    if (vet[i] < media)
    {
        Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
    }
}

Console.ReadLine();