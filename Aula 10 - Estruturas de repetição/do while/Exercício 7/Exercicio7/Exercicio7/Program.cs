//Declarando as variáveis
Random random = new Random(); //Instanciando um objeto da classe Random
int numeroAleatorio = random.Next(1, 101); //Através desse objeto utilizamos o método Next() que pega um número aleatório dentro do intervalo que você passar
int tentativas = 0;
int palpite;

do
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    Console.Write("Adivinhe o número (entre 1 e 100): ");
    palpite = int.Parse(Console.ReadLine());

    tentativas++; //Contabilizando o número de tentativas através da quantidade de vezes que o laço se repete

    //Afunilando o palpite do usuário
    if (palpite < numeroAleatorio)
        Console.WriteLine("Tente um número maior.");
    else if (palpite > numeroAleatorio)
        Console.WriteLine("Tente um número menor.");
    else
        Console.WriteLine($"Parabéns! Você adivinhou o número em {tentativas} tentativas.");
} while (palpite != numeroAleatorio);