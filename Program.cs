// Esta classe representa um estoque de produtos, permitindo adicionar novos produtos  
// e exibir a lista de todos os produtos armazenados.  
// Cada produto pode ter atributos como nome, quantidade e preço.
Produto produto = new Produto();
EstoqueProdutos estoqueProdutos = new EstoqueProdutos();

produto.Nome = "Notebook Gamer";
produto.Marca = "Dell";
produto.Preco = 4999.90;
produto.Estoque = 10;

Console.WriteLine(produto.Descricao);

estoqueProdutos.AdicionarProduto(produto);
estoqueProdutos.ExibirProdutos();