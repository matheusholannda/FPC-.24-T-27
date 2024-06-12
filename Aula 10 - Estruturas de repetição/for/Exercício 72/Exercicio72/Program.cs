//Recebendo o que o usuário digitar e guardando dentro da variável
int n = int.Parse(Console.ReadLine());

//Declarando as variáveis
int cont_in = 0;
int cont_out = 0;

//O n é a quantidade de valores inteiros X que serão lidos em seguida.
for (int i = 0; i < n; i++)
{
    //Recebendo o que o usuário digitar e guardando dentro da variável
    int x = int.Parse(Console.ReadLine());

    //Verificando se o número está no intervalo especificado e contabilizando nos contadores
    if (x >= 10 && x <= 20)
    {
        cont_in = cont_in + 1;
    }
    else
    {
        cont_out = cont_out + 1;
    }
}

//Devolvendo o resultado para o usuário
Console.WriteLine(cont_in + " in");
Console.WriteLine(cont_out + " out");