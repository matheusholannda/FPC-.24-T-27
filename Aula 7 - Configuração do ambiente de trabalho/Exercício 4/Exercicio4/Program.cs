//Declarando as variáveis
int x, y, prod;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

//Fazendo a conta e atribuindo o resultado a variável prod
prod = x * y;

//Devolvendo o resultado para o usuário
Console.WriteLine("PROD = " + prod);