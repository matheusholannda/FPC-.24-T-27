//Recebendo o que o usuário digitar e guardando dentro da variável
Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

//Declarando as variáveis
int soma = 0;
int i = 2;

// Enquanto o conteúdo da variável i for menor que o número digitado o laço se repete
while (i <= numero)
{
    //Somamos o valor de soma a ele mesmo + o valor de i
    soma += i;
    //Somamos o valor de i a ele mesmo + 2 (pegando somente os números pares)
    i += 2;
}

//Devolvendo o resultado para o usuário
Console.WriteLine("A soma dos números pares é: " + soma);