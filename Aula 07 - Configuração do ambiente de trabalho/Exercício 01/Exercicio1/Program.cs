//Declarando as variáveis
int A, B, X;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

//Fazendo a conta e atribuindo o resultado a variável X
X = A + B;

//Devolvendo o resultado para o usuário
Console.WriteLine("X = " + X);