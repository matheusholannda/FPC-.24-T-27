//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);

//Fazendo a classificação verificando se o resto da divisão de um pelo outro é igual a 0 e devolvendo o resultado para o usuário
if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
