using static Acompanhamento;
using static Pizza;

public class ItemPedido
{
    private static List<Pizza> pizzas = new List<Pizza>();
    private static List<Acompanhamento> acompanhamentos = new List<Acompanhamento>();

    public static bool AdicionarPizzaAoPedido(Pizza pizza)
    {
        pizzas.Add(pizza);
        return true;
    }

    public static bool AdicionarAcompanhamento(Acompanhamento acompanhamento)
    {
        acompanhamentos.Add(acompanhamento);
        return true;
    }


}