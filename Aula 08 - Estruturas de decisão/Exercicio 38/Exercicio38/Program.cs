using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
int codigo = int.Parse(valores[0]);
int quantidade = int.Parse(valores[1]);
double total;

//Calculando o valor total da compra de acordo com o código do produto
if (codigo == 1)
{
    total = quantidade * 4.0;
}
else if (codigo == 2)
{
    total = quantidade * 4.5;
}
else if (codigo == 3)
{
    total = quantidade * 5.0;
}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else
{
    total = quantidade * 1.5;
}

//Devolvendo o resultado para o usuário
Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));