//Declaração de variáveis
int x, y, z, maior, meio, menor;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
x = int.Parse(valores[0]);
y = int.Parse(valores[1]);
z = int.Parse(valores[2]);

//Fazendo a classificação e devolvendo o resultado para o usuário
if (x < y && x < z)
{
    menor = x;
    if (y < z)
    {
        meio = y;
        maior = z;
    }
    else
    {
        meio = z;
        maior = y;
    }
}
else if (y < z)
{
    menor = y;
    if (x < z)
    {
        meio = x;
        maior = z;
    }
    else
    {
        meio = z;
        maior = x;
    }
}
else
{
    menor = z;
    if (x < y)
    {
        meio = x;
        maior = y;
    }
    else
    {
        meio = y;
        maior = x;
    }
}

Console.WriteLine(menor);
Console.WriteLine(meio);
Console.WriteLine(maior);
Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);