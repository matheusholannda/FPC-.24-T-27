//Recebendo o que o usuário digitar e guardando dentro da variável
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++) //O n é a quantidade de valores inteiros X que serão lidos em seguida.
{
    //Recebendo o que o usuário digitar e guardando dentro do array valores
    string[] valores = Console.ReadLine().Split(' ');

    //Separando os valores que foram guardados dentro da lista em suas respectivas variáveis
    int x = int.Parse(valores[0]);
    int y = int.Parse(valores[1]);

    if (x > y)
    {
        int aux = x;
        x = y;
        y = aux;
    }

    int soma = 0;
    for (int j = x + 1; j < y; j++) //o índice começa com o valor de x + 1
    {
        if (j % 2 != 0) //Se o número que estiver no intervalo for ímpar adicionamos a soma 
        {
            soma = soma + j;
        }
    }
    Console.WriteLine(soma);
}