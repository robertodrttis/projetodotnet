public class Caixa
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Comprimento { get; set; }
}

public class ResultadoCaixa
{
    public string NomeCaixa { get; set; }
    public List<Produto> Produtos { get; set; }
}
