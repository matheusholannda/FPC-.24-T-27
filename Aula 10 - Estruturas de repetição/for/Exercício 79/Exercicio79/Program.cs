using System.Globalization;

//Recebendo o que o usuário digitar e guardando dentro da variável
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) //O n é a quantidade de vezes que serão lidos em seguida os 3 valores para a média.
{
    //Recebendo o que o usuário digitar e guardando dentro do array line
    string[] line = Console.ReadLine().Split(' ');

    //Separando os valores que foram guardados dentro da lista em suas respectivas variáveis para calcular a média
    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

    //Fazendo o cálculo e devolvendo o resultado para o usuário
    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
