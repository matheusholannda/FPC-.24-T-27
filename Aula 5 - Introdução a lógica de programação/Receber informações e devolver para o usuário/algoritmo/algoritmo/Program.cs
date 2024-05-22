//Declaração de variáveis
string nome, endereco, telefone;

//Exibir no console
Console.WriteLine("Entre com o nome: ");
//Pegando o que o usuário digitou com o Console.ReadLine() e atribuindo o conteúdo a variável nome
nome = Console.ReadLine();

Console.WriteLine("Entre com o endereço: ");
endereco = Console.ReadLine();

Console.WriteLine("Entre com o telefone: ");
telefone = Console.ReadLine();

//Exibindo as informações que captamos
Console.WriteLine("Seu nome é: " + nome);
Console.WriteLine("Seu endereço é: " + endereco);
Console.WriteLine("Seu telefone é: " + telefone);
Console.WriteLine("Pressione ENTER para sair");

//Espera uma tecla do usuário para encerrar o sistema
Console.ReadKey();