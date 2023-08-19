public class Pedido
{
    private int _id;
    private PedidoAvulso pedidoAvulso;
    private PedidoIdentificado pedidoIdentificado;
    private List<ItemPedido> itens = new List<ItemPedido>();
    private List<Pedido> pedidos = new List<Pedido>();

    public int Id()
    {
        get => _id;
        set => _id = value;
    }

    public PedidoAvulso PedidoAvulso(){
        get => pedidoAvulso;
        set => pedidoAvulso = value;
    }

    public PedidoIdentificado PedidoIdentificado(){
        get => pedidoIdentificado;
        set => pedidoIdentificado = value;
    }

    public List<ItemPedido> Itens(){
        get => pedidos;
        set => pedidos = value;
    }

    public boolean AdicionarPedido (Pedido pedido){
        pedidos.Add(pedido);
        return true;
    }

    public boolean ExcluirPedido (Pedido pedido){
        pedidos.remove(pedido);
        return true;
    }
}