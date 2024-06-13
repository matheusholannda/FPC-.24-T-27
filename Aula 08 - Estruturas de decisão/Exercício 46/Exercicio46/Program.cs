//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int horaInicial = int.Parse(valores[0]);
int horaFinal = int.Parse(valores[1]);

//Declaração de variável
int duracao;

//Fazendo a conta e devolvendo o resultado para o usuário
if (horaInicial < horaFinal)
{
    duracao = horaFinal - horaInicial;
}
else
{
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");