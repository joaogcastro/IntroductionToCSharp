public class Cliente
{
    private string _cpf;
    private string _nome;
    public static List<Cliente> clientes = new();
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
}