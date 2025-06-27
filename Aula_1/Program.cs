using ExemploFundamentos.Models;

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual.ToString("MM/dd/yyyy HH:mm:ss")}");
Console.WriteLine(dataAtual);

dataAtual = DateTime.Now.AddDays(10);
Console.WriteLine($"Data atual: {dataAtual.ToString("MM/dd/yyyy HH:mm:ss")}");
Console.WriteLine(dataAtual);


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