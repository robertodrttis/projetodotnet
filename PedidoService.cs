public class PedidoService
{
    private readonly List<Caixa> caixasDisponiveis = new List<Caixa>
    {
        new Caixa { Nome = "Caixa 1", Altura = 30, Largura = 40, Comprimento = 80 },
        new Caixa { Nome = "Caixa 2", Altura = 80, Largura = 50, Comprimento = 40 },
        new Caixa { Nome = "Caixa 3", Altura = 50, Largura = 80, Comprimento = 60 }
    };

    public List<ResultadoCaixa> ProcessarPedido(Pedido pedido)
    {
        var resultado = new List<ResultadoCaixa>();

        return resultado;
    }
}
