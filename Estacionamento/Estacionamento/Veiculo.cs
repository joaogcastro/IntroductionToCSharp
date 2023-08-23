internal class Veiculo
{
    public enum Cor { Undefined, Amarela, Azul, Branca, Verde, Vermelha, Preta }
    protected string _placa;
    protected Modelo _modelo;
    protected string _descricao;
    protected Cor _corExterna;

    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }

    public Modelo Modelo
    {
        get => _modelo;
        set => _modelo = value;
    }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }

    public Cor CorExterna
    {
        get => _corExterna;
        set => _corExterna = value;
    }

    public Veiculo(string placa, Modelo modelo, string descricao, Cor corExterna)
    {
        _placa = placa;
        _modelo = modelo;
        _descricao = descricao;
        _corExterna = corExterna;
    }

    public Veiculo()
    {
        _placa = string.Empty;
        _modelo = null;
        _descricao = string.Empty;
        _corExterna = Cor.Undefined;
    }
    public virtual void Mostrar()
    {
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Marca: " + Modelo.marca.Nome);
        Console.WriteLine("Modelo: "+ Modelo.Descricao);
        Console.WriteLine("Descricao: " + Descricao);
        Console.WriteLine("Cor do carro: " + CorExterna);
    }
}