using Acompanhamento;
using Pizza;

public class ItemPedido
{
    private static List<Pizza> pizzas = new List<Pizza>();
    private static List<Acompanhamento> acompanhamentos = new List<Acompanhamento>();

    public static boolean AdicionarPizzaAoPedido(Pizza pizza)
    {
        pizzas.Add(pizza);
        return true;
    }

    public static boolean AdicionarAcompanhamento(Acompanhamento acompanhamento){
        acompanhamentos.Add(acompanhamento);
        return true;
    }


}