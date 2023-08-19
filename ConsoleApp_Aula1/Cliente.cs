public class Cliente
{   
    private int _id;
    private string _cpf;
    private string _nome;
    private static List<Cliente> clientes = new();
    //Getter and setter no C#
    public string Cpf
    {
        get => _cpf;
        set => _cpf = value;
    }

    //mesma função, sintaxe mais antiga
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public static boolean Inserir(Cliente cliente){
        cliente._id = clientes.count +1;
        clientes.Add(cliente);
        return true;
    }

    public static Cliente Consultar (string cpf){
        foreach(Cliente cliente in clientes) {
            if(cliente.Cpf == cpf){
                return cliente;
            }
        }
        return null;
    }

    public static boolean Alterar (Cliente cliente){
        clienteVelho = Consultar(cliente._cpf);
        cliente._id = clienteVelho._id;
        clientes.Add(cliente);
        return true;
    }

    public boolean Excluir (Cliente cliente){
        clientes.remove (cliente);
        return true;
    }
}