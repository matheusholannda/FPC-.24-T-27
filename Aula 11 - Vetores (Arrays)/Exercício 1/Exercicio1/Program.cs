using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a lista com o tamanho que foi recebido em N
double[] vet = new double[N];

for (int i = 0; i < N; i++) //Guardando os N números na lista vet
{
    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double maior = vet[0]; // Vamos considerar o primeiro valor como sendo inicialmente o maior
int posicaoMaior = 0; //Declarando uma variável para guardarmos a posição do maior número

for (int i = 1; i < N; i++)
{
    if (vet[i] > maior) //Se o valor for maior que o conteúdo da variável maior
    {
        maior = vet[i]; //Ele assume o valor da variável maior
        posicaoMaior = i; //Usamos o índice do for para pegarmos a posição do número inserido
    }
}

//Devolvendo o resultado para o usuário
Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(posicaoMaior);

Console.ReadLine();