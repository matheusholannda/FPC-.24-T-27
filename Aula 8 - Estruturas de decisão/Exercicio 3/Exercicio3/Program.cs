//Declarando as variáveis
string senhaCadastrada = "1234";
string senhaDigitada;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Entre com a quantidade de gols do time A");
senhaDigitada = Console.ReadLine();

//Se a "senha cadastrada" for igual a senha digitada permitimos o acesso
if (senhaCadastrada == senhaDigitada)
{
    Console.WriteLine($"Acesso permitido!");
}
else
{
    Console.WriteLine($"Acesso negado!");
}
