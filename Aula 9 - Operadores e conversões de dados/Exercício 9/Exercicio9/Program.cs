using System.Globalization;

//Declarando as variáveis
string nome;
double salarioFixo, totalVenda, salarioTotal;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
nome = Console.ReadLine();
salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e devolvendo o resultado para o usuário
salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;

Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));