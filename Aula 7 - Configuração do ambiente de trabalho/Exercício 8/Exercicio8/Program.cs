using System.Globalization;

//Declarando as variáveis
int numero, horas;
double valorHora, salario;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
numero = int.Parse(Console.ReadLine());
horas = int.Parse(Console.ReadLine());
valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Fazendo a conta e atribuindo o resultado a variável salario
salario = valorHora * horas;

//Devolvendo o resultado para o usuário
Console.WriteLine("NUMBER = " + numero);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));