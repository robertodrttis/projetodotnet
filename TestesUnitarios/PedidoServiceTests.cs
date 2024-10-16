public class PedidoServiceTests
{
    private readonly PedidoService _pedidoService;

    public PedidoServiceTests()
    {
        _pedidoService = new PedidoService();
    }

    [Fact]
    public void TestarEmpacotamentoSimples()
    {
        var pedido = new Pedido
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Produto 1", Altura = 10, Largura = 10, Comprimento = 10 }
            }
        };

        var resultado = _pedidoService.ProcessarPedido(pedido);

        Assert.NotNull(resultado);
        Assert.Single(resultado);
    }
}
