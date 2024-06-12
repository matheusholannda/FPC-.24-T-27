//Recebendo o que o usuário digitar e guardando dentro da variável
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i % 2 != 0) //Só exibimos o número se dividirmos o número por 2 e houver resto, caso não haja resto o número é par
    {
        Console.WriteLine(i); 
    }
}