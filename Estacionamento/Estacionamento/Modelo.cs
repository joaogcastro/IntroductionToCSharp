internal class Modelo
{
    private Marca _marca;
    private string _descricao;

    public Marca marca
    {
        get => _marca;
        set => _marca = value;
    }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }

    public Modelo()
    {
        _marca = null;
        _descricao = string.Empty;
    }

    public Modelo(Marca marca, string descricao)
    {
        _marca = marca;
        _descricao = descricao;
    }
}