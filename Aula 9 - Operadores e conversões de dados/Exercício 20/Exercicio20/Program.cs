//Declarando as variáveis
int N, anos, meses, dias, resto;

//Recebendo o que o usuário digitar e guardando dentro da variável
N = int.Parse(Console.ReadLine());

//Fazendo as contas e devolvendo o resultado para o usuário
anos = N / 365;
resto = N % 365;
meses = resto / 30;
dias = resto % 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(dias + " dia(s)");