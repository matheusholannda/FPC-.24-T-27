//Declarando as variáveis
int x, y, z, maiorXY, maior;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
x = int.Parse(valores[0]);
y = int.Parse(valores[1]);
z = int.Parse(valores[2]);

//Fazendo as contas e devolvendo o resultado para o usuário
maiorXY = (x + y + Math.Abs(x - y)) / 2;
maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

Console.WriteLine(maior + " eh o maior");