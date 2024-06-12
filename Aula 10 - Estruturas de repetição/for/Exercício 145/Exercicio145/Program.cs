//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');
//Separando os valores que foram guardados dentro da lista em suas respectivas variáveis
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

for (int i = 1; i <= y; i++)
{
    Console.Write(i);
    if (i % x == 0) //Se a divisão do primeiro número não tiver resto pulamos a linha
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write(" ");//Se não apenas damos um espaço
    }
}