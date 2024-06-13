using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a lista com o tamanho que foi recebido em N
double[] vet = new double[N];

string[] valores = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++) //Guardando os N números na lista vet
{
    vet[i] = double.Parse(valores[i]);
}

double somaDosPares = 0.0;
int quantidadeDePares = 0;
for (int i = 0; i < N; i++)
{
    if (vet[i] % 2 == 0) //Verificando se é par
    {
        somaDosPares = somaDosPares + vet[i]; //Sendo par adiciona na soma
        quantidadeDePares++; //Contabiliza quando for adicionado
    }
}

if (quantidadeDePares == 0)
{
    Console.WriteLine("Nao havia nenhum numero par");
}
else
{
    double media = somaDosPares / quantidadeDePares;
    Console.WriteLine("\n" + media.ToString("F1", CultureInfo.InvariantCulture));
}

Console.ReadLine();
