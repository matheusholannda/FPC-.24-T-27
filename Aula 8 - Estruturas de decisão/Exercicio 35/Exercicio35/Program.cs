//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);
int C = int.Parse(valores[2]);
int D = int.Parse(valores[3]);

//Especificando a condição que o exercicio pede para aceitar os valores
if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}