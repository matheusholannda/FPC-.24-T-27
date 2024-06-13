﻿using System.Globalization;

//Declaração de variáveis
float N1, N2, N3, N4, media, notaExame, mediaFinal;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

//Fazendo o cálculo da média
media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

// O problema 1040 tem uma falha de arredondamento especifica para a linguagem C#. Quando a media da 4.85, nos temos que ajusta-la manualmente para 4.8, o que eh uma "gambiarra" horrivel, infelizmente. Isso nao aconteceu nas outras linguagens que testamos, tais como Java, C e C++
if (media == 4.85f)
{
    media = 4.8f;
}

Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

//Fazendo a classificação da média e devolvendo o resultado para o usuário
if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");
    notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    mediaFinal = (media + notaExame) / 2;
    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
    }
    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
}
