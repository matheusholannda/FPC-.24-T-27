//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Digite uma letra: ");
string letra = Console.ReadLine().ToLower();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine($"A letra é uma vogal!");
}
else
{
    Console.WriteLine($"A letra é uma consoante!");
}
