internal class Marca
{
    private string _nome;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

public Marca()
{
    _nome = string.Empty;
}

public Marca(string nome)
{
    _nome = nome;
}
}