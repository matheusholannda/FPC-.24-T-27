//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.Write($"Informe o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"\nBom dia " + nome + "!");

Console.Write($"Sr.(a)" + nome + ", informe o o seu peso atual: ");
double peso = double.Parse(Console.ReadLine());

Console.Write($"Informe agora a sua altura: ");
double altura = double.Parse(Console.ReadLine());

//Fazendo a conta e devolvendo o resultado para o usuário
double imc = peso / (Math.Pow(altura, 2)) * 100;
// double imc  = peso / (altura * altura)*100;

Console.WriteLine($"\nO paciente " + nome + "tem imc igual a: " + Math.Round(imc, 2));
Console.WriteLine($"Obrigado por usar nosso sistema");