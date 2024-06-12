//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int m = int.Parse(valores[0]);
int n = int.Parse(valores[1]);

//Repete o laço enquanto ambos os valores forem maiores que 0
while (m > 0 && n > 0)
{
    //Verificando qual deles é o maior
    int menor = m;
    int maior = n;
    if (m > n)
    {
        menor = n;
        maior = m;
    }

    //Mostra o intervalo entre eles com base no índice do for
    int soma = 0;
    for (int i = menor; i <= maior; i++)
    {
        soma = soma + i; //vai fazendo a soma dos números que estão nesse intervalo
        Console.Write(i + " ");
    }
    Console.WriteLine("Sum=" + soma);

    //Recebendo novamente o que o usuário digitar e guardando dentro do array valores enquanto os valores forem maiores que 0
    valores = Console.ReadLine().Split(' ');

    //Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
    m = int.Parse(valores[0]);
    n = int.Parse(valores[1]);
}