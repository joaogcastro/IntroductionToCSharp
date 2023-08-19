public class Program
{
    public static void Main(string[] args)
    {

        Pedido P = new();
        PedidoIdentificado pi = new();

        Cliente c = new();
        List<Cliente> clientes = new();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("CPF: ");
            c.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();
            clientes.Add(c);
        }

        Console.WriteLine("Os dados inseridos foram: ");

        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine("CPF: " + clientes[i].Cpf);
            Console.WriteLine("Nome: " + clientes[i].Nome);
        }
    }
}