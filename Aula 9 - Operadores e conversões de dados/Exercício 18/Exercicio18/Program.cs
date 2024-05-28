int N, quociente, resto, nota;

//Recebendo o que o usuário digitar e guardando dentro da variável
N = int.Parse(Console.ReadLine());
Console.WriteLine(N);

//Fazendo a conta para descobrir quantas notas de 100 seriam possíveis
resto = N;
nota = 100;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

//À partir daqui nós pegamos o restante de cada divisão e vamos redivindo esse resto para descobrir as notas menores até que só sobrem notas de 1
resto = resto % nota;
nota = 50;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

resto = resto % nota;
nota = 20;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

resto = resto % nota;
nota = 10;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

resto = resto % nota;
nota = 5;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

resto = resto % nota;
nota = 2;
quociente = resto / nota;
Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

resto = resto % nota;
Console.WriteLine(resto + " nota(s) de R$ 1,00");