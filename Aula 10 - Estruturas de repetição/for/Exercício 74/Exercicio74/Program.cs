//Recebendo o que o usuário digitar e guardando dentro da variável
int n = int.Parse(Console.ReadLine());

//O n é a quantidade de valores inteiros X que serão lidos em seguida.
for (int i = 0; i < n; i++)
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    int x = int.Parse(Console.ReadLine());

    if (x == 0)//Se for igual a zero
    {
        Console.WriteLine("NULL");
    }
    else if (x > 0) //Se for maior que 0 (é positivo)
    {
        if (x % 2 == 0) //Se for par
        {
            Console.WriteLine("EVEN POSITIVE");
        }
        else //Não sendo par, é ímpar
        {
            Console.WriteLine("ODD POSITIVE");
        }
    }
    else //Não sendo positivo, é negativo
    {
        if (x % 2 == 0) //Se for par
        {
            Console.WriteLine("EVEN NEGATIVE");
        }
        else //Não sendo par, é ímpar
        {
            Console.WriteLine("ODD NEGATIVE");
        }
    }
}