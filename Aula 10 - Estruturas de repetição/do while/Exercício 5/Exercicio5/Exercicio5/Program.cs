//Declarando as variáveis
int total = 0;
int input;

do
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    Console.Write("Insira um número positivo (ou um número negativo para encerrar): ");
    input = int.Parse(Console.ReadLine());

    //Se o número for positivo vai adicionando a soma
    if (input > 0)
    {
        total += input;
    }
} while (input >= 0);//Se for negativo quebra o laço

//Devolvendo o resultado para o usuário
Console.WriteLine("A soma dos números positivos é: " + total);