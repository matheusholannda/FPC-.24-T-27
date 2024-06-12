//Apenas uma exibição para o usuário
Console.WriteLine(@$" 
-----------------------------------
|     Bem vindo ao programa       | 
|           FutResult             |
----------------------------------
");

//Declarando as variáveis
int golTimeA;
int golTimeB;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Entre com a quantidade de gols do time A");
golTimeA = int.Parse(Console.ReadLine());
Console.WriteLine($"Entre com a quantidade de gols do time B");
golTimeB = int.Parse(Console.ReadLine());

//Condição para sabermos se o resultado do jogo foi um empate, uma vitória ou uma derrota e de qual time
if (golTimeA== golTimeB)
{
    Console.WriteLine($"O resultado do jogo foi um empate!");
}
else if (golTimeA > golTimeB)
{
    Console.WriteLine($"A vitória foi do time A");
} else 
{
    Console.WriteLine($"A vitória foi do time B")
}
