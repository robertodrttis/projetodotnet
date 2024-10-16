public class Pedido
{
    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
}

public class Produto
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Comprimento { get; set; }
}
