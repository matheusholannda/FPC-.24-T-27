using System.Globalization;

//Declarando as variáveis
int tempo, velocidade, distancia;
double litros;

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
tempo = int.Parse(Console.ReadLine());
velocidade = int.Parse(Console.ReadLine());

//Fazendo a conta e atribuindo o resultado a variável distância
distancia = tempo * velocidade;
// aqui é importante colocar o .0 depois do 12, ou entao fazer o casting (double)
litros = distancia / 12.0;

//Devolvendo o resultado para o usuário
Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));