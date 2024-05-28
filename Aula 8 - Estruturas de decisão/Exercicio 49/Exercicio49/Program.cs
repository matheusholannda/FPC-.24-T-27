//Recebendo o que o usuário digitar e guardando dentro das variáveis
string palavra1 = Console.ReadLine();
string palavra2 = Console.ReadLine();
string palavra3 = Console.ReadLine();

//Classificando de acordo com as respostas e devolvendo o resultado para o usuário
if (palavra1 == "vertebrado")
{
    if (palavra2 == "ave")
    {
        if (palavra3 == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else
        {
            Console.WriteLine("pomba");
        }
    }
    else
    {
        if (palavra3 == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else
        {
            Console.WriteLine("vaca");
        }
    }
}
else
{
    if (palavra2 == "inseto")
    {
        if (palavra3 == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        else
        {
            Console.WriteLine("lagarta");
        }
    }
    else
    {
        if (palavra3 == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else
        {
            Console.WriteLine("minhoca");
        }
    }
}