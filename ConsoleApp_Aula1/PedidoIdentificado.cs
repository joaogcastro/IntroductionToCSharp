public class PedidoIdentificado : Pedido /*: significa herança*/
{
    private Cliente _cliente;

    public Cliente Cliente
    {
        get => _cliente;
        set => _cliente = value;
    }
}