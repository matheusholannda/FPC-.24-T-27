//Recebendo o que o usuário digitar e guardando dentro da variável
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine().ToLower(); // Convertendo para minúsculas para ser "case-insensitive"

//Declarando as variáveis
int i = 0;
int j = palavra.Length - 1;
bool ehPalindromo = true; //flag

//Comparando a primeira letra com a última e assim por diante, enquanto a posição do i aumenta a do j diminui
while (i < j)
{
    if (palavra[i] != palavra[j])
    {
        ehPalindromo = false; //se a letra for diferente já sabemos que a palavra não é um palíndromo então a flag quebra o laço
        break;
    }
    i++;
    j--;
}

//Devolvendo o resultado para o usuário
if (ehPalindromo)
    Console.WriteLine("A palavra é um palíndromo.");
else
    Console.WriteLine("A palavra não é um palíndromo.");