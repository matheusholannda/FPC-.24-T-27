//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Responda as questões com sim ou nao");
Console.WriteLine($"você telefonou para a vitima?");
string q1 = Console.ReadLine().ToLower();
Console.WriteLine($"você esteve no local do crime?");
string q2 = Console.ReadLine().ToLower();
Console.WriteLine($"você Mora perto da vítima?");
string q3 = Console.ReadLine().ToLower();
Console.WriteLine($"você devia para a vítima?");
string q4 = Console.ReadLine().ToLower();
Console.WriteLine($"você já trabalhou com a vítima?");
string q5 = Console.ReadLine().ToLower();

//Declarando a variável contagem para servir como contador
int contagem = 0;

//Cada resposta que for igual a "sim" sera acrescido 1 no nosso contador
if (q1 == "sim")
{
    contagem = contagem + 1;
}

if (q2 == "sim")
{
    contagem = contagem + 1;
}

if (q3 == "sim")
{
    contagem = contagem + 1;
}

if (q4 == "sim")
{
    contagem = contagem + 1;
}

//Classificando de acordo com a quantidade de respostas positivas
if (contagem <= 2)
{
    Console.WriteLine($"Suspeito");
}
else if (contagem > 2 && contagem <= 4)
{
    Console.WriteLine($"Cúmplice");
}
else
{
    Console.WriteLine($"Culpado!");
}