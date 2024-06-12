using System.Globalization;

//Declarando as variáveis
double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

//Recebendo o que o usuário digitar e guardando dentro do array valores
string[] valores = Console.ReadLine().Split(' ');

//Separando os valores que foram guardados dentro do array valores dentro das respectivas variáveis
A = double.Parse(valores[0], CultureInfo.InvariantCulture);
B = double.Parse(valores[1], CultureInfo.InvariantCulture);
C = double.Parse(valores[2], CultureInfo.InvariantCulture);

//Fazendo as contas e devolvendo o resultado para o usuário
triangulo = A * C / 2.0;
circulo = 3.14159 * C * C;
trapezio = (A + B) / 2.0 * C;
quadrado = B * B;
retangulo = A * B;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));