//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int horaInicial = int.Parse(valores[0]);
int minutoInicial = int.Parse(valores[1]);
int horaFinal = int.Parse(valores[2]);
int minutoFinal = int.Parse(valores[3]);

//Fazendo as contas e devolvendo o resultado para o usuário
int instanteInicial = horaInicial * 60 + minutoInicial;
int instanteFinal = horaFinal * 60 + minutoFinal;
int duracao;
if (instanteInicial < instanteFinal)
{
    duracao = instanteFinal - instanteInicial;
}
else
{
    duracao = (24 * 60 - instanteInicial) + instanteFinal;
}

int duracaoHoras = duracao / 60;
int duracaoMinutos = duracao % 60;

Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
