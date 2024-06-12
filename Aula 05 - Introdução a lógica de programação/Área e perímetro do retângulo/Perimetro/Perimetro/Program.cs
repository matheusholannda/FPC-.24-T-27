//Declarando as variáveis
double baseR, altura, perimetro, area;

//Exibindo texto e esperando a entrada do usuário
Console.WriteLine("Entre com a base: ");
//Pegando o que o usuário digitou e guardando dentro da variável
baseR = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a altura: ");
altura = double.Parse(Console.ReadLine());

//Fazendo os cálculos e salvando o resultado dentro das respectivas variáveis
perimetro = 2 * (baseR + altura);
area = baseR * altura;

//Devolvendo as informações para o usuário
Console.WriteLine("O perímetro do retângulo é: " + perimetro);
Console.WriteLine("A área do retângulo é: " + area);
Console.WriteLine("Pressione ENTER para sair...");

//Aguardando uma tecla do usuário para encerrar o sistema
Console.ReadKey();