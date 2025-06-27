using ExemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int QuantidadeComprada = 5;
bool produtoDisponivel = quantidadeEmEstoque >= QuantidadeComprada;


if (produtoDisponivel)
{
    Console.WriteLine("Produto disponível para compra.");
}
else
{
    Console.WriteLine("Produto indisponível no estoque.");
}











// int a = Convert.ToInt32("10");
// Console.WriteLine(a);

// int b = int.Parse("20");



// Console.WriteLine(a);
// Console.WriteLine(b);



// int a = 10;

// int b = 20;

// int c = a + b;


// Console.WriteLine($"A soma de {a} + {b} é igual a {c}");

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine($"Data atual: {dataAtual.ToString("MM/dd/yyyy HH:mm:ss")}");
// Console.WriteLine(dataAtual);

// dataAtual = DateTime.Now.AddDays(10);
// Console.WriteLine($"Data atual: {dataAtual.ToString("MM/dd/yyyy HH:mm:ss")}");
// Console.WriteLine(dataAtual);


// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// quantidade = 10;
// double altura = 1.75211;
// decimal preco = 1.75m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Quantidade: {quantidade}");
// Console.WriteLine($"Altura: {altura.ToString("F4")}");
// Console.WriteLine($"Preço: {preco}");
// Console.WriteLine($"Condição: {condicao}");


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Ra";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();