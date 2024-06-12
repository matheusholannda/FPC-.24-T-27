//Declarando as variáveis
string senhaCorreta = "senha123";
string senhaInserida;

do
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    Console.Write("Digite a senha: ");
    senhaInserida = Console.ReadLine();
} while (senhaInserida != senhaCorreta); //Repetindo o laço enquanto a senhaInserida for diferente da senhaCorreta

//Devolvendo o resultado para o usuário
Console.WriteLine("Bem-vindo! A senha está correta.");