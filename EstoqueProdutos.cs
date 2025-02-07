class EstoqueProdutos
{
    public List<Produto> Produtos { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto) 
    {
        Produtos.Add(produto);

        Console.WriteLine($"\nProduto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos() 
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("\nEstoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("\nLista de produtos no estoque:");

            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}
