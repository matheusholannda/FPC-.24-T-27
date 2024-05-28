using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável salario
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

///Fazendo as contas do valor do imposto, classificando e devolvendo o resultado para o usuário
double imposto;
if (salario <= 2000.0)
{
    imposto = 0.0;
}
else if (salario <= 3000.0)
{
    imposto = (salario - 2000.0) * 0.08;
}
else if (salario <= 4500.0)
{
    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
}
else
{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (imposto == 0.0)
{
    Console.WriteLine("Isento");
}
else
{
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}