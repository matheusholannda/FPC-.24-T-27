//Declarando as variáveis
int A, N, soma;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
A = int.Parse(valores[0]);
N = int.Parse(valores[1]);

//Recebendo o valor de N enquanto ele for negativo (considerando o 0 como negativo)
while (N <= 0)
{
    N = int.Parse(Console.ReadLine());
}

soma = 0;
for (int i = 0; i < N; i++)
{
    soma += A + i; //Enquanto o índice é menor que N o valor de soma é igual ao seu valor atual + valor de A + o índice
}
Console.WriteLine(soma);