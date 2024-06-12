//Recebendo o que o usuário digitar e guardando dentro da variável
int maior = int.Parse(Console.ReadLine()); // vamos considerar o primeiro valor como sendo inicialmente o maior
//Declarando uma variável para guardarmos a posição do maior número
int posicao = 1;

// agora vamos ler do segundo até o centésimo 
for (int i = 2; i <= 100; i++)
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    int x = int.Parse(Console.ReadLine());
    if (x > maior) //Se o valor que acabou de ser inserido for maior que o conteúdo da variável maior
    {
        maior = x;//Ele assume o valor da variável maior
        posicao = i;//Usamos o índice do for para pegarmos a posição do número inserido
    }
}

//Devolvendo o resultado para o usuário
Console.WriteLine(maior);
Console.WriteLine(posicao);