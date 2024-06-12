//Apenas uma exibição para o usuário
Console.WriteLine(@$" 
-----------------------------------
|Bem vindo ao programa | 
| Banco XPTO |
----------------------------------
");

//Recebendo o que o usuário digitar e guardando dentro das respectivas variáveis
Console.WriteLine($"Entre com o valor do salário recebido: ");
float salario = float.Parse(Console.ReadLine());
Console.WriteLine($"Entre com o valor do gasto: ");
float gasto = float.Parse(Console.ReadLine());

//Devolvendo o resultado para o usuário de acordo com a condição
if (salario > gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
    Console.WriteLine($"Orçamento estourado");
}
