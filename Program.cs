// See https://aka.ms/new-console-template for more information
using CSHARP_E_DOTNET.Modelos;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Bruno";
pessoa1.Idade = 25;
pessoa1.Apresentar();

//testando tipos de dados
bool condicao = true;
decimal preco = 1.80M;
double altura = 1.80;
Console.WriteLine("Valor da variável condicao: " + condicao);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável altura: " + altura);

//double só considera 1 casa decimal. Para informar quantas casas exibir:
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));

