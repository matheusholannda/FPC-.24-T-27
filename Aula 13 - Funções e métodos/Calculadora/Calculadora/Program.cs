Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem-vindo a Calculadora do Holandinha! Digite qual operação deseja executar:\n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair da calculadora");
    Console.Write("\n\n");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5:
            BarraCarregamento("\nObrigado por usar a calculadora do Holandinha!", 1000, 3);
            Environment.Exit(0);
            break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Write("\nPrimeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " + ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;
    Console.Clear();
    Console.WriteLine("\nO resultado da soma entre: " + v1 + " + " + v2 + " = " + resultado);
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Write("\nPrimeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " + ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;
    Console.Clear();
    Console.WriteLine("\nO resultado da subtração entre: " + v1 + " - " + v2 + " = " + resultado);
    Console.ReadKey();
    Menu();
}
static void Multiplicacao()
{
    Console.Write("\nPrimeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " + ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;
    Console.Clear();
    Console.WriteLine("\nO resultado da multiplicação entre: " + v1 + " * " + v2 + " = " + resultado);
    Console.ReadKey();
    Menu();
}
static void Divisao()
{
    Console.Write("\nPrimeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("\n" + v1 + " + ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;
    Console.Clear();
    Console.WriteLine("\nO resultado da divisão entre: " + v1 + " / " + v2 + " = " + resultado);
    Console.ReadKey();
    Menu();
}

static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write(texto);

    for (var contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}