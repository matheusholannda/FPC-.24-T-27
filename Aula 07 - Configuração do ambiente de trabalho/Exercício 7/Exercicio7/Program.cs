//Declarando as variáveis
int A, B, C, D, dif;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

//Fazendo a conta e atribuindo o resultado a variável dif
dif = A * B - C * D;

//Devolvendo o resultado para o usuário
Console.WriteLine("DIFERENCA = " + dif);