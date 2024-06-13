// Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.

/*Sem função

Console.WriteLine("Digite três números");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 && n2 > n3)
{
    Console.WriteLine("Maior = " + n1);
}

else if (n2 > n3)
{
    Console.WriteLine("Maior = " + n2);
}
else
{
    Console.WriteLine("Maior = " + n3);
}

Console.ReadKey();*/

//Com função

static void Main(string[] args)
{
    Console.WriteLine("Digite três números");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());

    double resultado = Maior(n1, n2, n3);
    Console.WriteLine("Maior = " + resultado);

    Console.ReadKey();
}

static int Maior(int a, int b, int c)
{
    int m;
    if (a > b && a > c)
    {
        m = a;
    }
    else if (b > c)
    {
        m = b;
    }
    else
    {
        m = c;
    }
    return m;
}
