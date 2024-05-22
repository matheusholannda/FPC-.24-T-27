//Declarando as variáveis
int distancia, tempo;

//Recebendo o que o usuário digitar e guardando dentro da variável
distancia = int.Parse(Console.ReadLine());

//Fazendo a conta e atribuindo o resultado a variável tempo
tempo = distancia * 2;

//Devolvendo o resultado para o usuário
Console.WriteLine(tempo + " minutos");