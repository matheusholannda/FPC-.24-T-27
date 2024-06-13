using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

//Instanciando as listas com o tamanho que foi recebido em N
String[] nomes = new String[N];
double[] notasSemestre1 = new double[N];
double[] notasSemestre2 = new double[N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' '); // Pegando o que é digitado e guardando dentro da lista valores
    nomes[i] = valores[0]; //Separando o que foi informado em suas respectivas listas
    notasSemestre1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
    notasSemestre2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
}

Console.WriteLine("\nAlunos aprovados:");
for (int i = 0; i < N; i++)
{
    double media = (notasSemestre1[i] + notasSemestre2[i]) / 2.0; //Calculando a media
    if (media >= 6.0)
    {
        Console.WriteLine(nomes[i]); //Devolvendo somente os nomes onde suas notas estão acima da média
    }
}

Console.ReadLine();
