[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly PedidoService _pedidoService;

    public PedidosController(PedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ProcessarPedido([FromBody] Pedido pedido)
    {
        if (pedido.Produtos == null || !pedido.Produtos.Any())
        {
            return BadRequest("O pedido deve conter pelo menos um produto.");
        }

        var resultado = _pedidoService.ProcessarPedido(pedido);
        return Ok(resultado);
    }
}
