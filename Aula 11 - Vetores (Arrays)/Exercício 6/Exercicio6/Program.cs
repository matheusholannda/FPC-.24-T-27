//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando as listas com o tamanho que foi recebido em N
String[] nomes = new String[N];
int[] idades = new int[N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); //Pegando o que é digitado e guardando dentro da lista valores
    nomes[i] = valores[0]; //Separando o que foi informado em suas respectivas listas
    idades[i] = int.Parse(valores[1]);
}

// 1: primeiro vamos encontrar a posicao da maior idade
int maiorIdade = idades[0];
int posicaoMaiorIdade = 0;

for (int i = 1; i < N; i++)
{
    if (idades[i] > maiorIdade)
    {
        maiorIdade = idades[i];
        posicaoMaiorIdade = i;
    }
}

// 2: agora vamos acessar o vetor de nomes na posicao da maior idade
Console.WriteLine("\nPessoa mais velha: " + nomes[posicaoMaiorIdade]);

Console.ReadLine();
