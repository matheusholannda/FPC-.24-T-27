using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando a lista com o tamanho que foi recebido em N
string[] nomes = new String[N];
double[] compra = new double[N];
double[] venda = new double[N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); //Pegando o que é digitado e guardando dentro da lista valores
    nomes[i] = valores[0]; //Separando o que foi informado em suas respectivas listas
    compra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
    venda[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
}

// 1: vamos encontrar a quantidade para cada faixa de lucro desejada
int contAbaixoDe10 = 0;
int contEntre10E20 = 0;
int contAcimaDe20 = 0;
for (int i = 0; i < N; i++)
{

    double lucro = venda[i] - compra[i];

    double porcentagemDeLucro = lucro / compra[i] * 100.0;

    if (porcentagemDeLucro < 10.0)
    {
        contAbaixoDe10++;
    }
    else if (porcentagemDeLucro <= 20.0)
    {
        contEntre10E20++;
    }
    else
    {
        contAcimaDe20++;
    }
}
Console.WriteLine("\nLucro abaixo de 10%: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

// 2: vamos achar os totais
double totalCompra = 0.0;
double totalVenda = 0.0;
for (int i = 0; i < N; i++)
{
    totalCompra = totalCompra + compra[i];
    totalVenda = totalVenda + venda[i];
}

double totalLucro = totalVenda - totalCompra;

//Devolvendo tudo para o usuário
Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();